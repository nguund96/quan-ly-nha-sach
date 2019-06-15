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
    public partial class ucHoaDonNhap : UserControl
    {
        public ucHoaDonNhap()
        {
            InitializeComponent();
        }
        DBHoaDonNhap dbHoaDonNhap = new DBHoaDonNhap();

        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            (new frmNhaCC()).ShowDialog();
            DataSet ds = dbHoaDonNhap.getNhaCC();

            cmbNhaCC.DataSource = ds.Tables[0];
            cmbNhaCC.DisplayMember = "TenNCC";
            cmbNhaCC.ValueMember = "MaNCC";
            DataBind_HoaDonNhap();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtSoLuong.Text) == 0)
                {
                    txtSoLuong.Text = "0";
                }
            }
            catch (FormatException)
            {
                txtSoLuong.Text = "0";
            }
        }
        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtGiaNhap.Text) == 0)
                {
                    txtGiaNhap.Text = "0";
                }
            }
            catch (FormatException)
            {
                txtGiaNhap.Text = "0";
            }
        }

        private void Load_Info_SelectedRow_HoaDonNhap()
        {
            if (dgvHoaDonNhap.Rows.Count <= 1)
            {
                return;
            }
            int r = dgvHoaDonNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonNhap.Rows.Count - 1) return;

            txtMaHDN.Text = dgvHoaDonNhap.Rows[r].Cells[0].Value.ToString();
            cmbNhaCC.SelectedValue = dgvHoaDonNhap.Rows[r].Cells[1].Value.ToString();
            dtpNgayLapHDN.Value = DateTime.Parse(dgvHoaDonNhap.Rows[r].Cells[3].Value.ToString());
        }
        private void DataBind_HoaDonNhap()
        {
            DataSet ds1 = dbHoaDonNhap.getNhaCC();
            NhaCC.DataSource = ds1.Tables[0];
            NhaCC.DisplayMember = "TenNCC";
            NhaCC.ValueMember = "MaNCC";

            DataSet ds = dbHoaDonNhap.getHoaDonNhap();
            dgvHoaDonNhap.DataSource = ds.Tables[0];

            Load_Info_SelectedRow_HoaDonNhap();
        }

        private void Load_Info_SelectedRow_ChiTietHoaDonNhap()
        {
            if (dgvChiTietHDN.Rows.Count <= 1)
            {
                return;
            }
            int r = dgvChiTietHDN.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDN.Rows.Count - 1) return;

            txtMaSach.Text = dgvChiTietHDN.Rows[r].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietHDN.Rows[r].Cells[2].Value.ToString();
            txtGiaNhap.Text = dgvChiTietHDN.Rows[r].Cells[3].Value.ToString();
        }
        private void DataBind_ChiTietHoaDonNhap()
        {
            DataSet ds = dbHoaDonNhap.getChiTietHoaDonNhapTheoMaHDN(getMaHDNDangChon());
            dgvChiTietHDN.DataSource = ds.Tables[0];

            Load_Info_SelectedRow_ChiTietHoaDonNhap();
        }

        private string getMaHDNDangChon()
        {
            if (dgvHoaDonNhap.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvHoaDonNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonNhap.Rows.Count - 1) return "";
            return dgvHoaDonNhap.Rows[r].Cells[0].Value.ToString();
        }
        private string getMaSachDangChon()
        {
            if (dgvChiTietHDN.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvChiTietHDN.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDN.Rows.Count - 1) return "";
            return dgvChiTietHDN.Rows[r].Cells[1].Value.ToString();
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow_HoaDonNhap();

            DataBind_ChiTietHoaDonNhap();
        }
        private void dgvChiTietHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow_ChiTietHoaDonNhap();
        }

        private void ucHoaDonNhap_Load(object sender, EventArgs e)
        {
            DataSet ds = dbHoaDonNhap.getNhaCC();

            cmbNhaCC.DataSource = ds.Tables[0];
            cmbNhaCC.DisplayMember = "TenNCC";
            cmbNhaCC.ValueMember = "MaNCC";

            DataBind_HoaDonNhap();
            DataBind_ChiTietHoaDonNhap();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim() == "")
            {
                DataBind_HoaDonNhap();
                DataBind_ChiTietHoaDonNhap();
                return;
            }
            DataSet ds1 = dbHoaDonNhap.getHoaDonNhapTheoChuoiTimKiem(txtTimKiem.Text.Trim());
            dgvHoaDonNhap.DataSource = ds1.Tables[0];
            DataBind_ChiTietHoaDonNhap();
        }

        //Xử lý hóa đơn nhập
        private void btnThemHoaDonNhapMoi_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonNhap.ThemHoaDonNhap(ref err, txtMaHDN.Text.ToUpper().Trim(), cmbNhaCC.SelectedValue.ToString(), frmMain.MaNVDangDangNhap, dtpNgayLapHDN.Value);
            if(!KQ)
            {
                MessageBox.Show("Mã hóa đơn nhập đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind_HoaDonNhap();
            DataBind_ChiTietHoaDonNhap();
        }
        private void btnXoaHoaDonNhap_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Nếu xóa hóa đơn nhập này thì mọi chi tiết hóa đơn nhập liên quan đều sẽ bị xóa, bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string err = "";
                bool KQ = dbHoaDonNhap.XoaHoaDonNhap(ref err, getMaHDNDangChon());
                if (!KQ)
                {
                    MessageBox.Show("Lỗi đây: " + err, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataBind_HoaDonNhap();
                DataBind_ChiTietHoaDonNhap();
            }
        }
        private void btnCapNhatHoaDonNhap_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonNhap.CapNhatHoaDonNhap(ref err, getMaHDNDangChon(), cmbNhaCC.SelectedValue.ToString(), frmMain.MaNVDangDangNhap, dtpNgayLapHDN.Value);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind_HoaDonNhap();
            DataBind_ChiTietHoaDonNhap();
        }
        private void btnTriGiaHoaDon_Click(object sender, EventArgs e)
        {
            double TriGiaHoaDon = 0;
            int count = dgvChiTietHDN.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                TriGiaHoaDon += Convert.ToDouble(dgvChiTietHDN.Rows[i].Cells["GiaNhap"].Value.ToString()) * Convert.ToDouble(dgvChiTietHDN.Rows[i].Cells["SoLuong"].Value.ToString());
            }
            MessageBox.Show("Trị giá hóa đơn này là: " + TriGiaHoaDon.ToString() + " VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Xử lý chi tiết hóa đơn nhập
        private void btnThemMoiChiTietHDN_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonNhap.ThemChiTietHoaDonNhap(ref err, getMaHDNDangChon(), txtMaSach.Text.ToUpper().Trim(), Convert.ToInt32(txtSoLuong.Text), (float)Convert.ToDouble(txtGiaNhap.Text));
            if(!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind_ChiTietHoaDonNhap();
        }
        private void btnXoaChiTietHDN_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonNhap.XoaChiTietHoaDonNhap(ref err, getMaHDNDangChon(), getMaSachDangChon());
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind_ChiTietHoaDonNhap();
        }
        private void btnCapNhatChiTietHDN_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonNhap.CapNhatChiTietHoaDonNhap(ref err, getMaHDNDangChon(), getMaSachDangChon(), Convert.ToInt32(txtSoLuong.Text), (float)Convert.ToDouble(txtGiaNhap.Text));
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind_ChiTietHoaDonNhap();
        }
    }
}
