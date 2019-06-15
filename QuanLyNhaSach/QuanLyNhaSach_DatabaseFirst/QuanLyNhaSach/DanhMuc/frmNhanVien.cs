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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        DBNhanVien dbNhanVien = new DBNhanVien();
        //FormLoad
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> ds = dbNhanVien.getNhanVien();
            dgvNhanVien.DataSource = ds;
            dgvNhanVien.Columns[10].Visible = false;
            dgvNhanVien.Columns[11].Visible = false;
        }
        //Thoát
        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Xử lý tìm kiếm nhân viên
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvNhanVien.DataSource = dbNhanVien.getNhanVien();
                dgvNhanVien.Columns[10].Visible = false;
                dgvNhanVien.Columns[11].Visible = false;
                return;
            }
            dgvNhanVien.DataSource = dbNhanVien.getNhanVienChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim());
            dgvNhanVien.Columns[10].Visible = false;
            dgvNhanVien.Columns[11].Visible = false;
        }
    }
}
