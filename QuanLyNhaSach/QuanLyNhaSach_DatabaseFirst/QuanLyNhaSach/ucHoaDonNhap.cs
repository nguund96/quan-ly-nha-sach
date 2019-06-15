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
        //Xử lý sự kiện click vào button btnThemNhaCC
        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            (new frmNhaCC()).ShowDialog();
            List<NhaCC> List = dbHoaDonNhap.getNhaCC();

            cmbNhaCC.DataSource = List;
            cmbNhaCC.DisplayMember = "TenNCC";
            cmbNhaCC.ValueMember = "MaNCC";
            LoadData_HoaDonNhap();
        }
        //Xử lý chỉ cho nhập số vào ô txtSoLuong
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
        //Xử lý chỉ cho nhập số vào ô txtGiaNhap
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

        //Load thông tin của dòng đang chọn hiện tại trên dgvHoaDonNhap lên txtMaHDN, cmbNhaCC và dtpNgayLapHDN
        private void Load_Info_SelectedRow_HoaDonNhap()
        {
            if (dgvHoaDonNhap.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvHoaDonNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonNhap.Rows.Count) return;

            txtMaHDN.Text = dgvHoaDonNhap.Rows[r].Cells[0].Value.ToString();
            cmbNhaCC.SelectedValue = dgvHoaDonNhap.Rows[r].Cells[1].Value.ToString();
            dtpNgayLapHDN.Value = DateTime.Parse(dgvHoaDonNhap.Rows[r].Cells[3].Value.ToString());
        }
        //Load dữ liệu lên dgvHoaDonNhap
        private void LoadData_HoaDonNhap()
        {
            List<NhaCC> ds1 = dbHoaDonNhap.getNhaCC();
            NhaCC.DataSource = ds1;
            NhaCC.DisplayMember = "TenNCC";
            NhaCC.ValueMember = "MaNCC";

            List<HoaDonNhap> ds = dbHoaDonNhap.getHoaDonNhap();
            dgvHoaDonNhap.DataSource = ds;
            dgvHoaDonNhap.Columns[4].Visible = false;
            dgvHoaDonNhap.Columns[5].Visible = false;
            dgvHoaDonNhap.Columns[6].Visible = false;

            Load_Info_SelectedRow_HoaDonNhap();
        }
        //Load thông tin của dòng đang chọn hiện tại trên dgvChiTietHDN lên txtMaSach, txtSoLuong và txtGiaNhap
        private void Load_Info_SelectedRow_ChiTietHoaDonNhap()
        {
            if (dgvChiTietHDN.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvChiTietHDN.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDN.Rows.Count) return;

            txtMaSach.Text = dgvChiTietHDN.Rows[r].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietHDN.Rows[r].Cells[2].Value.ToString();
            txtGiaNhap.Text = dgvChiTietHDN.Rows[r].Cells[3].Value.ToString();
        }
        //Load dữ liệu lên dgvChiTietHDN
        private void LoadData_ChiTietHoaDonNhap()
        {
            List<ChiTietHoaDonNhap> ds = dbHoaDonNhap.getChiTietHoaDonNhapTheoMaHDN(getMaHDNDangChon());
            dgvChiTietHDN.DataSource = ds;
            dgvChiTietHDN.Columns[4].Visible = false;

            Load_Info_SelectedRow_ChiTietHoaDonNhap();
        }
        //Lấy ra mã hóa đơn nhập của dòng đang chọn trên dgvHoaDonNhap
        private string getMaHDNDangChon()
        {
            if (dgvHoaDonNhap.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvHoaDonNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonNhap.Rows.Count) return "";
            return dgvHoaDonNhap.Rows[r].Cells[0].Value.ToString();
        }
        //Lấy ra mã sách của dòng đang chọn trên dgvChiTietHDN
        private string getMaSachDangChon()
        {
            if (dgvChiTietHDN.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvChiTietHDN.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDN.Rows.Count) return "";
            return dgvChiTietHDN.Rows[r].Cells[1].Value.ToString();
        }

        //Sự kiện click vào 1 dòng trên dgvHoaDonNhap
        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow_HoaDonNhap();

            LoadData_ChiTietHoaDonNhap();
        }
        //Sự kiện click vào 1 dòng trên dgvChiTietHDN
        private void dgvChiTietHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow_ChiTietHoaDonNhap();
        }
        //Load
        private void ucHoaDonNhap_Load(object sender, EventArgs e)
        {
            List<NhaCC> ds = dbHoaDonNhap.getNhaCC();

            cmbNhaCC.DataSource = ds;
            cmbNhaCC.DisplayMember = "TenNCC";
            cmbNhaCC.ValueMember = "MaNCC";

            LoadData_HoaDonNhap();
            LoadData_ChiTietHoaDonNhap();
        }
        //Xử lý tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim() == "")
            {
                LoadData_HoaDonNhap();
                LoadData_ChiTietHoaDonNhap();
                return;
            }
            List<HoaDonNhap> ds1 = dbHoaDonNhap.getHoaDonNhapTheoChuoiTimKiem(txtTimKiem.Text.Trim());
            dgvHoaDonNhap.DataSource = ds1;

            dgvHoaDonNhap.Columns[4].Visible = false;
            dgvHoaDonNhap.Columns[5].Visible = false;
            dgvHoaDonNhap.Columns[6].Visible = false;

            LoadData_ChiTietHoaDonNhap();
        }

        //Xử lý hóa đơn nhập
        private void btnThemHoaDonNhapMoi_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Enabled)//Nếu txtMaHDN.Enabled == true thì khi click vào button thêm thì thực hiện thêm mới vào CSDL
            {
                string err = "";
                bool KQ = dbHoaDonNhap.ThemHoaDonNhap(ref err, txtMaHDN.Text.ToUpper().Trim(), cmbNhaCC.SelectedValue.ToString(), frmMain.MaNVDangDangNhap, dtpNgayLapHDN.Value);
                if (!KQ)
                {
                    MessageBox.Show("Mã hóa đơn nhập đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData_HoaDonNhap();
                LoadData_ChiTietHoaDonNhap();

                txtMaHDN.Enabled = false;
                btnXoaHoaDonNhap.Enabled = true;
                btnCapNhatHoaDonNhap.Enabled = true;
                btnHuy.Enabled = false;
            }
            else//Nếu txtMaHDN.Enabled == false thì khi click vào button thêm thì mở ô txtMaHDN để nhập thông tin hóa đơn nhập mới
            {
                txtMaHDN.Clear();
                dtpNgayLapHDN.Value = DateTime.Now;

                txtMaHDN.Enabled = true;
                btnXoaHoaDonNhap.Enabled = false;
                btnCapNhatHoaDonNhap.Enabled = false;
                btnHuy.Enabled = true;

                txtMaHDN.Focus();
            }
        }
        //Nếu đã click vào button thêm lần thứ nhất mà k muốn thêm nữa
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHDN.Enabled = false;
            btnThemHoaDonNhapMoi.Enabled = true;
            btnXoaHoaDonNhap.Enabled = true;
            btnCapNhatHoaDonNhap.Enabled = true;
            btnHuy.Enabled = false;

            LoadData_HoaDonNhap();
            LoadData_ChiTietHoaDonNhap();
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
                LoadData_HoaDonNhap();
                LoadData_ChiTietHoaDonNhap();
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
            LoadData_HoaDonNhap();
            LoadData_ChiTietHoaDonNhap();
        }

        //Xử lý chi tiết hóa đơn nhập
        private void btnThemMoiChiTietHDN_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Enabled)
            {
                string err = "";
                bool KQ = dbHoaDonNhap.ThemChiTietHoaDonNhap(ref err, getMaHDNDangChon(), txtMaSach.Text.ToUpper().Trim(), Convert.ToInt32(txtSoLuong.Text), (float)Convert.ToDouble(txtGiaNhap.Text));
                if (!KQ)
                {
                    MessageBox.Show("Lỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData_ChiTietHoaDonNhap();

                txtMaSach.Enabled = false;
                btnXoaChiTietHDN.Enabled = true;
                btnCapNhatChiTietHDN.Enabled = true;
                btnHuy.Enabled = false;
            }
            else
            {
                txtMaSach.Clear();
                txtSoLuong.Clear();
                txtGiaNhap.Clear();

                txtMaSach.Enabled = true;
                btnXoaChiTietHDN.Enabled = false;
                btnCapNhatChiTietHDN.Enabled = false;
                btnHuyCT.Enabled = true;

                txtMaSach.Focus();
            }
            
        }
        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            btnThemMoiChiTietHDN.Enabled = true;
            btnXoaChiTietHDN.Enabled = true;
            btnCapNhatChiTietHDN.Enabled = true;
            btnHuyCT.Enabled = false;

            LoadData_ChiTietHoaDonNhap();
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
            LoadData_ChiTietHoaDonNhap();
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
            LoadData_ChiTietHoaDonNhap();
        }

        //In hóa đơn (Sự kiện doubleclick vào 1 dòng trên dgvHoaDonNhap)
        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHDN = getMaHDNDangChon();
            QLNSEntities db = new QLNSEntities();

            VW_HoaDonNhap ct = (from c in db.VW_HoaDonNhap
                                   where c.MaHDN == MaHDN
                                   select c).First();
            (new frmInHoaDon(MaHDN, ct.HoTenNV, ct.TenNCC, ct.NgayLap.Value, (float)ct.TongChi)).ShowDialog();
        }
    }
}
