namespace QuanLyNhaSach
{
    partial class ucThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VW_DanhSachSachDaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeDataSet = new QuanLyNhaSach.ThongKeDataSet();
            this.VW_DanhSachTheLoaiDaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpDanhSachSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rdbThongKeTheoSach = new System.Windows.Forms.RadioButton();
            this.rdbThongKeTheoTheLoai = new System.Windows.Forms.RadioButton();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpDanhSachTheLoai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_DanhSachSachDaBanTableAdapter = new QuanLyNhaSach.ThongKeDataSetTableAdapters.VW_DanhSachSachDaBanTableAdapter();
            this.VW_DanhSachTheLoaiDaBanTableAdapter = new QuanLyNhaSach.ThongKeDataSetTableAdapters.VW_DanhSachTheLoaiDaBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_DanhSachSachDaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_DanhSachTheLoaiDaBanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VW_DanhSachSachDaBanBindingSource
            // 
            this.VW_DanhSachSachDaBanBindingSource.DataMember = "VW_DanhSachSachDaBan";
            this.VW_DanhSachSachDaBanBindingSource.DataSource = this.ThongKeDataSet;
            // 
            // ThongKeDataSet
            // 
            this.ThongKeDataSet.DataSetName = "ThongKeDataSet";
            this.ThongKeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_DanhSachTheLoaiDaBanBindingSource
            // 
            this.VW_DanhSachTheLoaiDaBanBindingSource.DataMember = "VW_DanhSachTheLoaiDaBan";
            this.VW_DanhSachTheLoaiDaBanBindingSource.DataSource = this.ThongKeDataSet;
            // 
            // rpDanhSachSach
            // 
            this.rpDanhSachSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_DanhSachSachDaBanBindingSource;
            this.rpDanhSachSach.LocalReport.DataSources.Add(reportDataSource1);
            this.rpDanhSachSach.LocalReport.ReportEmbeddedResource = "QuanLyNhaSach.SachReport.rdlc";
            this.rpDanhSachSach.Location = new System.Drawing.Point(0, 69);
            this.rpDanhSachSach.Name = "rpDanhSachSach";
            this.rpDanhSachSach.Size = new System.Drawing.Size(818, 347);
            this.rpDanhSachSach.TabIndex = 0;
            // 
            // rdbThongKeTheoSach
            // 
            this.rdbThongKeTheoSach.AutoSize = true;
            this.rdbThongKeTheoSach.Checked = true;
            this.rdbThongKeTheoSach.Location = new System.Drawing.Point(15, 12);
            this.rdbThongKeTheoSach.Name = "rdbThongKeTheoSach";
            this.rdbThongKeTheoSach.Size = new System.Drawing.Size(121, 17);
            this.rdbThongKeTheoSach.TabIndex = 1;
            this.rdbThongKeTheoSach.TabStop = true;
            this.rdbThongKeTheoSach.Text = "Thống kê theo sách";
            this.rdbThongKeTheoSach.UseVisualStyleBackColor = true;
            this.rdbThongKeTheoSach.CheckedChanged += new System.EventHandler(this.rdbThongKeTheoSach_CheckedChanged);
            // 
            // rdbThongKeTheoTheLoai
            // 
            this.rdbThongKeTheoTheLoai.AutoSize = true;
            this.rdbThongKeTheoTheLoai.Location = new System.Drawing.Point(15, 35);
            this.rdbThongKeTheoTheLoai.Name = "rdbThongKeTheoTheLoai";
            this.rdbThongKeTheoTheLoai.Size = new System.Drawing.Size(132, 17);
            this.rdbThongKeTheoTheLoai.TabIndex = 2;
            this.rdbThongKeTheoTheLoai.Text = "Thống kê theo thể loại";
            this.rdbThongKeTheoTheLoai.UseVisualStyleBackColor = true;
            this.rdbThongKeTheoTheLoai.CheckedChanged += new System.EventHandler(this.rdbThongKeTheoTheLoai_CheckedChanged);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(31, 10);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(83, 20);
            this.dtpNgayBatDau.TabIndex = 3;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(152, 10);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(79, 20);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(237, 10);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "đến";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.rdbThongKeTheoTheLoai);
            this.panel1.Controls.Add(this.rdbThongKeTheoSach);
            this.panel1.Location = new System.Drawing.Point(166, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 60);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Location = new System.Drawing.Point(155, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 37);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // rpDanhSachTheLoai
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VW_DanhSachTheLoaiDaBanBindingSource;
            this.rpDanhSachTheLoai.LocalReport.DataSources.Add(reportDataSource2);
            this.rpDanhSachTheLoai.LocalReport.ReportEmbeddedResource = "QuanLyNhaSach.TheLoaiReport.rdlc";
            this.rpDanhSachTheLoai.Location = new System.Drawing.Point(0, 69);
            this.rpDanhSachTheLoai.Name = "rpDanhSachTheLoai";
            this.rpDanhSachTheLoai.Size = new System.Drawing.Size(815, 347);
            this.rpDanhSachTheLoai.TabIndex = 9;
            this.rpDanhSachTheLoai.Visible = false;
            // 
            // VW_DanhSachSachDaBanTableAdapter
            // 
            this.VW_DanhSachSachDaBanTableAdapter.ClearBeforeFill = true;
            // 
            // VW_DanhSachTheLoaiDaBanTableAdapter
            // 
            this.VW_DanhSachTheLoaiDaBanTableAdapter.ClearBeforeFill = true;
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.rpDanhSachTheLoai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rpDanhSachSach);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(818, 416);
            this.Load += new System.EventHandler(this.ucThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_DanhSachSachDaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_DanhSachTheLoaiDaBanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpDanhSachSach;
        private System.Windows.Forms.RadioButton rdbThongKeTheoSach;
        private System.Windows.Forms.RadioButton rdbThongKeTheoTheLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpDanhSachTheLoai;
        private System.Windows.Forms.BindingSource VW_DanhSachSachDaBanBindingSource;
        private ThongKeDataSet ThongKeDataSet;
        private ThongKeDataSetTableAdapters.VW_DanhSachSachDaBanTableAdapter VW_DanhSachSachDaBanTableAdapter;
        private System.Windows.Forms.BindingSource VW_DanhSachTheLoaiDaBanBindingSource;
        private ThongKeDataSetTableAdapters.VW_DanhSachTheLoaiDaBanTableAdapter VW_DanhSachTheLoaiDaBanTableAdapter;
    }
}
