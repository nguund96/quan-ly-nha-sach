using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAcessLayer;

namespace QuanLyNhaSach.DanhMuc
{
    public partial class frmChiTietHDNhap : Form
    {
        QLNSEntities db;
        DBHoaDonNhap dbHoaDonNhap;
        public frmChiTietHDNhap()
        {
            InitializeComponent();
            db = new QLNSEntities();
            dbHoaDonNhap = new DBHoaDonNhap();
        }
        //FormLoad
        private void frmChiTietHDNhap_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ VW_ChiTietHDNhap vào dgvChiTietHDNhap
            dgvChiTietHDNhap.DataSource = db.VW_ChiTietHDNhap.ToList();
        }
        
        //Xử lý tìm kiếm chi tiết hóa đơn nhập
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvChiTietHDNhap.DataSource = TimKiem(txtTimKiem.Text.Trim());
        }
        private List<VW_ChiTietHDNhap> TimKiem(string str)
        {
            var List = from ct in db.VW_ChiTietHDNhap
                       where ct.MaHDN.Contains(str) || ct.MaSach.Contains(str) || ct.TenSach.Contains(str)
                           || ct.SoLuong.ToString().Contains(str) || ct.GiaNhap.ToString().Contains(str)
                           || ct.ThanhTien.ToString().Contains(str)
                       select ct;
            return List.ToList();
        }
        
        //Thoát
        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lấy ra mã hóa đơn nhập của dòng đang chọn trên dgvChiTietHDNhap
        private string getMaHDNDangChon()
        {
            if (dgvChiTietHDNhap.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvChiTietHDNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDNhap.Rows.Count) return "";
            return dgvChiTietHDNhap.Rows[r].Cells[0].Value.ToString();
        }
        //Lấy ra mã sách của dòng đang chọn trên dgvChiTietHDNhap
        private string getMaSachDangChon()
        {
            if (dgvChiTietHDNhap.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvChiTietHDNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDNhap.Rows.Count) return "";
            return dgvChiTietHDNhap.Rows[r].Cells[1].Value.ToString();
        }
        //Xử lý button xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonNhap.XoaChiTietHoaDonNhap(ref err, getMaHDNDangChon(), getMaSachDangChon());
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvChiTietHDNhap.DataSource = db.VW_ChiTietHDNhap.ToList();
        }
    }
}
