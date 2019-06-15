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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        DBSach dbSach = new DBSach();
        DBTheLoai dbTheLoai = new DBTheLoai();
        DBNXB dbNXB = new DBNXB();
        //FormLoad
        private void frmSach_Load(object sender, EventArgs e)
        {
            List<TheLoai> dsTheLoai = dbTheLoai.getTheLoai();
            TheLoai.DataSource = dsTheLoai;
            TheLoai.DisplayMember = "TenTheLoai";
            TheLoai.ValueMember = "MaTheLoai";

            List<NXB> dsNXB = dbNXB.getNXB();
            NXB.DataSource = dsNXB;
            NXB.DisplayMember = "TenNXB";
            NXB.ValueMember = "MaNXB";

            List<Sach> dsSach = dbSach.getSach();
            dgvSach.DataSource = dsSach;

            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns[9].Visible = false;
            dgvSach.Columns[10].Visible = false;

            txtTimKiem.Focus();
        }
        //Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Xử lý tìm kiếm sách
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvSach.DataSource = dbSach.getSach();
                dgvSach.Columns[7].Visible = false;
                dgvSach.Columns[8].Visible = false;
                dgvSach.Columns[9].Visible = false;
                dgvSach.Columns[10].Visible = false;
                return;
            }
            dgvSach.DataSource = dbSach.getSachTheoChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim());
            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns[9].Visible = false;
            dgvSach.Columns[10].Visible = false;
        }
    }
}
