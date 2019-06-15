using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
namespace BusinessAcessLayer
{
    public class DBNhanVien
    {
        DALayer dal;
        public DBNhanVien()
        {
            dal = new DALayer();
        }
        public DataSet getNhanVien()
        {
            return dal.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text, null);
        }
        public DataSet getNhanVienChuoiTimKiem(string str)
        {
            string sql = string.Format("select * from NhanVien where MaNV like N'%{0}%' or TenNV like N'%{1}%'", str, str);
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }
        public int getQuyenNhanVienTheoMaNV(string MaNV)
        {
            DataSet ds = dal.ExecuteQueryDataSet("select Quyen from TaiKhoan where MaNV = '" + MaNV + "'", CommandType.Text, null);
            if (ds.Tables[0].Rows.Count == 0) return -1;
            string Quyen = ds.Tables[0].Rows[0]["Quyen"].ToString();
            if (Quyen == "True") return 1;
            else return 0;
        }
        public string getMatKhauNhanVienTheoMaNV(string MaNV)
        {
            DataSet ds = dal.ExecuteQueryDataSet("select MatKhau from TaiKhoan where MaNV = '" + MaNV + "'", CommandType.Text, null);
            if (ds.Tables[0].Rows.Count == 0) return "";
            return ds.Tables[0].Rows[0]["MatKhau"].ToString();
        }
        public bool ThemTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            return dal.MyExecuteNonQuery("spInsertTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@Quyen", Quyen));
        }
        public bool CapNhatTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            return dal.MyExecuteNonQuery("spUpdateTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@Quyen", Quyen));
        }
        public bool ThemNhanVien(ref string err, string MaNV, string HoNV, string TenNV, DateTime NgaySinh, int Nu, DateTime NgayNV, string DiaChi, string SoDT,
            float Luong, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spInsertNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@Nu", Nu),
                new SqlParameter("@NgayNV", NgayNV),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT),
                new SqlParameter("@Luong", Luong),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool CapNhatNhanVien(ref string err, string MaNV, string HoNV, string TenNV, DateTime NgaySinh, int Nu, DateTime NgayNV, string DiaChi, string SoDT,
            float Luong, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spUpdateNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@Nu", Nu),
                new SqlParameter("@NgayNV", NgayNV),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT),
                new SqlParameter("@Luong", Luong),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
    }
}
