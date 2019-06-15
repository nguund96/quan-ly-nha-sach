using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessAcessLayer
{
    public class DBTaiKhoan
    {
        DALayer dal = null;
        public DBTaiKhoan()
        {
            dal = new DALayer();
        }
        public bool ThemTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            return dal.MyExecuteNonQuery("spInsertTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@Quyen", Quyen));
        }
        public bool XoaTaiKhoan(ref string err, string MaNV)
        {
            return dal.MyExecuteNonQuery("spDeleteTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV));
        }
        public bool CapNhatTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            return dal.MyExecuteNonQuery("spUpdateTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@Quyen", Quyen));
        }
        public DataSet DangNhap(ref string err, string MaNV, string MatKhau)
        {
            //Lấy ra được một bảng gồm các cột MaNV, MatKhau, HoNV, TenNV, Quyen, TinhTrang
            return dal.ExecuteQueryDataSet("select NV.MaNV, MatKhau, HoNV, TenNV, Quyen, NV.TinhTrang from NhanVien NV, (select * from TaiKhoan where MaNV ='" + MaNV + "' and MatKhau = '" + MatKhau + "') as TK where NV.MaNV = TK.MaNV", CommandType.Text, null);
        }
    }
}
