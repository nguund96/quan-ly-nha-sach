using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyNhaSach
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        //Hàm khởi tạo để on hóa đơn bán
        string MaHDB = "", HoTenKH = "", HoTenNV = "";
        DateTime NgayLapHD = DateTime.Now, NgayIn = DateTime.Now;
        public frmInHoaDon(string MaHDB, string HoTenKH, string HoTenNV, DateTime NgayLapHD)
        {
            InitializeComponent();
            this.MaHDB = MaHDB;
            this.HoTenKH = HoTenKH;
            this.HoTenNV = HoTenNV;
            this.NgayLapHD = NgayLapHD;
        }
        
        //Hàm khởi tạo để in hóa đơn nhập
        string MaHDN = "", HoTenNV1 = "", TenNCC = "";
        DateTime NgayLapHD1 = DateTime.Now, NgayIn1 = DateTime.Now;
        float ThanhTien = 0;
        public frmInHoaDon(string MaHDN, string HoTenNV1, string TenNCC, DateTime NgayLapHD1, float ThanhTien)
        {
            InitializeComponent();
            this.MaHDN = MaHDN;
            this.HoTenNV1 = HoTenNV1;
            this.TenNCC = TenNCC;
            this.NgayLapHD1 = NgayLapHD1;
            this.ThanhTien = ThanhTien;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            if(MaHDB != "") //Nếu hàm khởi tạo in hóa đơn bán được chạy
            {
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                // TODO: This line of code loads data into the 'ThongKeDataSet.VW_ChiTietHDBan' table. You can move, or remove it, as needed.
                this.VW_ChiTietHDBanTableAdapter.Fill(this.ThongKeDataSet.VW_ChiTietHDBan);
                SetParametters_HoaDonBan();
                this.reportViewer1.RefreshReport();
            }
            else if (MaHDN != "") //Nếu hàm khởi tạo in hóa đơn nhập được chạy
            {
                reportViewer2.Visible = true;
                reportViewer1.Visible = false;
                // TODO: This line of code loads data into the 'ThongKeDataSet.VW_ChiTietHDNhap' table. You can move, or remove it, as needed.
                this.vW_ChiTietHDNhapTableAdapter.Fill(this.ThongKeDataSet.VW_ChiTietHDNhap);
                SetParametters_HoaDonNhap();
                this.reportViewer2.RefreshReport();
            }
        }
        
        //Set tham số truyền vào HoaDonBanReport
        private void SetParametters_HoaDonBan()
        {
            ReportParameter rp = new ReportParameter("MaHDB");
            rp.Values.Add(MaHDB);
            reportViewer1.LocalReport.SetParameters(rp);

            ReportParameter rp1 = new ReportParameter("HoTenKH");
            rp1.Values.Add(HoTenKH);
            reportViewer1.LocalReport.SetParameters(rp1);

            ReportParameter rp2 = new ReportParameter("HoTenNV");
            rp2.Values.Add(HoTenNV);
            reportViewer1.LocalReport.SetParameters(rp2);

            ReportParameter rp3 = new ReportParameter("NgayLapHD");
            rp3.Values.Add(NgayLapHD.ToString());
            reportViewer1.LocalReport.SetParameters(rp3);

            ReportParameter rp4 = new ReportParameter("NgayIn");
            rp4.Values.Add(NgayIn.ToString());
            reportViewer1.LocalReport.SetParameters(rp4);


            float ThanhTien = 0;
            foreach(var i in ThongKeDataSet.VW_ChiTietHDBan)
            {
                if(i.MaHDB == MaHDB)
                {
                    ThanhTien += (float)i.TongTien;
                }
            }
            ReportParameter rp5 = new ReportParameter("ThanhTien");
            rp5.Values.Add(ThanhTien.ToString());
            reportViewer1.LocalReport.SetParameters(rp5);
        }
        //Set tham số truyền vào HoaDonNhapReport
        private void SetParametters_HoaDonNhap()
        {
            ReportParameter rp = new ReportParameter("MaHDN");
            rp.Values.Add(MaHDN);
            reportViewer2.LocalReport.SetParameters(rp);

            ReportParameter rp1 = new ReportParameter("HoTenNV");
            rp1.Values.Add(HoTenNV1);
            reportViewer2.LocalReport.SetParameters(rp1);

            ReportParameter rp2 = new ReportParameter("TenNCC");
            rp2.Values.Add(TenNCC);
            reportViewer2.LocalReport.SetParameters(rp2);

            ReportParameter rp3 = new ReportParameter("NgayLapHD");
            rp3.Values.Add(NgayLapHD1.ToString());
            reportViewer2.LocalReport.SetParameters(rp3);

            ReportParameter rp4 = new ReportParameter("NgayIn");
            rp4.Values.Add(NgayIn1.ToString());
            reportViewer2.LocalReport.SetParameters(rp4);

            ReportParameter rp5 = new ReportParameter("ThanhTien");
            rp5.Values.Add(ThanhTien.ToString());
            reportViewer2.LocalReport.SetParameters(rp5);
        }
    }
}
