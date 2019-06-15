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

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            if(txtTenTacGia.Text.Trim() != "")
            {
                lsbTacGia.Items.Add(txtTenTacGia.Text.Trim());
                txtTenTacGia.Clear();
                txtTenTacGia.Focus();
            }
        }
        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            int i = lsbTacGia.SelectedIndex;
            if(i >= 0 && i < lsbTacGia.Items.Count)
            {
                lsbTacGia.Items.RemoveAt(i);
            }
        }
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            (new frmTheLoai()).ShowDialog();
            LoadSach();
        }
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            (new frmNXB()).ShowDialog();
            LoadSach();
        }

        private void Load_Info_SelectRow()
        {
            if (dgvSach.Rows.Count <= 1)
            {
                return;
            }

            int r = dgvSach.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvSach.Rows.Count - 1) return;

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

            DataSet ds = dbSach.getTacGiaTheoMaSach(dgvSach.Rows[r].Cells[0].Value.ToString());
            lsbTacGia.Items.Clear();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                lsbTacGia.Items.Add(row["TenTacGia"].ToString());
            }

        }
        private void LoadSach()
        {
            DataSet dsTheLoai = dbTheLoai.getTheLoai();
            TheLoai.DataSource = dsTheLoai.Tables[0];
            TheLoai.DisplayMember = "TenTheLoai";
            TheLoai.ValueMember = "MaTheLoai";

            cmbTheLoai.DataSource = dsTheLoai.Tables[0];
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";


            DataSet dsNXB = dbNXB.getNXB();
            NXB.DataSource = dsNXB.Tables[0];
            NXB.DisplayMember = "TenNXB";
            NXB.ValueMember = "MaNXB";

            cmbNXB.DataSource = dsNXB.Tables[0];
            cmbNXB.DisplayMember = "TenNXB";
            cmbNXB.ValueMember = "MaNXB";

            DataSet dsSach = dbSach.getSach();
            dgvSach.DataSource = dsSach.Tables[0];

            Load_Info_SelectRow();
        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            //DataSet dsTheLoai = dbTheLoai.getTheLoai();
            //cmbTheLoai.DataSource = dsTheLoai.Tables[0];
            //cmbTheLoai.DisplayMember = "TenTheLoai";
            //cmbTheLoai.ValueMember = "MaTheLoai";
            //DataSet dsNXB = dbNXB.getNXB();
            //cmbNXB.DataSource = dsNXB.Tables[0];
            //cmbNXB.DisplayMember = "TenNXB";
            //cmbNXB.ValueMember = "MaNXB";
            LoadSach();
        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Info_SelectRow();
        }

        private string getMaSachDangChon()
        {
            if (dgvSach.Rows.Count <= 1)
            {
                return "";
            }

            int r = dgvSach.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvSach.Rows.Count - 1) return "";

            return dgvSach.Rows[r].Cells[0].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            bool KQ = dbSach.ThemSach(ref err, txtMaSach.Text.ToUpper().Trim(), txtTenSach.Text.Trim(), cmbTheLoai.SelectedValue.ToString(),
                cmbNXB.SelectedValue.ToString(), (float)Convert.ToDouble(txtGiaBan.Text), Convert.ToInt32(txtSoLuong.Text),
                rdbConKinhDoanh.Checked ? 1 : 0);
            if(!KQ)
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                dgvSach.DataSource = dbSach.getSach().Tables[0];
                LoadSach();
                return;
            }
            dgvSach.DataSource = dbSach.getSachTheoChuoiTimKiem(txtTimKiem.Text.ToUpper().Trim()).Tables[0];
            Load_Info_SelectRow();
        }

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
