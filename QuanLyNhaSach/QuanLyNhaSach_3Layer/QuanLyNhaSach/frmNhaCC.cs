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
    public partial class frmNhaCC : Form
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }
        DBNhaCC dbNhaCC = new DBNhaCC();

        private void Load_Info_RowSelected()
        {
            if (dgvNhaCC.Rows.Count <= 1)
            {
                return;
            }
            int r = dgvNhaCC.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhaCC.Rows.Count - 1) return;
            txtMaNhaCC.Text = dgvNhaCC.Rows[r].Cells[0].Value.ToString();
            txtTenNhaCC.Text = dgvNhaCC.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhaCC.Rows[r].Cells[3].Value.ToString();
            
            if (dgvNhaCC.Rows[r].Cells[4].Value.ToString() == "False")
            {
                rdbNgungCungCap.Checked = true;
            }
            else rdbConCungCap.Checked = true;
        }
        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_RowSelected();
        }
        private void DataBind()
        {
            DataSet ds = dbNhaCC.getNhaCC();
            dgvNhaCC.DataSource = ds.Tables[0];
            Load_Info_RowSelected();
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbNhaCC.ThemNhaCC(ref err, txtMaNhaCC.Text.Trim(), txtTenNhaCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), rdbConCungCap.Checked ? 1 : 0);
            if(!KQ)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MaNhaCCDangChon = "";
            if (dgvNhaCC.Rows.Count <= 1)
            {
                return;
            }
            int r = dgvNhaCC.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhaCC.Rows.Count - 1) return;
            MaNhaCCDangChon = dgvNhaCC.Rows[r].Cells[0].Value.ToString();

            string err = "";
            bool KQ = dbNhaCC.CapNhatNhaCC(ref err, MaNhaCCDangChon, txtTenNhaCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), rdbConCungCap.Checked ? 1 : 0);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
