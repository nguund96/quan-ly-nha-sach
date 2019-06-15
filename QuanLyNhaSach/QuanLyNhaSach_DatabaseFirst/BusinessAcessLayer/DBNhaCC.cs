using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBNhaCC
    {
        
        QLNSEntities db;
        public DBNhaCC()
        {
            db = new QLNSEntities();
        }
        public List<NhaCC> getNhaCC()
        {
            var List = from ncc in db.NhaCCs
                       select ncc;
            return List.ToList();
        }
        public bool ThemNhaCC(ref string err, string MaNCC, string TenNCC, string DiaChi, string SDT, int TinhTrang)
        {
            try
            {
                var ncc = new NhaCC
                {
                    MaNCC = MaNCC,
                    TenNCC = TenNCC,
                    DiaChi = DiaChi,
                    SDT = SDT,
                    TinhTrang = TinhTrang == 1 ? true : false
                };

                db.NhaCCs.Add(ncc);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatNhaCC(ref string err, string MaNCC, string TenNCC, string DiaChi, string SDT, int TinhTrang)
        {
            try
            {
                var ncc = db.NhaCCs.Find(MaNCC);
                if(ncc != null)
                {
                    ncc.TenNCC = TenNCC;
                    ncc.DiaChi = DiaChi;
                    ncc.SDT = SDT;
                    ncc.TinhTrang = TinhTrang == 1 ? true : false;

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
