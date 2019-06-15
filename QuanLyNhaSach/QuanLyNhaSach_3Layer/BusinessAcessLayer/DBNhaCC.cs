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
    public class DBNhaCC
    {
        DALayer dal = null;
        public DBNhaCC()
        {
            dal = new DALayer();
        }
        public DataSet getNhaCC()
        {
            return dal.ExecuteQueryDataSet("select * from NhaCC", CommandType.Text, null);
        }
        public bool ThemNhaCC(ref string err, string MaNCC, string TenNCC, string DiaChi, string SDT, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spInsertNhaCC", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
        public bool CapNhatNhaCC(ref string err, string MaNCC, string TenNCC, string DiaChi, string SDT, int TinhTrang)
        {
            return dal.MyExecuteNonQuery("spUpdateNhaCC", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@TinhTrang", TinhTrang));
        }
    }
}
