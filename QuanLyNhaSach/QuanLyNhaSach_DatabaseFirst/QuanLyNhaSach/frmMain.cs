using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string MaNV, string MatKhau, string HoNV, string TenNV, int Quyen)
        {
            InitializeComponent();
            MaNVDangDangNhap = MaNV;
            MatKhauNVDangDangNhap = MatKhau;
            HoNVDangDangNhap = HoNV;
            TenNVDangDangNhap = TenNV;
            QuyenDangDangNhap = Quyen;
        }
        public static string MaNVDangDangNhap = "", MatKhauNVDangDangNhap = "", HoNVDangDangNhap = "", TenNVDangDangNhap = "";
        public static int QuyenDangDangNhap = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = "Mã NV: " + MaNVDangDangNhap + "  Họ tên: " + HoNVDangDangNhap + " " + TenNVDangDangNhap + "   Quyền: " + (QuyenDangDangNhap == 1 ? "Quản lý" : "Nhân viên");
            if (QuyenDangDangNhap == 1) TSMI_NhanVien.Enabled = true;
        }
        private void LoadTabPage(string TabPageTitle,string TabPageName, UserControl uc)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.TabPages[i].Name == TabPageName)
                {
                    tabControl.SelectedTab = tabControl.TabPages[i];
                    return;
                }
            }
            TabPage tp = new TabPage(TabPageTitle);
            tp.Name = TabPageName;
            tp.Controls.Add(uc);
            tabControl.TabPages.Add(tp);
            tabControl.SelectedTab = tabControl.TabPages[TabPageName];
        }

        //ToolStrip
        private void TSB_DongTab_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab != null)
                tabControl.TabPages.Remove(tabControl.SelectedTab);
        }
        private void TSB_DongTatCaCacTab_Click(object sender, EventArgs e)
        {
            if(tabControl.TabPages.Count > 0)
                tabControl.TabPages.Clear();
        }

        //Quản lý
        private void TSMI_HoaDonBan_Click(object sender, EventArgs e)
        {
            LoadTabPage("Hóa đơn bán", "TabPage_HoaDonBan", new ucHoaDonBan());
        }
        private void TSMI_NhanVien_Click(object sender, EventArgs e)
        {
            LoadTabPage("Nhân viên", "TabPage_NhanVien", new ucNhanVien());
        }
        private void TSMI_Sach_Click(object sender, EventArgs e)
        {
            LoadTabPage("Sách", "TabPage_Sach", new ucSach());
        }
        private void TSMI_HoaDonNhap_Click(object sender, EventArgs e)
        {
            LoadTabPage("Hóa đơn nhập", "TabPage_HoaDonNhap", new ucHoaDonNhap());
        }
        private void TSMI_ThongKe_Click(object sender, EventArgs e)
        {
            LoadTabPage("Thống kê", "TabPage_ThongKe", new ucThongKe());
        }

        //Trang chủ
        private void TSMI_DoiMatKhau_Click(object sender, EventArgs e)
        {
            (new frmDoiMatKhau()).ShowDialog();
        }
        private void TSMI_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Danh mục
        private void DanhMuc_NhaCungCap_Click(object sender, EventArgs e)
        {
            (new frmNhaCC()).ShowDialog();
        }
        private void DanhMuc_NhaXuatBan_Click(object sender, EventArgs e)
        {
            (new frmNXB()).ShowDialog();
        }
        private void DanhMuc_TheLoai_Click(object sender, EventArgs e)
        {
            (new frmTheLoai()).ShowDialog();
        }
        private void DanhMuc_Sach_Click(object sender, EventArgs e)
        {
            (new DanhMuc.frmSach()).ShowDialog();
        }
        private void DanhMuc_NhanVien_Click(object sender, EventArgs e)
        {
            (new DanhMuc.frmNhanVien()).ShowDialog();
        }
        private void DanhMuc_ChiTietHDBan_Click(object sender, EventArgs e)
        {
            (new DanhMuc.frmChiTietHDBan()).ShowDialog();
        }
        private void DanhMuc_HoaDonBan_Click(object sender, EventArgs e)
        {
            (new DanhMuc.frmHoaDonBan()).ShowDialog();
        }
        private void DanhMuc_HoaDonNhap_Click(object sender, EventArgs e)
        {
            (new DanhMuc.frmHoaDonNhap()).ShowDialog();
        }
        private void DanhMuc_ChiTietHDNhap_Click(object sender, EventArgs e)
        {
            (new DanhMuc.frmChiTietHDNhap()).ShowDialog();
        }
    }
}
