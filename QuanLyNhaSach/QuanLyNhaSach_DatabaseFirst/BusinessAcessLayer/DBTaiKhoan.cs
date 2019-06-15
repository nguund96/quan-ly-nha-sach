using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Reflection;

namespace BusinessAcessLayer
{
    public class DBTaiKhoan
    {
        QLNSEntities db;
        public DBTaiKhoan()
        {
            db = new QLNSEntities();
        }
        public bool ThemTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            try
            {
                var tk = new TaiKhoan
                    {
                        MaNV = MaNV,
                        MatKhau = MatKhau,
                        Quyen = Quyen == 1 ? true : false
                    };

                db.TaiKhoans.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaTaiKhoan(ref string err, string MaNV)
        {
            try
            {
                var tk = db.TaiKhoans.Find(MaNV);
                if (tk != null)
                {
                    db.TaiKhoans.Remove(tk);
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            try
            {
                var tk = db.TaiKhoans.Find(MaNV);
                if (tk != null)
                {
                    tk.MatKhau = MatKhau;
                    tk.Quyen = Quyen == 1 ? true : false;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public DataSet DangNhap(ref string err, string MaNV, string MatKhau)
        {
            //Lấy ra được một bảng gồm các cột MaNV, MatKhau, HoNV, TenNV, Quyen, TinhTrang           
            var KQ =
                from tk in db.TaiKhoans
                where tk.MaNV == MaNV
                join nv in db.NhanViens on tk.MaNV equals nv.MaNV
                select new { nv.MaNV, tk.MatKhau, nv.HoNV, nv.TenNV, tk.Quyen, nv.TinhTrang};

            return LINQToDataSet(KQ);
        }

        public DataSet LINQToDataSet<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            DataSet ds = new DataSet();
            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null)
            {
                ds.Tables.Add(dtReturn);
                return ds;
            }

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others 
                //will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            ds.Tables.Add(dtReturn);
            return ds;
        }
    }
}
