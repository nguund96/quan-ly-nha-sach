using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAcessLayer;

namespace QuanLyNhaSach
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        DBNhanVien dbNhanVien = new DBNhanVien();

        //Load dữ liệu lên dgvNhanVien
        private void LoadData_NhanVien()
        {
            List<NhanVien> ds = dbNhanVien.getNhanVien();
            dgvNhanVien.DataSource = ds;
            dgvNhanVien.Columns[10].Visible = false;
            dgvNhanVien.Columns[11].Visible = false;

            Load_Info_RowSelected();
        }
        //Load thông tin của dòng đang chọn hiện tại trên dgvNhanVien lên các controls
        private void Load_Info_RowSelected()
        {
            if (dgvNhanVien.Rows.Count <= 0)
            {
                return;
            }

            int r = dgvNhanVien.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhanVien.Rows.Count) return;
            txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtHoNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();

            if (dgvNhanVien.Rows[r].Cells[4].Value.ToString() == "True")
            {
                rdbNu.Checked = true;
            }
            else
            {
                rdbNam.Checked = true;
            }

            dtpNgayNhanViec.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            txtSoDT.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[r].Cells[8].Value.ToString();


            if (dgvNhanVien.Rows[r].Cells[9].Value.ToString() == "True")
            {
                rdbCon.Checked = true;
            }
            else
            {
                rdbNgung.Checked = true;
            }

            if (dbNhanVien.getQuyenNhanVienTheoMaNV(dgvNhanVien.Rows[r].Cells[0].Value.ToString()) == 1)
            {
                rdbQuanLy.Checked = true;
            }
            else rdbNhanVien.Checked = true;
        }
        //Load
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            LoadData_NhanVien();
            Load_Info_RowSelected();
        }
        //Sự kiện khi cick vào 1 dòng trên dgvNhanVien
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_RowSelected();
        }
        //Lấy mã nhân viên của dòng đang chọn trên dgvNhanVien
        private string Get_IDEmployee()
        {
            if (dgvNhanVien.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvNhanVien.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhanVien.Rows.Count) return "";
            return dgvNhanVien.Rows[r].Cells[0].Value.ToString();
        }
        
        //Xử lý thêm - cập nhật nhân viên
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Enabled)
            {
                string err = "";
                bool KQ = dbNhanVien.ThemNhanVien(ref err, txtMaNV.Text.Trim().ToUpper(), txtHoNV.Text.Trim(), txtTenNV.Text.Trim(), dtpNgaySinh.Value,
                    rdbNu.Checked ? 1 : 0, dtpNgayNhanViec.Value, txtDiaChi.Text, txtSoDT.Text, float.Parse(txtLuong.Text), rdbCon.Checked ? 1 : 0);
                if (!KQ)
                {
                    MessageBox.Show("Mã Nhân Viên đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Thêm tài khoản đăng nhập
                dbNhanVien.ThemTaiKhoan(ref err, txtMaNV.Text.ToUpper().Trim(), txtMaNV.Text.ToUpper().Trim(), rdbQuanLy.Checked ? 1 : 0);

                LoadData_NhanVien();

                txtMaNV.Enabled = false;
                btnCapNhatNhanVien.Enabled = true;
                btnCapNhatTK.Enabled = true;
                btnHuy.Enabled = false;
            }
            else
            {
                txtMaNV.Clear();
                txtHoNV.Clear();
                txtTenNV.Clear();
                dtpNgayNhanViec.Value = DateTime.Now;
                dtpNgaySinh.Value = DateTime.Now;
                rdbNam.Checked = true;
                txtDiaChi.Clear();
                txtSoDT.Clear();
                txtLuong.Clear();
                rdbCon.Checked = true;
                rdbNhanVien.Checked = true;

                txtMaNV.Enabled = true;
                btnCapNhatNhanVien.Enabled = false;
                btnCapNhatTK.Enabled = false;
                btnHuy.Enabled = true;

                txtMaNV.Focus();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnThemNhanVien.Enabled = true;
            btnCapNhatNhanVien.Enabled = true;
            btnCapNhatTK.Enabled = true;
            btnHuy.Enabled = false;

            LoadData_NhanVien();
        }
        private void btnCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            string MaNV = Get_IDEmployee();
            string err = "";
            bool KQ = dbNhanVien.CapNhatNhanVien(ref err, MaNV, txtHoNV.Text.Trim(), txtTenNV.Text.Trim(), dtpNgaySinh.Value,
                rdbNu.Checked ? 1 : 0, dtpNgayNhanViec.Value, txtDiaChi.Text, txtSoDT.Text, float.Parse(txtLuong.Text), rdbCon.Checked ? 1 : 0);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Cập nhật lại quyền nhân viên
            dbNhanVien.CapNhatTaiKhoan(ref err, MaNV, dbNhanVien.getMatKhauNhanVienTheoMaNV(MaNV), rdbQuanLy.Checked ? 1 : 0);

            LoadData_NhanVien();
        }
        
        //Cập nhật lại tai khoản đăng nhập của nhân viên
        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            string MaNV = Get_IDEmployee();
            string err = "";
            bool KQ = dbNhanVien.CapNhatTaiKhoan(ref err, MaNV, MaNV, dbNhanVien.getQuyenNhanVienTheoMaNV(MaNV));
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Mật khẩu đã đặt mặc định lại là mã nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Xử lý tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvNhanVien.DataSource = dbNhanVien.getNhanVien();
                dgvNhanVien.Columns[10].Visible = false;
                dgvNhanVien.Columns[11].Visible = false;
                Load_Info_RowSelected();
                return;
            }
            dgvNhanVien.DataSource = dbNhanVien.getNhanVienChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim());
            dgvNhanVien.Columns[10].Visible = false;
            dgvNhanVien.Columns[11].Visible = false;
            Load_Info_RowSelected();
        }
        //Chỉ cho nhập số vào ô txtSoLuong
        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtLuong.Text) == 0)
                {
                    txtLuong.Text = "0";
                }
            }
            catch(FormatException)
            {
                txtLuong.Text = "0";
            }
        }
    }
}
