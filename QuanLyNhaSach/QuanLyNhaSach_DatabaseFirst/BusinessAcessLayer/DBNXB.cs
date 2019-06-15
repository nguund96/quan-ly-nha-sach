using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBNXB
    {
        
        QLNSEntities db;
        public DBNXB()
        {
            db = new QLNSEntities();
        }
        public List<NXB> getNXB()
        {
            var List = from nxb in db.NXBs
                       select nxb;
            return List.ToList();
        }
        public bool ThemNXB(ref string err, string MaNXB, string TenNXB, int TinhTrang)
        {
            try
            {
                var nxb = new NXB
                {
                    MaNXB = MaNXB,
                    TenNXB = TenNXB,
                    TinhTrang = TinhTrang == 1 ? true : false
                };

                db.NXBs.Add(nxb);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatNXB(ref string err, string MaNXB, string TenNXB, int TinhTrang)
        {
            try
            {
                var nxb = db.NXBs.Find(MaNXB);
                if (nxb != null)
                {
                    nxb.TenNXB = TenNXB;
                    nxb.TinhTrang = TinhTrang == 1 ? true : false;

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
    }
}
