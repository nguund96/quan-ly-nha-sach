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
        //Load thông tin của dòng đang được chọn trên dgvTheLoai lên các controls
        private void Load_Info_SelectedRow()
        {
            if (dgvTheLoai.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvTheLoai.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvTheLoai.Rows.Count) return;

            txtMaTL.Text = dgvTheLoai.Rows[r].Cells[0].Value.ToString();
            txtTenTL.Text = dgvTheLoai.Rows[r].Cells[1].Value.ToString();
            if (dgvTheLoai.Rows[r].Cells[2].Value.ToString() == "True")
            {
                rdbConKinhDoanh.Checked = true;
            }
            else rdbNgungKinhDoanh.Checked = true;
        }
        //Load dữ liệu vào dgvTheLoai
        private void LoadData_TheLoai()
        {
            List<TheLoai> ds = dbTheLoai.getTheLoai();
            dgvTheLoai.DataSource = ds;
            dgvTheLoai.Columns[3].Visible = false;
            Load_Info_SelectedRow();
        }
        //FormLoad
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadData_TheLoai();
        }
        //Sự kiện khi click vào 1 dòng trên dgvTheLoai thì thông tin của dòng đó sẽ đc load lên các controls
        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow();
        }
        //Lấy ra mã thể loại của dòng đang chọn trên dgvTheLoai
        private string getMaTLDangChon()
        {
            if (dgvTheLoai.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvTheLoai.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvTheLoai.Rows.Count) return "";

            return dgvTheLoai.Rows[r].Cells[0].Value.ToString();
        }

        //Xử lý thêm - Cập nhật thể loại
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaTL.Enabled)
            {
                string err = "";
                bool KQ = dbTheLoai.ThemTheLoai(ref err, txtMaTL.Text.ToUpper().Trim(), txtTenTL.Text.Trim(), rdbConKinhDoanh.Checked ? 1 : 0);
                if (!KQ)
                {
                    MessageBox.Show("Mã thể loại đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData_TheLoai();

                txtMaTL.Enabled = false;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
            }
            else
            {
                txtMaTL.Clear();
                txtTenTL.Clear();
                rdbConKinhDoanh.Checked = true;

                txtMaTL.Enabled = true;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;

                txtMaTL.Focus();
            }            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTL.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;

            LoadData_TheLoai();
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
            LoadData_TheLoai();
        }        
    }
}
