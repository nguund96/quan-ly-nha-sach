using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessAcessLayer;

namespace QuanLyNhaSach
{
    public partial class ucHoaDonBan : UserControl
    {
        public ucHoaDonBan()
        {
            InitializeComponent();
        }
        DBHoaDonBan dbHoaDonBan = new DBHoaDonBan();

        //Nếu mã sách đúng thì hiện tên sách vào txtTenSach và giá bán vào txtGiaBan
        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            List<Sach> List = dbHoaDonBan.getThongTinSach(txtMaSach.Text.Trim().ToUpper());
            if(List.Count <= 0)
            {
                txtTenSach.Text = "";
                txtGiaBan.Text = "0";
            }
            else
            {
                txtTenSach.Text = List[0].TenSach.ToString();
                txtGiaBan.Text = List[0].GiaBan.ToString();
            }
        }
        //Xử lý chỉ cho nhập số vào ô txtSoLuong
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "") txtSoLuong.Text = "0";
            try
            {
                int x = Convert.ToInt32(txtSoLuong.Text.Trim());
            }
            catch(FormatException)
            {
                txtSoLuong.Text = "0";
            }
        }

        //Load thông tin dòng đang chọn hiện tại trên dgvHoaDonBan lên textbox và datetimepicker
        private void LoadInfoRowSelected_HoaDonBan()
        {
            if (dgvHoaDonBan.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvHoaDonBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonBan.Rows.Count) return;

            txtMaHDB.Text = dgvHoaDonBan.Rows[r].Cells[0].Value.ToString();
            txtHoTenKH.Text = dgvHoaDonBan.Rows[r].Cells[2].Value.ToString();
            dtpNgayLapHDB.Value = DateTime.Parse(dgvHoaDonBan.Rows[r].Cells[3].Value.ToString());
        }
        //Load thông tin dòng đang chọn hiện tại trên dgvChiTietHDB lên textbox
        private void LoadInfoRowSelected_ChiTietHDBan()
        {
            if (dgvChiTietHDB.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvChiTietHDB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDB.Rows.Count) return;

            txtMaSach.Text = dgvChiTietHDB.Rows[r].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietHDB.Rows[r].Cells[2].Value.ToString();
        }
        //Load dữ liệu vào datagridview dgvHoaDonBan
        private void LoadData_HoaDonBan()
        {
            List<HoaDonBan> List = dbHoaDonBan.getHoaDonBan();
            dgvHoaDonBan.DataSource = List;
            dgvHoaDonBan.Columns[4].Visible = false;
            dgvHoaDonBan.Columns[5].Visible = false;

            LoadInfoRowSelected_HoaDonBan();
        }
        //Load dữ liệu vào datagridview dgvChiTietHDB
        private void LoadData_ChiTietHoaDonBan()
        {
            string MaHDB = Get_MaHDBDangChon();
            List<ChiTietHDBan> List = dbHoaDonBan.getChiTietHoaDonBanTheoMaHDB(MaHDB);
            dgvChiTietHDB.DataSource = List;
            dgvChiTietHDB.Columns[3].Visible = false;
            dgvChiTietHDB.Columns[4].Visible = false;

            LoadInfoRowSelected_ChiTietHDBan();
        }

        //Lấy ra mã hóa đơn bán của dòng đang chọn trên datagridview dgvHoaDonBan
        private string Get_MaHDBDangChon()
        {
            if (dgvHoaDonBan.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvHoaDonBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonBan.Rows.Count) return "";
            return dgvHoaDonBan.Rows[r].Cells[0].Value.ToString();
        }
        //Lấy ra mã sách của dòng đang chọn trên datagridview dgvChiTietHDB
        private string Get_MaSachDangChon()
        {
            if (dgvChiTietHDB.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvChiTietHDB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDB.Rows.Count) return "";
            return dgvChiTietHDB.Rows[r].Cells[1].Value.ToString();
        }
        //Sự kiện khi click vào 1 dòng trên datagridview dgvHoaDonBan
        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadInfoRowSelected_HoaDonBan();
            LoadData_ChiTietHoaDonBan();

            //Nếu không có chi tiết hóa đơn nào thì cập nhật lại txtMaSach và txtSoLuong
            if(dgvChiTietHDB.Rows.Count == 0)
            {
                txtMaSach.Clear();
                txtSoLuong.Text = "0";
            }
        }
        //Sự kiện khi click vào 1 dòng trên datagridview dgvChiTietHDB
        private void dgvChiTietHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadInfoRowSelected_ChiTietHDBan();
        }
        //Load
        private void ucHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadData_HoaDonBan();
            LoadData_ChiTietHoaDonBan();
        }

        //Xử lý hóa đơn bán
        private void btnThemHoaDonBanMoi_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Enabled)//Nếu txtMaHDB.Enabled == true thì khi click vào button thêm thì thực hiện thêm mới vào CSDL
            {
                string err = "";
                bool KQ = dbHoaDonBan.ThemHoaDonBan(ref err, txtMaHDB.Text.Trim().ToUpper(), frmMain.MaNVDangDangNhap, txtHoTenKH.Text.Trim(), dtpNgayLapHDB.Value);
                if (!KQ)
                {
                    MessageBox.Show("Mã hóa đơn bán đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData_HoaDonBan();
                LoadData_ChiTietHoaDonBan();

                btnXoaHoaDonBan.Enabled = true;
                btnCapNhatHoaDonBan.Enabled = true;
                btnHuy.Enabled = false;

                txtMaHDB.Enabled = false;
            }
            else//Nếu txtMaHDB.Enabled == false thì khi click vào button thêm thì mở ô txtMaHDB để nhập thông tin hóa đơn bán mới
            {
                txtMaHDB.Clear();
                txtHoTenKH.Clear();
                dtpNgayLapHDB.Value = DateTime.Now;

                btnXoaHoaDonBan.Enabled = false;
                btnCapNhatHoaDonBan.Enabled = false;
                btnHuy.Enabled = true;

                txtMaHDB.Enabled = true;
                txtMaHDB.Focus();
            }
        }
        //Nếu đã click vào button thêm lần thứ nhất mà k muốn thêm nữa
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHDB.Enabled = false;

            btnThemHoaDonBanMoi.Enabled = true;
            btnXoaHoaDonBan.Enabled = true;
            btnCapNhatHoaDonBan.Enabled = true;
            btnHuy.Enabled = false;

            LoadData_HoaDonBan();
            LoadData_ChiTietHoaDonBan();
        }
        private void btnXoaHoaDonBan_Click(object sender, EventArgs e)
        {
            string MaHDB = Get_MaHDBDangChon();
            DataGridView dgv = dgvChiTietHDB;
            
            DialogResult dr = MessageBox.Show("Nếu xóa hóa đơn này thì mọi chi tiết hóa đơn liên quan đều sẽ bị xóa, bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                string err = "";
                bool KQ = dbHoaDonBan.XoaHoaDonBan(ref err, MaHDB);
                if (!KQ)
                {
                    MessageBox.Show("Lỗi đây: " + err, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Cập nhật lại số lượng sách, do là xóa nên tham số SoLuongThem truyền vào CapNhatLaiSoLuongSachTon sẽ là số dương
                if (dgv.Rows.Count > 1)
                {
                    for(int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, dgv.Rows[i].Cells["MaSach"].Value.ToString(), Convert.ToInt32(dgv.Rows[i].Cells["SoLuong"].Value.ToString()));
                    }
                }
                LoadData_HoaDonBan();
                LoadData_ChiTietHoaDonBan();
            }
        }
        private void btnCapNhatHoaDonBan_Click(object sender, EventArgs e)
        {
            string MaHDB = Get_MaHDBDangChon();
            string err = "";
            bool KQ = dbHoaDonBan.CapNhatHoaDonBan(ref err, MaHDB, frmMain.MaNVDangDangNhap, txtHoTenKH.Text.Trim(), dtpNgayLapHDB.Value);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData_HoaDonBan();
            LoadData_ChiTietHoaDonBan();
        }

        //Xử lý chi tiết hóa đơn bán
        private void btnThemMoiChiTietHDB_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Enabled)
            {
                string MaHDB = Get_MaHDBDangChon();
                string err = "";
                bool KQ = dbHoaDonBan.ThemChiTietHoaDonBan(ref err, MaHDB, txtMaSach.Text.Trim().ToUpper(), Convert.ToInt32(txtSoLuong.Text));
                if (!KQ)
                {
                    MessageBox.Show("Mã sách không tồn tại, vui lòng kiểm tra lại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Cập nhật lại số lượng sách tồn
                dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, txtMaSach.Text.Trim(), Convert.ToInt32(txtSoLuong.Text) * (-1));
                LoadData_ChiTietHoaDonBan();

                txtMaSach.Enabled = false;
                btnXoaChiTietHDB.Enabled = true;
                btnCapNhatChiTietHDB.Enabled = true;
                btnHuyCT.Enabled = false;
            }
            else
            {
                txtMaSach.Clear();
                txtSoLuong.Clear();

                txtMaSach.Enabled = true;
                btnXoaChiTietHDB.Enabled = false;
                btnCapNhatChiTietHDB.Enabled = false;
                btnHuyCT.Enabled = true;

                txtMaSach.Focus();
            }
        }
        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            btnThemMoiChiTietHDB.Enabled = true;
            btnXoaChiTietHDB.Enabled = true;
            btnCapNhatChiTietHDB.Enabled = true;
            btnHuyCT.Enabled = false;

            LoadData_ChiTietHoaDonBan();
        }
        private void btnXoaChiTietHDB_Click(object sender, EventArgs e)
        {
            string MaHDB = Get_MaHDBDangChon();
            string MaSach = Get_MaSachDangChon();
            int SoLuongSach_Cu = Get_SoLuongSachCu();

            string err = "";
            bool KQ = dbHoaDonBan.XoaChiTietHoaDonBan(ref err, MaHDB, MaSach);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Cập nhật lại số lượng sách tồn
            dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, MaSach, SoLuongSach_Cu);
            LoadData_ChiTietHoaDonBan();
        }
        private void btnCapNhatChiTietHDB_Click(object sender, EventArgs e)
        {
            string MaHDB = Get_MaHDBDangChon();
            string MaSach = Get_MaSachDangChon();
            int SoLuongSach_Cu = Get_SoLuongSachCu();
            int SoLuongSach_Moi = Convert.ToInt32(txtSoLuong.Text);

            string err = "";
            bool KQ = dbHoaDonBan.CapNhatChiTietHoaDonBan(ref err, MaHDB, MaSach, Convert.ToInt32(txtSoLuong.Text));
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Cập nhật lại số lượng sách tồn
            dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, MaSach, SoLuongSach_Cu - SoLuongSach_Moi);
            LoadData_ChiTietHoaDonBan();
        }

        //Xử lý tìn kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvHoaDonBan.DataSource = dbHoaDonBan.getHoaDonBan();
                dgvHoaDonBan.Columns[4].Visible = false;
                dgvHoaDonBan.Columns[5].Visible = false;
                LoadData_ChiTietHoaDonBan();
                return;
            }
            dgvHoaDonBan.DataSource = dbHoaDonBan.getHoaDonBanTheoChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim());
            dgvHoaDonBan.Columns[4].Visible = false;
            dgvHoaDonBan.Columns[5].Visible = false;
            LoadData_ChiTietHoaDonBan();
        }

        //Xử lý lấy số lượng sách của dòng đang chọn trên datagridview dgvChiTietHDB
        private int Get_SoLuongSachCu()
        {
            if (dgvChiTietHDB.Rows.Count <= 1)
            {
                return 0;
            }
            int r = dgvChiTietHDB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDB.Rows.Count - 1) return 0;
            return Convert.ToInt32(dgvChiTietHDB.Rows[r].Cells[2].Value.ToString());
        }

        //In hóa đơn (Sự kiện doubleclick vào một dòng trên dgvHoaDonBan)
        private void dgvHoaDonBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHDB = "", HoTenKH = "", HoTenNV = "";
            DateTime NgayLapHD = DateTime.Now;
            DBNhanVien dbNhanVien = new DBNhanVien();

            if (dgvHoaDonBan.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvHoaDonBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonBan.Rows.Count) return;

            MaHDB = dgvHoaDonBan.Rows[r].Cells[0].Value.ToString();
            List<NhanVien> List = dbNhanVien.getNhanVienChuoiTimKiem(dgvHoaDonBan.Rows[r].Cells[1].Value.ToString());
            HoTenNV = List[0].HoNV + " " + List[0].TenNV;
            HoTenKH = dgvHoaDonBan.Rows[r].Cells[2].Value.ToString();
            NgayLapHD = Convert.ToDateTime(dgvHoaDonBan.Rows[r].Cells[3].Value.ToString());

            (new frmInHoaDon(MaHDB, HoTenKH, HoTenNV, NgayLapHD)).ShowDialog();
        }
    }
}
