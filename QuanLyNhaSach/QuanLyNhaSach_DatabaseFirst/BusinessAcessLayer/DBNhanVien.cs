using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BusinessAcessLayer
{
    public class DBNhanVien
    {
        
        QLNSEntities db;
        public DBNhanVien()
        {
            db = new QLNSEntities();
        }
        public List<NhanVien> getNhanVien()
        {
            var List = from nv in db.NhanViens
                       select nv;
            return List.ToList();
        }
        public List<NhanVien> getNhanVienChuoiTimKiem(string str)
        {
            //Xử lý tìm theo ngày tháng, nếu đúng định dạng thì tìm theo ngày tháng
            try
            {
                DateTime dt = Convert.ToDateTime(str);
                var List = from nv in db.NhanViens
                           where nv.NgaySinh.Value == dt || nv.NgayNV.Value == dt
                           select nv;
                return List.ToList();
            }
            catch
            {
                var List = from nv in db.NhanViens
                           where nv.MaNV.Contains(str) || nv.HoNV.Contains(str) || nv.TenNV.Contains(str)
                           || (nv.HoNV + " " + nv.TenNV).Contains(str) || nv.DiaChi.Contains(str) || nv.SoDT.Contains(str)
                           || nv.Luong.ToString().Contains(str)
                           select nv;
                return List.ToList();
            }

        }
        public int getQuyenNhanVienTheoMaNV(string MaNV)
        {
            bool Quyen = false;
            var Q = (from tk in db.TaiKhoans
                     where tk.MaNV == MaNV
                     select tk.Quyen);
            foreach(var q in Q)
            {
                Quyen = q.Value;
                break;
            }
            return Quyen ? 1 : 0;
        }
        public string getMatKhauNhanVienTheoMaNV(string MaNV)
        {
            string MatKhau = "";
            var MK = (from tk in db.TaiKhoans
                       where tk.MaNV == MaNV
                       select tk.MatKhau);
            foreach (var mk in MK)
            {
                MatKhau = mk.ToString();
                break;
            }
            return MatKhau;
        }
        public bool ThemTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            return (new DBTaiKhoan()).ThemTaiKhoan(ref err, MaNV, MatKhau, Quyen);
        }
        public bool CapNhatTaiKhoan(ref string err, string MaNV, string MatKhau, int Quyen)
        {
            return (new DBTaiKhoan()).CapNhatTaiKhoan(ref err, MaNV, MatKhau, Quyen);
        }
        public bool ThemNhanVien(ref string err, string MaNV, string HoNV, string TenNV, DateTime NgaySinh, int Nu, DateTime NgayNV, string DiaChi, string SoDT,
            float Luong, int TinhTrang)
        {
            try
            {
                var nv = new NhanVien
                {
                    MaNV = MaNV,
                    HoNV = HoNV,
                    TenNV = TenNV,
                    NgaySinh = NgaySinh,
                    Nu = Nu == 1 ? true : false,
                    NgayNV = NgayNV,
                    DiaChi = DiaChi,
                    SoDT = SoDT,
                    Luong = Luong,
                    TinhTrang = TinhTrang == 1 ? true : false
                };

                db.NhanViens.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatNhanVien(ref string err, string MaNV, string HoNV, string TenNV, DateTime NgaySinh, int Nu, DateTime NgayNV, string DiaChi, string SoDT,
            float Luong, int TinhTrang)
        {
            try
            {
                var nv = db.NhanViens.Find(MaNV);
                if(nv != null)
                {
                    nv.HoNV = HoNV;
                    nv.TenNV = TenNV;
                    nv.NgaySinh = NgaySinh;
                    nv.Nu = Nu == 1 ? true : false;
                    nv.NgayNV = NgayNV;
                    nv.DiaChi = DiaChi;
                    nv.SoDT = SoDT;
                    nv.Luong = Luong;
                    nv.TinhTrang = TinhTrang == 1 ? true : false;

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
