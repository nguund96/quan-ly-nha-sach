using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBSach
    {
        
        QLNSEntities db;
        public DBSach()
        {
            db = new QLNSEntities();
        }
        public List<Sach> getSach()
        {
            var List = from s in db.Saches
                       select s;
            return List.ToList();
        }
        public List<TacGiaVietSach> getTacGiaTheoMaSach(string MaSach)
        {
            var List = from tg in db.TacGiaVietSaches
                       where tg.MaSach == MaSach
                       select tg;
            return List.ToList();
        }
        public List<Sach> getSachTheoChuoiTimKiem(string str)
        {
            var List = from s in db.Saches
                       where s.MaSach.Contains(str) || s.TenSach.Contains(str) || s.MaTheLoai.Contains(str) 
                       || s.MaNXB.Contains(str) || s.TheLoai.TenTheLoai.Contains(str) || s.NXB.TenNXB.Contains(str) 
                       || s.GiaBan.ToString().Contains(str)
                       select s;
            return List.ToList();
        }
        public bool ThemSach(ref string err, string MaSach, string TenSach, string MaTheLoai,
            string MaNXB, float GiaBan, int SoLuongTon, int TinhTrang)
        {
            try
            {
                var s = new Sach
                {
                    MaSach = MaSach,
                    TenSach = TenSach,
                    MaTheLoai = MaTheLoai,
                    MaNXB = MaNXB,
                    GiaBan = GiaBan,
                    SoLuongTon = SoLuongTon,
                    TinhTrang = TinhTrang == 1 ? true : false
                };

                db.Saches.Add(s);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatSach(ref string err, string MaSach, string TenSach, string MaTheLoai,
            string MaNXB, float GiaBan, int SoLuongTon, int TinhTrang)
        {
            try
            {
                var s = db.Saches.Find(MaSach);
                if (s != null)
                {
                    s.TenSach = TenSach;
                    s.MaTheLoai = MaTheLoai;
                    s.MaNXB = MaNXB;
                    s.GiaBan = GiaBan;
                    s.SoLuongTon = SoLuongTon;
                    s.TinhTrang = TinhTrang == 1 ? true : false;

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

        public bool ThemTacGiaVietSach(ref string err, string MaSach, string TenTacGia)
        {
            try
            {
                var ts = new TacGiaVietSach
                {
                    MaSach = MaSach,
                    TenTacGia = TenTacGia
                };

                db.TacGiaVietSaches.Add(ts);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaTatCaTacGiaTheoMaSach(ref string err, string MaSach)
        {
            try
            {
                var sach = db.Saches.Find(MaSach);
                if (sach != null)
                {
                    foreach (TacGiaVietSach ts in sach.TacGiaVietSaches)
                    {
                        db.TacGiaVietSaches.Remove(ts);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
