using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyNhaSach
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
        }
        //Load
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            this.VW_DanhSachTheLoaiDaBanTableAdapter.Fill(this.ThongKeDataSet.VW_DanhSachTheLoaiDaBan);
            this.VW_DanhSachSachDaBanTableAdapter.Fill(this.ThongKeDataSet.VW_DanhSachSachDaBan);
            
            this.rpDanhSachSach.RefreshReport();
            this.rpDanhSachTheLoai.RefreshReport();

            SetParameters_S();
            rpDanhSachSach.RefreshReport();
        }

        //Sự kiện khi chọn hay bỏ chọn rdbThongKeTheoSach
        private void rdbThongKeTheoSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbThongKeTheoSach.Checked)
            {
                groupBox1.Visible = true;
                rpDanhSachSach.Visible = true;
                rpDanhSachTheLoai.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                rpDanhSachSach.Visible = false;
                rpDanhSachTheLoai.Visible = true;
            }
        }

        //Thống kê theo sách
        private void SetParameters_S()
        {
            ReportParameter rp = new ReportParameter("NgayBatDau");
            rp.Values.Add(dtpNgayBatDau.Value.Date.ToString());
            rpDanhSachSach.LocalReport.SetParameters(rp);

            ReportParameter rp1 = new ReportParameter("NgayKetThuc");
            rp1.Values.Add(dtpNgayKetThuc.Value.Date.ToString());
            rpDanhSachSach.LocalReport.SetParameters(rp1);

            ReportParameter rp2 = new ReportParameter("TongThu");
            rp2.Values.Add(getTongThu().ToString());
            rpDanhSachSach.LocalReport.SetParameters(rp2);
        }
        private float getTongThu()
        {
            
            float TongThu = 0;
            int count = ThongKeDataSet.Tables["VW_DanhSachSachDaBan"].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DateTime NgayLapHD = Convert.ToDateTime(ThongKeDataSet.Tables["VW_DanhSachSachDaBan"].Rows[i]["NgayLapHD"]);
                if (dtpNgayBatDau.Value.Date <= NgayLapHD.Date && NgayLapHD.Date <= dtpNgayKetThuc.Value.Date)
                {
                    int SL = Convert.ToInt32(ThongKeDataSet.Tables["VW_DanhSachSachDaBan"].Rows[i]["SoLuong"]);
                    float GiaBan = (float)Convert.ToDouble(ThongKeDataSet.Tables["VW_DanhSachSachDaBan"].Rows[i]["GiaBan"].ToString());
                    TongThu += SL * GiaBan;
                }
            }
            return TongThu;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters_S();
            rpDanhSachSach.RefreshReport();
        }

        //Thống kê theo thể loại
        private void SetParameters_TL()
        {
            float DoanhThu = 0;
            int count = ThongKeDataSet.Tables["VW_DanhSachTheLoaiDaBan"].Rows.Count;
            for(int i = 0; i < count; i++)
            {
                DoanhThu += (float)Convert.ToDouble(ThongKeDataSet.Tables["VW_DanhSachTheLoaiDaBan"].Rows[i]["DoanhThu"].ToString());
            }
            ReportParameter rp = new ReportParameter("DoanhThu");
            rp.Values.Add(DoanhThu.ToString());
            rpDanhSachTheLoai.LocalReport.SetParameters(rp);
        }
        private void rdbThongKeTheoTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            SetParameters_TL();
            rpDanhSachTheLoai.RefreshReport();
        }
    }
}
