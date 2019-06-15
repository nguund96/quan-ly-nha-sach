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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }
        DBTheLoai dbTheLoai = new DBTheLoai();

        private void Load_Info_SelectedRow()
        {
            if (dgvTheLoai.Rows.Count <= 1)
            {
                return;
            }
            int r = dgvTheLoai.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvTheLoai.Rows.Count - 1) return;

            txtMaTL.Text = dgvTheLoai.Rows[r].Cells[0].Value.ToString();
            txtTenTL.Text = dgvTheLoai.Rows[r].Cells[1].Value.ToString();
            if (dgvTheLoai.Rows[r].Cells[2].Value.ToString() == "True")
            {
                rdbConKinhDoanh.Checked = true;
            }
            else rdbNgungKinhDoanh.Checked = true;
        }
        private void LoadTheLoai()
        {
            DataSet ds = dbTheLoai.getTheLoai();
            dgvTheLoai.DataSource = ds.Tables[0];
            Load_Info_SelectedRow();
        }
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
        }
        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow();
        }
        private string getMaTLDangChon()
        {
            if (dgvTheLoai.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvTheLoai.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvTheLoai.Rows.Count - 1) return "";

            return dgvTheLoai.Rows[r].Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbTheLoai.ThemTheLoai(ref err, txtMaTL.Text.ToUpper().Trim(), txtTenTL.Text.Trim(), rdbConKinhDoanh.Checked ? 1 : 0);
            if(!KQ)
            {
                MessageBox.Show("Mã thể loại đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadTheLoai();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbTheLoai.CapNhatTheLoai(ref err, getMaTLDangChon(), txtTenTL.Text.Trim(), rdbConKinhDoanh.Checked ? 1 : 0);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadTheLoai();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
