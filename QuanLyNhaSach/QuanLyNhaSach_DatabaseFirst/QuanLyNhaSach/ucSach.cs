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
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            InitializeComponent();
        }
        DBSach dbSach = new DBSach();
        DBTheLoai dbTheLoai = new DBTheLoai();
        DBNXB dbNXB = new DBNXB();

        //Thêm tên tác giả đã nhập ở txtTenTacGia vào listbox lsbTacGia
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            if(txtTenTacGia.Text.Trim() != "")
            {
                lsbTacGia.Items.Add(txtTenTacGia.Text.Trim());
                txtTenTacGia.Clear();
                txtTenTacGia.Focus();
            }
        }
        //Xóa tác giả đang được chọn trong listbox lsbTacGia
        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            int i = lsbTacGia.SelectedIndex;
            if(i >= 0 && i < lsbTacGia.Items.Count)
            {
                lsbTacGia.Items.RemoveAt(i);
            }
        }
        //sự kiện click vào btnThemTheLoai
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            (new frmTheLoai()).ShowDialog();
            LoadSach();
        }
        //sự kiện click vào btnThemNXB
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            (new frmNXB()).ShowDialog();
            LoadSach();
        }
        //Load thông tin dòng đang chọn trên dgvSSach lên các controls
        private void Load_Info_SelectedRow()
        {
            if (dgvSach.Rows.Count <= 0)
            {
                return;
            }

            int r = dgvSach.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvSach.Rows.Count) return;

            txtMaSach.Text = dgvSach.Rows[r].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[r].Cells[1].Value.ToString();
            txtGiaBan.Text = dgvSach.Rows[r].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvSach.Rows[r].Cells[5].Value.ToString();

            if (dgvSach.Rows[r].Cells[6].Value.ToString() == "True")
            {
                rdbConKinhDoanh.Checked = true;
            }
            else rdbNgungKinhDoanh.Checked = true;

            cmbTheLoai.SelectedValue = dgvSach.Rows[r].Cells[2].Value.ToString();
            cmbNXB.SelectedValue = dgvSach.Rows[r].Cells[3].Value.ToString();

            List<TacGiaVietSach> ds = dbSach.getTacGiaTheoMaSach(dgvSach.Rows[r].Cells[0].Value.ToString());
            lsbTacGia.Items.Clear();
            foreach(TacGiaVietSach tg in ds)
            {
                lsbTacGia.Items.Add(tg.TenTacGia);
            }

        }
        //Load dữ liệu lên dgvSach, cmbTheLoai và cmbNXB
        private void LoadSach()
        {
            List<TheLoai> dsTheLoai = dbTheLoai.getTheLoai();
            TheLoai.DataSource = dsTheLoai;
            TheLoai.DisplayMember = "TenTheLoai";
            TheLoai.ValueMember = "MaTheLoai";

            cmbTheLoai.DataSource = dsTheLoai;
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";


            List<NXB> dsNXB = dbNXB.getNXB();
            NXB.DataSource = dsNXB;
            NXB.DisplayMember = "TenNXB";
            NXB.ValueMember = "MaNXB";

            cmbNXB.DataSource = dsNXB;
            cmbNXB.DisplayMember = "TenNXB";
            cmbNXB.ValueMember = "MaNXB";

            List<Sach> dsSach = dbSach.getSach();
            dgvSach.DataSource = dsSach;

            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns[9].Visible = false;
            dgvSach.Columns[10].Visible = false;

            Load_Info_SelectedRow();
        }
        //Load
        private void ucSach_Load(object sender, EventArgs e)
        {
            LoadSach();
        }
        //Xử lý sự kiện khi click vào 1 dòng trên dgvSach
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectedRow();
        }

        //Lấy ra mã sách của dòng đang chọn trên dgvSach
        private string getMaSachDangChon()
        {
            if (dgvSach.Rows.Count <= 0)
            {
                return "";
            }

            int r = dgvSach.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvSach.Rows.Count) return "";

            return dgvSach.Rows[r].Cells[0].Value.ToString();
        }
        
        //Xử lý thêm - cập nhật sách
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Enabled)
            {
                string err = "";
                bool KQ = dbSach.ThemSach(ref err, txtMaSach.Text.ToUpper().Trim(), txtTenSach.Text.Trim(), cmbTheLoai.SelectedValue.ToString(),
                    cmbNXB.SelectedValue.ToString(), (float)Convert.ToDouble(txtGiaBan.Text), Convert.ToInt32(txtSoLuong.Text),
                    rdbConKinhDoanh.Checked ? 1 : 0);
                if (!KQ)
                {
                    MessageBox.Show("Mã sách đã tồn tại!\nLỗi đây: " + err, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Thêm tác giả viết sách
                for (int i = 0; i < lsbTacGia.Items.Count; i++)
                {
                    KQ = dbSach.ThemTacGiaVietSach(ref err, txtMaSach.Text.ToUpper().Trim(), lsbTacGia.Items[i].ToString());
                }

                LoadSach();

                txtMaSach.Enabled = false;
                btnCapNhat.Enabled = true;
                btnHuy.Enabled = false;
            }
            else
            {
                txtMaSach.Clear();
                txtTenSach.Clear();
                lsbTacGia.Items.Clear();
                txtGiaBan.Clear();
                txtSoLuong.Clear();
                rdbConKinhDoanh.Checked = true;

                txtMaSach.Enabled = true;
                btnCapNhat.Enabled = false;
                btnHuy.Enabled = true;

                txtMaSach.Focus();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnHuy.Enabled = false;

            LoadSach();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbSach.CapNhatSach(ref err, getMaSachDangChon(), txtTenSach.Text.Trim(), cmbTheLoai.SelectedValue.ToString(),
                cmbNXB.SelectedValue.ToString(), (float)Convert.ToDouble(txtGiaBan.Text), Convert.ToInt32(txtSoLuong.Text),
                rdbConKinhDoanh.Checked ? 1 : 0);
            if (!KQ)
            {
                MessageBox.Show("Lỗi đây: " + err, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Cập nhật tác giả viết sách
            dbSach.XoaTatCaTacGiaTheoMaSach(ref err, getMaSachDangChon());
            for (int i = 0; i < lsbTacGia.Items.Count; i++)
            {
                KQ = dbSach.ThemTacGiaVietSach(ref err, getMaSachDangChon(), lsbTacGia.Items[i].ToString());
            }
            LoadSach();
        }

        //Xử lý tìm kiếm sách
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvSach.DataSource = dbSach.getSachTheoChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim());
            dgvSach.Columns[7].Visible = false;
            dgvSach.Columns[8].Visible = false;
            dgvSach.Columns[9].Visible = false;
            dgvSach.Columns[10].Visible = false;
            Load_Info_SelectedRow();
        }

        //Xử lý chỉ cho nhập số vào txtGiaBan
        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDouble(txtGiaBan.Text) == 0)
                {
                    txtGiaBan.Text = "0";
                }
            }
            catch(FormatException)
            {
                txtGiaBan.Text = "0";
            }
        }
        //Xử lý chỉ cho nhập số vào txtSoLuong
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
    }
}
