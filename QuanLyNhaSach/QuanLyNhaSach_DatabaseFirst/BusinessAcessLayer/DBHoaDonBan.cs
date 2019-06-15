using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBHoaDonBan
    {
        
        QLNSEntities db;
        public DBHoaDonBan()
        {
            db = new QLNSEntities();
        }
        public List<HoaDonBan> getHoaDonBan()
        {
            var List = from hdb in db.HoaDonBans
                       select hdb;
            return List.ToList();
        }
        public List<HoaDonBan> getHoaDonBanTheoChuoiTimKiem(string str)
        {
            //Xử lý tìm theo ngày tháng, nếu đúng định dạng thì tìm theo ngày tháng
            try
            {
                DateTime dt = Convert.ToDateTime(str);
                var List = from hdb in db.HoaDonBans
                           where hdb.NgayLapHD.Value == dt
                           select hdb;
                return List.ToList();
            }
            catch
            {
                var List = from hdb in db.HoaDonBans
                           where hdb.MaHDB.Contains(str) || hdb.MaNV.Contains(str) || hdb.HoTenKH.Contains(str)
                           || hdb.NhanVien.HoNV.Contains(str) || hdb.NhanVien.TenNV.Contains(str)
                           select hdb;
                return List.ToList();
            }
        }
        public List<Sach> getThongTinSach(string MaSach)
        {
            var List = from s in db.Saches
                       where s.MaSach == MaSach
                       select s;
            return List.ToList();
        }
        public List<ChiTietHDBan> getChiTietHoaDonBanTheoMaHDB(string MaHDB)
        {
            var List = from ct in db.ChiTietHDBans
                       where ct.MaHDB == MaHDB
                       select ct;
            return List.ToList();
        }

        public bool ThemHoaDonBan(ref string err, string MaHDB, string MaNV, string HoTenKH, DateTime NgayLapHD)
        {
            try
            {
                var hdb = new HoaDonBan
                {
                    MaHDB = MaHDB,
                    MaNV = MaNV,
                    HoTenKH = HoTenKH,
                    NgayLapHD = NgayLapHD
                };

                db.HoaDonBans.Add(hdb);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaHoaDonBan(ref string err, string MaHDB)
        {
            try
            {
                var hdb = db.HoaDonBans.Find(MaHDB);
                if(hdb != null)
                {
                    //Xóa chi tiết hóa đơn bán
                    hdb.ChiTietHDBans.ToList().ForEach(ct => db.ChiTietHDBans.Remove(ct));
                    //Xóa hóa đơn bán
                    db.HoaDonBans.Remove(hdb);
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
        public bool CapNhatHoaDonBan(ref string err, string MaHDB, string MaNV, string HoTenKH, DateTime NgayLapHD)
        {
            try
            {
                var hdb = db.HoaDonBans.Find(MaHDB);
                if (hdb != null)
                {
                    hdb.MaNV = MaNV;
                    hdb.HoTenKH = HoTenKH;
                    hdb.NgayLapHD = NgayLapHD;

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


        public bool ThemChiTietHoaDonBan(ref string err, string MaHDB, string MaSach, int SoLuong)
        {
            try
            {
                var ct = new ChiTietHDBan
                {
                    MaHDB = MaHDB,
                    MaSach = MaSach,
                    SoLuong = SoLuong
                };

                db.ChiTietHDBans.Add(ct);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaChiTietHoaDonBan(ref string err, string MaHDB, string MaSach)
        {
            try
            {
                var ct = db.ChiTietHDBans.Find(MaHDB, MaSach);
                if (ct != null)
                {
                    db.ChiTietHDBans.Remove(ct);
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
        public bool CapNhatChiTietHoaDonBan(ref string err, string MaHDB, string MaSach, int SoLuong)
        {
            try
            {
                var ct = db.ChiTietHDBans.Find(MaHDB, MaSach);
                if (ct != null)
                {
                    ct.SoLuong = SoLuong;

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

        //Cập nhật lại số lượng sách khi: thêm chi tiết HĐ bán, xóa chi tiết hóa đơn bán và xóa hóa đơn bán
        //SoLuongThem là số lượng sách thêm vào hay bớt đi (nếu thêm vào thì là dương, ngược lại bớt đi là âm)
        public bool CapNhatLaiSoLuongSachTon(ref string err,string MaSach, int SoLuongThem)
        {
            try
            {
                var sach = db.Saches.Find(MaSach);
                if (sach != null)
                {
                    sach.SoLuongTon += SoLuongThem;

                    db.SaveChanges();
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
