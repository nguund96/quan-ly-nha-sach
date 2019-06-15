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

        //Load thông tin của dòng đang được chọn trên dgvNhaCC lên các controls
        private void Load_Info_RowSelected()
        {
            if (dgvNhaCC.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvNhaCC.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhaCC.Rows.Count) return;
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
        //Sự kiện khi click vào 1 dòng trên dgvNhaCC thị thông tin của dòng đó sẽ đc load lên các controls
        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_RowSelected();
        }
        //Load dữ liệu lên dgvNhaCC
        private void LoadData()
        {
            List<NhaCC> ds = dbNhaCC.getNhaCC();
            dgvNhaCC.DataSource = ds;
            dgvNhaCC.Columns[5].Visible = false;
            Load_Info_RowSelected();
        }
        //FormLoad
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //Thêm - Cập nhật thông tin Nhà cung cấp
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtMaNhaCC.Enabled)
            {
                string err = "";
                bool KQ = dbNhaCC.ThemNhaCC(ref err, txtMaNhaCC.Text.Trim(), txtTenNhaCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), rdbConCungCap.Checked ? 1 : 0);
                if (!KQ)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData();

                txtMaNhaCC.Enabled = false;
                btnCapNhat.Enabled = true;
                btnHuy.Enabled = false;
            }
            else
            {
                txtMaNhaCC.Clear();
                txtTenNhaCC.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                rdbConCungCap.Checked = true;
                

                txtMaNhaCC.Enabled = true;
                btnCapNhat.Enabled = false;
                btnHuy.Enabled = true;

                txtMaNhaCC.Focus();
            }            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhaCC.Enabled = false;
            btnThemMoi.Enabled = true;
            btnCapNhat.Enabled = true;
            btnHuy.Enabled = false;

            LoadData();
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
            LoadData();
        }
    }
}
