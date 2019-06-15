using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessAcessLayer
{
    public class DBHoaDonNhap
    {
        
        QLNSEntities db;
        public DBHoaDonNhap()
        {
            db = new QLNSEntities();
        }
        public List<HoaDonNhap> getHoaDonNhap()
        {
            var List = from hdn in db.HoaDonNhaps
                       select hdn;
            return List.ToList();
        }
        public List<NhaCC> getNhaCC()
        {
            var List = from ncc in db.NhaCCs
                       select ncc;
            return List.ToList();
        }
        public List<ChiTietHoaDonNhap> getChiTietHoaDonNhapTheoMaHDN(string MaHDN)
        {
            var List = from cthdn in db.ChiTietHoaDonNhaps
                       where cthdn.MaHDN == MaHDN
                       select cthdn;
            return List.ToList();
        }
        public List<HoaDonNhap> getHoaDonNhapTheoChuoiTimKiem(string str)
        {
            //Xử lý tìm theo ngày tháng, nếu đúng định dạng thì tìm theo ngày tháng
            try
            {
                DateTime dt = Convert.ToDateTime(str);
                var List = from hdn in db.HoaDonNhaps
                           where hdn.NgayLap.Value == dt
                           select hdn;
                return List.ToList();
            }
            catch
            {
                var List = from hdn in db.HoaDonNhaps
                           where hdn.MaHDN.Contains(str) || hdn.MaNV.Contains(str) || hdn.MaNCC.Contains(str)
                                || hdn.NhaCC.TenNCC.Contains(str) || (hdn.NhanVien.HoNV + hdn.NhanVien.TenNV).Contains(str)
                           select hdn;
                return List.ToList();
            }
        }


        public bool ThemHoaDonNhap(ref string err, string MaHDN, string MaNCC, string MaNV, DateTime NgayLap)
        {
            try
            {
                var hdn = new HoaDonNhap
                {
                    MaHDN = MaHDN,
                    MaNCC = MaNCC,
                    MaNV = MaNV,
                    NgayLap = NgayLap
                };

                db.HoaDonNhaps.Add(hdn);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaHoaDonNhap(ref string err, string MaHDN)
        {
            try
            {
                var hdn = db.HoaDonNhaps.Find(MaHDN);
                if (hdn != null)
                {   
                    //Xóa chi tiết hóa đơn nhập trước
                    hdn.ChiTietHoaDonNhaps.ToList().ForEach(ct => db.ChiTietHoaDonNhaps.Remove(ct));
                    //Xóa hóa đơn nhập
                    db.HoaDonNhaps.Remove(hdn);
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
        public bool CapNhatHoaDonNhap(ref string err, string MaHDN, string MaNCC, string MaNV, DateTime NgayLap)
        {
            try
            {
                var hdn = db.HoaDonNhaps.Find(MaHDN);
                if (hdn != null)
                {
                    hdn.MaNCC = MaNCC;
                    hdn.MaNV = MaNV;
                    hdn.NgayLap = NgayLap;

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

        public bool ThemChiTietHoaDonNhap(ref string err, string MaHDN, string MaSach, int SoLuong, float GiaNhap)
        {
            try
            {
                var ct = new ChiTietHoaDonNhap
                {
                    MaHDN = MaHDN,
                    MaSach = MaSach,
                    SoLuong = SoLuong,
                    GiaNhap = GiaNhap
                };

                db.ChiTietHoaDonNhaps.Add(ct);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaChiTietHoaDonNhap(ref string err, string MaHDN, string MaSach)
        {
            try
            {
                var ct = db.ChiTietHoaDonNhaps.Find(MaHDN, MaSach);
                if(ct != null)
                {
                    db.ChiTietHoaDonNhaps.Remove(ct);
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
        public bool CapNhatChiTietHoaDonNhap(ref string err, string MaHDN, string MaSach, int SoLuong, float GiaNhap)
        {
            try
            {
                var ct = db.ChiTietHoaDonNhaps.Find(MaHDN, MaSach);
                if (ct != null)
                {
                    ct.SoLuong = SoLuong;
                    ct.GiaNhap = GiaNhap;

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
