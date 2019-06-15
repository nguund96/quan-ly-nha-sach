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

        private void LoadNhanVien()
        {
            DataSet ds = dbNhanVien.getNhanVien();
            dgvNhanVien.DataSource = ds.Tables[0];
        }
        private void Load_Info_RowSelected()
        {
            if (dgvNhanVien.Rows.Count <= 1)
            {
                return;
            }

            int r = dgvNhanVien.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhanVien.Rows.Count - 1) return;
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
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            Load_Info_RowSelected();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_RowSelected();
        }
        private string Get_IDEmployee()
        {
            if (dgvNhanVien.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvNhanVien.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvNhanVien.Rows.Count - 1) return "";
            return dgvNhanVien.Rows[r].Cells[0].Value.ToString();
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
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

            LoadNhanVien();
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

            LoadNhanVien();
        }
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
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvNhanVien.DataSource = dbNhanVien.getNhanVien().Tables[0];
                LoadNhanVien();
                return;
            }
            dgvNhanVien.DataSource = dbNhanVien.getNhanVienChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim()).Tables[0];
            LoadNhanVien();
        }

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
