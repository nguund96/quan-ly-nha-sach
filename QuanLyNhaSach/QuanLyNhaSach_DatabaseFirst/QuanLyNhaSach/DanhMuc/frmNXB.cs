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
        //Load thông tin của dòng đang được chọn trên dgvNXB lên các controls
        private void Load_Info_SelectedRow()
        {
            if (dgvNXB.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvNXB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNXB.Rows.Count) return;

            txtMaNXB.Text = dgvNXB.Rows[r].Cells[0].Value.ToString();
            txtTenNXB.Text = dgvNXB.Rows[r].Cells[1].Value.ToString();
            if (dgvNXB.Rows[r].Cells[2].Value.ToString() == "True")
            {
                rdbConKinhDoanh.Checked = true;
            }
            else rdbNgungKinhDoanh.Checked = true;
        }
        //Load dữ liệu lên dgvNXB
        private void LoadNXB()
        {
            List<NXB> ds = dbNXB.getNXB();
            dgvNXB.DataSource = ds;
            dgvNXB.Columns[3].Visible = false;
            Load_Info_SelectedRow();
        }
        //FormLoad
        private void frmNXB_Load(object sender, EventArgs e)
        {
            LoadNXB();
        }
        //Sự kiện khi click vào 1 dòng trên dgvNXB thị thông tin của dòng đó sẽ đc load lên các controls
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow();
        }
        //Lấy ra mã nhà xuất bản của dòng đang chọn hiện tại trên dgvNXB
        private string getMaNXBDangChon()
        {
            if (dgvNXB.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvNXB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNXB.Rows.Count) return "";

            return dgvNXB.Rows[r].Cells[0].Value.ToString();
        }

        //Thêm - Sửa thông tin NXB
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaNXB.Enabled)
            {
                string err = "";
                bool KQ = dbNXB.ThemNXB(ref err, txtMaNXB.Text.ToUpper().Trim(), txtTenNXB.Text.Trim(), rdbConKinhDoanh.Checked ? 1 : 0);
                if (!KQ)
                {
                    MessageBox.Show("Mã NXB đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadNXB();

                txtMaNXB.Enabled = false;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
            }
            else
            {
                txtMaNXB.Clear();
                txtTenNXB.Clear();
                rdbConKinhDoanh.Checked = true;                

                txtMaNXB.Enabled = true;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;

                txtMaNXB.Focus();
            }            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNXB.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;

            Load_Info_SelectedRow();
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
    }
}
