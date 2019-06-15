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

namespace QuanLyNhaSach
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        DBTaiKhoan dbTaiKhoan = new DBTaiKhoan();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ!", "Thông báo");
                txtMatKhauCu.Clear();
                txtMatKhauCu.Focus();
                return;
            }
            if (txtMatKhauMoi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới!", "Thông báo");
                txtMatKhauMoi.Clear();
                txtMatKhauMoi.Focus();
                return;
            }
            if(txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại không khớp!", "Thông báo");
                txtNhapLai.Clear();
                txtNhapLai.Focus();
                return;
            }
            if(txtMatKhauCu.Text != frmMain.MatKhauNVDangDangNhap)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo");
                txtMatKhauCu.Clear();
                txtMatKhauCu.Focus();
                return;
            }
            string err = "";
            bool KQ = dbTaiKhoan.CapNhatTaiKhoan(ref err, frmMain.MaNVDangDangNhap, txtMatKhauMoi.Text, frmMain.QuyenDangDangNhap);
            if(!KQ)
            {
                MessageBox.Show("Lỗi rồi!\n" + err, "Không đổi được mật khẩu", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            frmMain.MatKhauNVDangDangNhap = txtMatKhauMoi.Text;
            MessageBox.Show("Đã đổi mật khẩu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
