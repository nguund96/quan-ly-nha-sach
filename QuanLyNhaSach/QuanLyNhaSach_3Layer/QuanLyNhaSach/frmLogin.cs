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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DBTaiKhoan dbTaiKhoan = new DBTaiKhoan();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string err = "";
            DataSet ds = dbTaiKhoan.DangNhap(ref err, txtMaNV.Text.Trim(), txtMatKhau.Text.Trim());
            if(ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Clear();
                txtMatKhau.Clear();
                txtMaNV.Focus();
                return;
            }
            if (Convert.ToInt32(ds.Tables[0].Rows[0]["TinhTrang"]) == 0)
            {
                MessageBox.Show("Bạn đã nghỉ việc, vui lòng liên hệ với quản lý để kích hoạt lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Visible = false;
            (new frmMain(ds.Tables[0].Rows[0]["MaNV"].ToString(), ds.Tables[0].Rows[0]["MatKhau"].ToString(),
                ds.Tables[0].Rows[0]["HoNV"].ToString(), ds.Tables[0].Rows[0]["TenNV"].ToString(),
                Convert.ToInt32(ds.Tables[0].Rows[0]["Quyen"]))).ShowDialog();
            this.Visible = true;

            if(!cbNhoMatKhau.Checked)
            {
                txtMatKhau.Clear();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
