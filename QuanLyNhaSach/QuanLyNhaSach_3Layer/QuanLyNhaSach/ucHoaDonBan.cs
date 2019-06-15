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
        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = dbHoaDonBan.getThongTinSach(txtMaSach.Text.Trim().ToUpper());
            if(ds.Tables[0].Rows.Count <= 0)
            {
                txtTenSach.Text = "";
                txtGiaBan.Text = "0";
            }
            else
            {
                txtTenSach.Text = ds.Tables[0].Rows[0]["TenSach"].ToString();
                txtGiaBan.Text = ds.Tables[0].Rows[0]["GiaBan"].ToString();
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "") txtSoLuong.Text = "0";
        }

        private void DataBind_HoaDonBan()
        {
            DataSet ds = dbHoaDonBan.getHoaDonBan();
            dgvHoaDonBan.DataSource = ds.Tables[0];

            txtMaHDB.DataBindings.Clear();
            txtHoTenKH.DataBindings.Clear();
            dtpNgayLapHDB.DataBindings.Clear();

            txtMaHDB.DataBindings.Add("Text", ds.Tables[0], "MaHDB", true, DataSourceUpdateMode.Never);
            txtHoTenKH.DataBindings.Add("Text", ds.Tables[0], "HoTenKH", true, DataSourceUpdateMode.Never);
            dtpNgayLapHDB.DataBindings.Add("Value", ds.Tables[0], "NgayLapHD", true, DataSourceUpdateMode.Never);
        }
        private void DataBind_ChiTietHoaDonBan()
        {
            string MaHDB = Get_MaHDBDangChon();
            DataSet ds = dbHoaDonBan.getChiTietHoaDonBanTheoMaHDB(MaHDB);
            dgvChiTietHDB.DataSource = ds.Tables[0];

            txtMaSach.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();

            txtMaSach.DataBindings.Add("Text", ds.Tables[0], "MaSach", true, DataSourceUpdateMode.Never);
            txtSoLuong.DataBindings.Add("Text", ds.Tables[0], "SoLuong", true, DataSourceUpdateMode.Never);
        }

        private string Get_MaHDBDangChon()
        {
            if (dgvHoaDonBan.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvHoaDonBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonBan.Rows.Count - 1) return "";
            return dgvHoaDonBan.Rows[r].Cells[0].Value.ToString();
        }
        private string Get_MaSachDangChon()
        {
            if (dgvChiTietHDB.Rows.Count <= 1)
            {
                return "";
            }
            int r = dgvChiTietHDB.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDB.Rows.Count - 1) return "";
            return dgvChiTietHDB.Rows[r].Cells[1].Value.ToString();
        }
        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBind_ChiTietHoaDonBan();

            if(dgvChiTietHDB.Rows.Count == 1)
            {
                txtMaSach.Clear();
                txtSoLuong.Text = "0";
            }
            int index = dgvHoaDonBan.CurrentCell.RowIndex;
            if(dgvHoaDonBan.Rows[index].Cells[0].Value.ToString().Trim() == "")
            {
                txtMaHDB.Clear();
                txtHoTenKH.Clear();
            }
        }
        private void dgvChiTietHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvChiTietHDB.CurrentCell.RowIndex;
            if (dgvChiTietHDB.Rows[index].Cells[0].Value.ToString().Trim() == "")
            {
                txtMaSach.Clear();
                txtSoLuong.Text = "0";
            }
        }

        private void ucHoaDonBan_Load(object sender, EventArgs e)
        {
            DataBind_HoaDonBan();
            DataBind_ChiTietHoaDonBan();
        }

        //Xử lý hóa đơn bán
        private void btnThemHoaDonBanMoi_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbHoaDonBan.ThemHoaDonBan(ref err, txtMaHDB.Text.Trim().ToUpper(), frmMain.MaNVDangDangNhap, txtHoTenKH.Text.Trim(), dtpNgayLapHDB.Value);
            if(!KQ)
            {
                MessageBox.Show("Mã hóa đơn bán đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBind_HoaDonBan();
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
                //Cập nhật lại số lượng sách
                if (dgv.Rows.Count > 1)
                {
                    for(int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, dgv.Rows[i].Cells["MaSach"].Value.ToString(), Convert.ToInt32(dgv.Rows[i].Cells["SoLuong"].Value.ToString()));
                    }
                }
                DataBind_HoaDonBan();
                DataBind_ChiTietHoaDonBan();
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
            DataBind_HoaDonBan();
        }
        private void btnTriGiaHoaDon_Click(object sender, EventArgs e)
        {
            double TriGiaHoaDon = 0;
            int count = dgvChiTietHDB.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                string MaSach = dgvChiTietHDB.Rows[i].Cells["MaSach"].Value.ToString();
                DataSet ds = dbHoaDonBan.getThongTinSach(MaSach);

                TriGiaHoaDon += Convert.ToDouble(ds.Tables[0].Rows[0]["GiaBan"].ToString()) * Convert.ToDouble(dgvChiTietHDB.Rows[i].Cells["SoLuong"].Value.ToString());
            }
            MessageBox.Show("Trị giá hóa đơn này là: " + TriGiaHoaDon.ToString() + " VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Xử lý chi tiết hóa đơn bán
        private void btnThemMoiChiTietHDB_Click(object sender, EventArgs e)
        {
            string MaHDB = Get_MaHDBDangChon();
            string err = "";
            bool KQ = dbHoaDonBan.ThemChiTietHoaDonBan(ref err, MaHDB, txtMaSach.Text.Trim(), Convert.ToInt32(txtSoLuong.Text));
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Cập nhật lại số lượng sách tồn
            dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, txtMaSach.Text.Trim(), Convert.ToInt32(txtSoLuong.Text) * (-1));
            DataBind_ChiTietHoaDonBan();
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
            DataBind_ChiTietHoaDonBan();
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
            DataBind_ChiTietHoaDonBan();
        }

        //Xử lý tìn kiếm (theo MaHĐB, MaNV, HoTenKH)
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvHoaDonBan.DataSource = dbHoaDonBan.getHoaDonBan().Tables[0];
                DataBind_ChiTietHoaDonBan();
                return;
            }
            dgvHoaDonBan.DataSource = dbHoaDonBan.getHoaDonBanTheoChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim()).Tables[0];
            DataBind_ChiTietHoaDonBan();
        }

        //Xử lý cập nhật lại số lượng sách
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
    }
}
