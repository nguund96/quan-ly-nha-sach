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
    public partial class frmHoaDonBan : Form
    {
        QLNSEntities db;
        DBHoaDonBan dbHoaDonBan;
        public frmHoaDonBan()
        {
            InitializeComponent();
            db = new QLNSEntities();
            dbHoaDonBan = new DBHoaDonBan();
        }
        //FormLoad
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ VW_HoaDonBan vào dgvHoaDonBan
            dgvHoaDonBan.DataSource = db.VW_HoaDonBan.ToList();
        }
        //Thoát
        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Xử lý tìm kiếm hóa đơn bán
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvHoaDonBan.DataSource = TimKiem(txtTimKiem.Text.Trim());
        }
        private List<VW_HoaDonBan> TimKiem(string str)
        {
            //Xử lý tìm theo ngày tháng năm nếu đúng định dạng (dd/MM/yyyy)
            try
            {
                DateTime dt = Convert.ToDateTime(str);
                var List = from hd in db.VW_HoaDonBan
                           where hd.NgayLapHD.Value == dt
                           select hd;
                return List.ToList();
            }
            catch
            {
                var List = from hd in db.VW_HoaDonBan
                           where hd.MaHDB.Contains(str) || hd.MaNV.Contains(str) || hd.HoTenNV.Contains(str)
                            || hd.HoTenKH.Contains(str) || hd.TongTien.ToString().Contains(str)
                           select hd;
                return List.ToList();
            }
            
        }
       
        //Lấy ra Mã hóa đơn bán của dòng đang chọn trên dgvHoaDOnBan
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
        //Xử lý button xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHDB = Get_MaHDBDangChon();
            HoaDonBan hd = db.HoaDonBans.Find(MaHDB);
            
            DialogResult dr = MessageBox.Show("Nếu xóa hóa đơn này thì mọi chi tiết hóa đơn liên quan đều sẽ bị xóa, bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string err = "";
                bool KQ = dbHoaDonBan.XoaHoaDonBan(ref err, MaHDB);
                if (!KQ)
                {
                    MessageBox.Show("Lỗi đây: " + err, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Cập nhật lại số lượng sách
                if (hd != null)
                {
                    foreach(ChiTietHDBan ct in hd.ChiTietHDBans)
                    {
                        dbHoaDonBan.CapNhatLaiSoLuongSachTon(ref err, ct.MaSach, (int)ct.SoLuong);
                    }
                }
            }
            dgvHoaDonBan.DataSource = db.VW_HoaDonBan.ToList();
        }

        //In hóa đơn (sự kiện doubleclick vào 1 dòng trên dgvHoaDonBan)
        private void dgvHoaDonBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHDB = "", HoTenKH = "", HoTenNV = "";
            DateTime NgayLapHD = DateTime.Now;

            if (dgvHoaDonBan.Rows.Count <= 0)
            {
                return;
            }
            int r = dgvHoaDonBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHoaDonBan.Rows.Count) return;

            MaHDB = dgvHoaDonBan.Rows[r].Cells[0].Value.ToString();
            HoTenNV = dgvHoaDonBan.Rows[r].Cells[2].Value.ToString();
            HoTenKH = dgvHoaDonBan.Rows[r].Cells[3].Value.ToString();
            NgayLapHD = Convert.ToDateTime(dgvHoaDonBan.Rows[r].Cells[4].Value.ToString());

            (new frmInHoaDon(MaHDB, HoTenKH, HoTenNV, NgayLapHD)).ShowDialog();
        }
    }
}
