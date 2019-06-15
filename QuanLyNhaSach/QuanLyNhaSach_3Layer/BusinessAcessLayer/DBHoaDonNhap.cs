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
    public class DBHoaDonNhap
    {
        DALayer dal;
        public DBHoaDonNhap()
        {
            dal = new DALayer();
        }
        public DataSet getHoaDonNhap()
        {
            return dal.ExecuteQueryDataSet("select * from HoaDonNhap", CommandType.Text, null);
        }
        public DataSet getNhaCC()
        {
            return dal.ExecuteQueryDataSet("select * from NhaCC", CommandType.Text, null);
        }
        public DataSet getChiTietHoaDonNhapTheoMaHDN(string MaHDN)
        {
            return dal.ExecuteQueryDataSet("select * from ChiTietHoaDonNhap where MaHDN = '" + MaHDN + "'", CommandType.Text, null);
        }
        public DataSet getHoaDonNhapTheoChuoiTimKiem(string str)
        {
            string sql = string.Format("select * from HoaDonNhap where MaHDN like N'%{0}%' or MaNV like N'%{1}%' or MaNCC like N'%{2}%'", str, str, str);
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }


        public bool ThemHoaDonNhap(ref string err, string MaHDN, string MaNCC, string MaNV, DateTime NgayLap)
        {
            return dal.MyExecuteNonQuery("spInsertHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", MaHDN),
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@NgayLap", NgayLap));
        }
        public bool XoaHoaDonNhap(ref string err, string MaHDN)
        {
            return dal.MyExecuteNonQuery("spDeleteHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", MaHDN));
        }
        public bool CapNhatHoaDonNhap(ref string err, string MaHDN, string MaNCC, string MaNV, DateTime NgayLap)
        {
            return dal.MyExecuteNonQuery("spUpdateHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", MaHDN),
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@NgayLap", NgayLap));
        }

        public bool ThemChiTietHoaDonNhap(ref string err, string MaHDN, string MaSach, int SoLuong, float GiaNhap)
        {
            return dal.MyExecuteNonQuery("spInsertChiTietHDNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", MaHDN),
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@GiaNhap", GiaNhap));
        }
        public bool XoaChiTietHoaDonNhap(ref string err, string MaHDN, string MaSach)
        {
            return dal.MyExecuteNonQuery("spDeleteChiTietHDNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", MaHDN),
                new SqlParameter("@MaSach", MaSach));
        }
        public bool CapNhatChiTietHoaDonNhap(ref string err, string MaHDN, string MaSach, int SoLuong, float GiaNhap)
        {
            return dal.MyExecuteNonQuery("spUpdateChiTietHDNhap", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaHDN", MaHDN),
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@GiaNhap", GiaNhap));
        }

    }
}
