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

namespace QuanLyNhaSach.DanhMuc
{
    public partial class frmHoaDonNhap : Form
    {
        QLNSEntities db;
        DBHoaDonNhap dbHoaDonNhap;
        public frmHoaDonNhap()
        {
            InitializeComponent();
            db = new QLNSEntities();
            dbHoaDonNhap = new DBHoaDonNhap();
        }
        //FormLoad
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ VW_HoaDonNhap vào dgvHoaDonNhap
            dgvHoaDonNhap.DataSource = db.VW_HoaDonNhap.ToList();
        }
        //Xử lý tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvHoaDonNhap.DataSource = TimKiem(txtTimKiem.Text.Trim());
        }
        private List<VW_HoaDonNhap> TimKiem(string str)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(str);
                var List = from hd in db.VW_HoaDonNhap
                           where hd.NgayLap.Value == dt
                           select hd;
                return List.ToList();
            }
            catch
            {
                var List = from hd in db.VW_HoaDonNhap
                           where hd.MaHDN.Contains(str) || hd.MaNV.Contains(str) || hd.HoTenNV.Contains(str)
                           || hd.MaNCC.Contains(str) || hd.TenNCC.Contains(str) || hd.TongChi.ToString().Contains(str)
                           select hd;
                return List.ToList();
            }
        }
        //Thoát
        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lấy mã hóa đơn nhập của dòng đang chọn trên dgvHoaDonNhap
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
        //Xóa hóa đơn nhập đang chọn trên dgvHoaDonNhap
        private void btnXoa_Click(object sender, EventArgs e)
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

                dgvHoaDonNhap.DataSource = db.VW_HoaDonNhap.ToList();
            }
        }

        //In hóa đơn (sự kiện doubleclick vào 1 dòng trên dgvHoaDonNhap)
        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHDN = "", HoTenNV = "", TenNCC = "";
            DateTime NgayLapHD = DateTime.Now;
            float ThanhTien = 0;

            if (dgvHoaDonNhap.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvHoaDonNhap.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonNhap.Rows.Count) return;
            MaHDN = dgvHoaDonNhap.Rows[r].Cells[0].Value.ToString();
            HoTenNV = dgvHoaDonNhap.Rows[r].Cells[2].Value.ToString();
            TenNCC = dgvHoaDonNhap.Rows[r].Cells[4].Value.ToString();
            NgayLapHD = Convert.ToDateTime(dgvHoaDonNhap.Rows[r].Cells[6].Value.ToString());
            ThanhTien = (float)Convert.ToDouble(dgvHoaDonNhap.Rows[r].Cells[5].Value.ToString());

            (new frmInHoaDon(MaHDN, HoTenNV, TenNCC, NgayLapHD, ThanhTien)).ShowDialog();
        }
    }
}
