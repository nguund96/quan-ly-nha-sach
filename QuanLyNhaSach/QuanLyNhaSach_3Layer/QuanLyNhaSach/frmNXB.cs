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
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
        }
        DBNXB dbNXB = new DBNXB();
        private void Load_Info_SelectedRow()
        {
            if (dgvNXB.Rows.Count <= 1)
            {
                return;
            }
            int r = dgvNXB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNXB.Rows.Count - 1) return;

            txtMaNXB.Text = dgvNXB.Rows[r].Cells[0].Value.ToString();
            txtTenNXB.Text = dgvNXB.Rows[r].Cells[1].Value.ToString();
            if (dgvNXB.Rows[r].Cells[2].Value.ToString() == "True")
            {
                rdbConKinhDoanh.Checked = true;
            }
            else rdbNgungKinhDoanh.Checked = true;
        }
        private void LoadNXB()
        {
            DataSet ds = dbNXB.getNXB();
            dgvNXB.DataSource = ds.Tables[0];
            Load_Info_SelectedRow();
        }
        private void frmNXB_Load(object sender, EventArgs e)
        {
            LoadNXB();
        }
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow();
        }
        private string getMaNXBDangChon()
        {
            if (dgvNXB.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvNXB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNXB.Rows.Count - 1) return "";

            return dgvNXB.Rows[r].Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbNXB.ThemNXB(ref err, txtMaNXB.Text.ToUpper().Trim(), txtTenNXB.Text.Trim(), rdbConKinhDoanh.Checked ? 1 : 0);
            if (!KQ)
            {
                MessageBox.Show("Mã NXB đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadNXB();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbNXB.CapNhatNXB(ref err, getMaNXBDangChon(), txtTenNXB.Text.Trim(), rdbConKinhDoanh.Checked ? 1 : 0);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadNXB();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
