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
    public class DBHoaDonBan
    {
        DALayer dal;
        public DBHoaDonBan()
        {
            dal = new DALayer();
        }
        public DataSet getHoaDonBan()
        {
            return dal.ExecuteQueryDataSet("select * from HoaDonBan", CommandType.Text, null);
        }
        public DataSet getHoaDonBanTheoChuoiTimKiem(string str)
        {
            string sql = string.Format("select * from HoaDonBan where MaHDB like N'%{0}%' or MaNV like N'%{1}%' or HoTenKH like N'%{2}%'", str, str, str);
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }
        public DataSet getThongTinSach(string MaSach)
        {
            return dal.ExecuteQueryDataSet("select * from Sach where MaSach = '" + MaSach + "'", CommandType.Text, null);
        }
        public DataSet getChiTietHoaDonBanTheoMaHDB(string MaHDB)
        {
            return dal.ExecuteQueryDataSet("select * from ChiTietHDBan where MaHDB = '" + MaHDB + "'", CommandType.Text, null);
        }

        public bool ThemHoaDonBan(ref string err, string MaHDB, string MaNV, string HoTenKH, DateTime NgayLapHD)
        {
            return dal.MyExecuteNonQuery("spInsertHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", MaHDB),
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoTenKH", HoTenKH),
                new SqlParameter("@NgayLapHD", NgayLapHD));
        }
        public bool XoaHoaDonBan(ref string err, string MaHDB)
        {
            return dal.MyExecuteNonQuery("spDeleteHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", MaHDB));
        }
        public bool CapNhatHoaDonBan(ref string err, string MaHDB, string MaNV, string HoTenKH, DateTime NgayLapHD)
        {
            return dal.MyExecuteNonQuery("spUpdateHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", MaHDB),
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoTenKH", HoTenKH),
                new SqlParameter("@NgayLapHD", NgayLapHD));
        }


        public bool ThemChiTietHoaDonBan(ref string err, string MaHDB, string MaSach, int SoLuong)
        {
            return dal.MyExecuteNonQuery("spInsertChiTietHDBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", MaHDB),
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@SoLuong", SoLuong));
        }
        public bool XoaChiTietHoaDonBan(ref string err, string MaHDB, string MaSach)
        {
            return dal.MyExecuteNonQuery("spDeleteChiTietHDBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", MaHDB),
                new SqlParameter("@MaSach", MaSach));
        }
        public bool CapNhatChiTietHoaDonBan(ref string err, string MaHDB, string MaSach, int SoLuong)
        {
            return dal.MyExecuteNonQuery("spUpdateChiTietHDBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", MaHDB),
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@SoLuong", SoLuong));
        }

        //SoLuongSachThem = SoLuongSachCu - SoLuongSachMoi (SoLuongSachThem có thể âm)
        public bool CapNhatLaiSoLuongSachTon(ref string err,string MaSach, int SoLuongThem)
        {
            return dal.MyExecuteNonQuery("spCapNhatLaiSoLuongSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@SoLuongThem", SoLuongThem));
        }
    }
}
