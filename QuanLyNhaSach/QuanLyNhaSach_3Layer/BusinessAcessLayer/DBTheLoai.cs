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
    public class DBTheLoai
    {
        DALayer dal = null;
        public DBTheLoai()
        {
            dal = new DALayer();
        }
        public DataSet getTheLoai()
        {
            return dal.ExecuteQueryDataSet("select * from TheLoai", CommandType.Text, null);
        }
        public bool ThemTheLoai(ref string err, string MaTheLoai, string TenTheLoai, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spInsertTheLoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTheLoai", MaTheLoai),
                new SqlParameter("@TenTheLoai", TenTheLoai),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool CapNhatTheLoai(ref string err, string MaTheLoai, string TenTheLoai, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spUpdateTheLoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaTheLoai", MaTheLoai),
                new SqlParameter("@TenTheLoai", TenTheLoai),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
    }
}
