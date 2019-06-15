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
    public class DBSach
    {
        DALayer dal = null;
        public DBSach()
        {
            dal = new DALayer();
        }

        public DataSet getSach()
        {
            return dal.ExecuteQueryDataSet("select * from Sach", CommandType.Text, null);
        }
        public DataSet getTacGiaTheoMaSach(string MaSach)
        {
            return dal.ExecuteQueryDataSet("select TenTacGia from TacGiaVietSach where MaSach = '" + MaSach + "'", CommandType.Text, null);
        }
        public DataSet getSachTheoChuoiTimKiem(string str)
        {
            string sql = string.Format("select * from Sach where MaSach like N'%{0}%' or TenSach like N'%{1}%' or MaTheLoai like N'%{2}%' or MaNXB like N'%{3}%'", str, str, str, str);
            return dal.ExecuteQueryDataSet(sql, CommandType.Text, null);
        }
        public bool ThemSach(ref string err, string MaSach, string TenSach, string MaTheLoai,
            string MaNXB, float GiaBan, int SoLuongTon, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spInsertSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@TenSach", TenSach),
                new SqlParameter("@MaTheLoai", MaTheLoai),
                new SqlParameter("@MaNXB", MaNXB),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@SoLuongTon", SoLuongTon),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool CapNhatSach(ref string err, string MaSach, string TenSach, string MaTheLoai,
            string MaNXB, float GiaBan, int SoLuongTon, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spUpdateSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@TenSach", TenSach),
                new SqlParameter("@MaTheLoai", MaTheLoai),
                new SqlParameter("@MaNXB", MaNXB),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@SoLuongTon", SoLuongTon),
                new SqlParameter("@TinhTrang", TinhTrang));
        }

        public bool ThemTacGiaVietSach(ref string err, string MaSach, string TenTacGia)
        {
            return dal.MyExecuteNonQuery("spInsertTacGiaVietSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSach", MaSach),
                new SqlParameter("@TenTacGia", TenTacGia));
        }
        public bool XoaTatCaTacGiaTheoMaSach(ref string err, string MaSach)
        {
            return dal.MyExecuteNonQuery("spDeleteAllTacGiaVietSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSach", MaSach));
        }
    }
}
