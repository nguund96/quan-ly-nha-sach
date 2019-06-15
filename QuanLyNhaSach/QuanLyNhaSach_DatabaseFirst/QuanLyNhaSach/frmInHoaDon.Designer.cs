namespace QuanLyNhaSach
{
    partial class frmInHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();

            this.VW_ChiTietHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeDataSet = new QuanLyNhaSach.ThongKeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_ChiTietHDBanTableAdapter = new QuanLyNhaSach.ThongKeDataSetTableAdapters.VW_ChiTietHDBanTableAdapter();

            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_ChiTietHDNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_ChiTietHDNhapTableAdapter = new QuanLyNhaSach.ThongKeDataSetTableAdapters.VW_ChiTietHDNhapTableAdapter();

            ((System.ComponentModel.ISupportInitialize)(this.VW_ChiTietHDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ChiTietHDNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VW_ChiTietHDBanBindingSource
            // 
            this.VW_ChiTietHDBanBindingSource.DataMember = "VW_ChiTietHDBan";
            this.VW_ChiTietHDBanBindingSource.DataSource = this.ThongKeDataSet;
            // 
            // ThongKeDataSet
            // 
            this.ThongKeDataSet.DataSetName = "ThongKeDataSet";
            this.ThongKeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VW_ChiTietHDBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaSach.HoaDonBanReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(843, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // VW_ChiTietHDBanTableAdapter
            // 
            this.VW_ChiTietHDBanTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.DocumentMapWidth = 35;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.VW_ChiTietHDNhapBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyNhaSach.HoaDonNhapReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowBackButton = false;
            this.reportViewer2.ShowPageNavigationControls = false;
            this.reportViewer2.ShowStopButton = false;
            this.reportViewer2.ShowZoomControl = false;
            this.reportViewer2.Size = new System.Drawing.Size(843, 473);
            this.reportViewer2.TabIndex = 1;
            // 
            // VW_ChiTietHDNhapBindingSource
            // 
            this.VW_ChiTietHDNhapBindingSource.DataMember = "VW_ChiTietHDNhap";
            this.VW_ChiTietHDNhapBindingSource.DataSource = this.ThongKeDataSet;
            // 
            // vW_ChiTietHDNhapTableAdapter
            // 
            this.vW_ChiTietHDNhapTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 473);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                               In Hóa Đơn";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_ChiTietHDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ChiTietHDNhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_ChiTietHDBanBindingSource;
        private ThongKeDataSet ThongKeDataSet;
        private ThongKeDataSetTableAdapters.VW_ChiTietHDBanTableAdapter VW_ChiTietHDBanTableAdapter;

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource VW_ChiTietHDNhapBindingSource;
        private ThongKeDataSetTableAdapters.VW_ChiTietHDNhapTableAdapter vW_ChiTietHDNhapTableAdapter;
    }
}