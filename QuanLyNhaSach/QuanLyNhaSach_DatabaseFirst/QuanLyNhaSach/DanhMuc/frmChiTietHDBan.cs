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
    public partial class frmChiTietHDBan : Form
    {
        QLNSEntities db;
        DBHoaDonBan dbHoaDonBan;
        public frmChiTietHDBan()
        {
            InitializeComponent();
            db = new QLNSEntities();
            dbHoaDonBan = new DBHoaDonBan();
        }

        //FormLoad
        private void frmChiTietHDBan_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ VW_ChiTietHDBan lên dgvChiTietHDBan
            dgvChiTietHDBan.DataSource = db.VW_ChiTietHDBan.ToList();
        }
        //Xử lý tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim() == "")
            {
                dgvChiTietHDBan.DataSource = db.VW_ChiTietHDBan.ToList();
                return;
            }
            dgvChiTietHDBan.DataSource = TimKiem(txtTimKiem.Text);
        }
        private List<VW_ChiTietHDBan> TimKiem(string str)
        {
            var List = from ct in db.VW_ChiTietHDBan
                       where ct.MaHDB.Contains(str) || ct.MaSach.Contains(str) || ct.TenSach.Contains(str)
                           || ct.GiaBan.ToString().Contains(str) || ct.SoLuong.ToString().Contains(str)
                           || ct.TongTien.ToString().Contains(str)
                       select ct;
            return List.ToList();
        }
       
        //Thoát
        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Lấy ra mã hóa đơn bán của dòng đang được chọn trên dgvChiTietHDB
        private string Get_MaHDBDangChon()
        {
            if (dgvChiTietHDBan.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvChiTietHDBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDBan.Rows.Count) return "";
            return dgvChiTietHDBan.Rows[r].Cells[0].Value.ToString();
        }
        //Lấy ra mã sách của dòng đang được chọn trên dgvChiTietHDB
        private string Get_MaSachDangChon()
        {
            if (dgvChiTietHDBan.Rows.Count <= 0)
            {
                return "";
            }
            int r = dgvChiTietHDBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDBan.Rows.Count) return "";
            return dgvChiTietHDBan.Rows[r].Cells[1].Value.ToString();
        }
        //Lấy ra số lượng sách của dòng đang được chọn trên dgvChiTietHDB
        private int Get_SoLuongSachCu()
        {
            if (dgvChiTietHDBan.Rows.Count <= 0)
            {
                return 0;
            }
            int r = dgvChiTietHDBan.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvChiTietHDBan.Rows.Count) return 0;
            return Convert.ToInt32(dgvChiTietHDBan.Rows[r].Cells[4].Value.ToString());
        }
        //Xử lý button xóa
        private void btnXoa_Click(object sender, EventArgs e)
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
            dgvChiTietHDBan.DataSource = db.VW_ChiTietHDBan.ToList();
        }
    }
}
