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
    public class DBNXB
    {
        DALayer dal = null;
        public DBNXB()
        {
            dal = new DALayer();
        }
        public DataSet getNXB()
        {
            return dal.ExecuteQueryDataSet("select * from NXB", CommandType.Text, null);
        }
        public bool ThemNXB(ref string err, string MaNXB, string TenNXB, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spInsertNXB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNXB", MaNXB),
                new SqlParameter("@TenNXB", TenNXB),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool CapNhatNXB(ref string err, string MaNXB, string TenNXB, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spUpdateNXB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNXB", MaNXB),
                new SqlParameter("@TenNXB", TenNXB),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
    }
}
