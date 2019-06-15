using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBTheLoai
    {
        QLNSEntities db;
        public DBTheLoai()
        {
            db = new QLNSEntities();
        }
        public List<TheLoai> getTheLoai()
        {
            var List = from tl in db.TheLoais
                       select tl;
            return List.ToList();
        }
        public bool ThemTheLoai(ref string err, string MaTheLoai, string TenTheLoai, int TinhTrang)
        {
            try
            {
                var tl = new TheLoai
                {
                    MaTheLoai = MaTheLoai,
                    TenTheLoai = TenTheLoai,
                    TinhTrang = TinhTrang == 1 ? true : false
                };

                db.TheLoais.Add(tl);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatTheLoai(ref string err, string MaTheLoai, string TenTheLoai, int TinhTrang)
        {
            try
            {
                var tl = db.TheLoais.Find(MaTheLoai);
                if (tl != null)
                {
                    tl.TenTheLoai = TenTheLoai;
                    tl.TinhTrang = TinhTrang == 1 ? true : false;
                    
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
