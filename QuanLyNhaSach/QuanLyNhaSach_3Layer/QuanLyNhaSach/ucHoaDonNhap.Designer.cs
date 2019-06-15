namespace QuanLyNhaSach
{
    partial class ucHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoaDonNhap));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTriGiaHoaDon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhatChiTietHDN = new System.Windows.Forms.Button();
            this.btnXoaChiTietHDN = new System.Windows.Forms.Button();
            this.btnThemMoiChiTietHDN = new System.Windows.Forms.Button();
            this.btnCapNhatHoaDonNhap = new System.Windows.Forms.Button();
            this.btnXoaHoaDonNhap = new System.Windows.Forms.Button();
            this.dgvChiTietHDN = new System.Windows.Forms.DataGridView();
            this.MaHDN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemHoaDonNhapMoi = new System.Windows.Forms.Button();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.dtpNgayLapHDN = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.cmbNhaCC = new System.Windows.Forms.ComboBox();
            this.btnThemNhaCC = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(82, 75);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(360, 20);
            this.txtTimKiem.TabIndex = 51;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTriGiaHoaDon
            // 
            this.btnTriGiaHoaDon.Location = new System.Drawing.Point(351, 366);
            this.btnTriGiaHoaDon.Name = "btnTriGiaHoaDon";
            this.btnTriGiaHoaDon.Size = new System.Drawing.Size(91, 23);
            this.btnTriGiaHoaDon.TabIndex = 50;
            this.btnTriGiaHoaDon.Text = "Trị giá hóa đơn";
            this.btnTriGiaHoaDon.UseVisualStyleBackColor = true;
            this.btnTriGiaHoaDon.Click += new System.EventHandler(this.btnTriGiaHoaDon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Giá nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(505, 52);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(303, 20);
            this.txtGiaNhap.TabIndex = 48;
            this.txtGiaNhap.Text = "0";
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày lập HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã HĐN";
            // 
            // btnCapNhatChiTietHDN
            // 
            this.btnCapNhatChiTietHDN.Location = new System.Drawing.Point(733, 366);
            this.btnCapNhatChiTietHDN.Name = "btnCapNhatChiTietHDN";
            this.btnCapNhatChiTietHDN.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatChiTietHDN.TabIndex = 40;
            this.btnCapNhatChiTietHDN.Text = "Cập nhật";
            this.btnCapNhatChiTietHDN.UseVisualStyleBackColor = true;
            this.btnCapNhatChiTietHDN.Click += new System.EventHandler(this.btnCapNhatChiTietHDN_Click);
            // 
            // btnXoaChiTietHDN
            // 
            this.btnXoaChiTietHDN.Location = new System.Drawing.Point(617, 367);
            this.btnXoaChiTietHDN.Name = "btnXoaChiTietHDN";
            this.btnXoaChiTietHDN.Size = new System.Drawing.Size(67, 23);
            this.btnXoaChiTietHDN.TabIndex = 39;
            this.btnXoaChiTietHDN.Text = "Xóa";
            this.btnXoaChiTietHDN.UseVisualStyleBackColor = true;
            this.btnXoaChiTietHDN.Click += new System.EventHandler(this.btnXoaChiTietHDN_Click);
            // 
            // btnThemMoiChiTietHDN
            // 
            this.btnThemMoiChiTietHDN.Location = new System.Drawing.Point(484, 366);
            this.btnThemMoiChiTietHDN.Name = "btnThemMoiChiTietHDN";
            this.btnThemMoiChiTietHDN.Size = new System.Drawing.Size(57, 23);
            this.btnThemMoiChiTietHDN.TabIndex = 38;
            this.btnThemMoiChiTietHDN.Text = "Thêm";
            this.btnThemMoiChiTietHDN.UseVisualStyleBackColor = true;
            this.btnThemMoiChiTietHDN.Click += new System.EventHandler(this.btnThemMoiChiTietHDN_Click);
            // 
            // btnCapNhatHoaDonNhap
            // 
            this.btnCapNhatHoaDonNhap.Location = new System.Drawing.Point(230, 366);
            this.btnCapNhatHoaDonNhap.Name = "btnCapNhatHoaDonNhap";
            this.btnCapNhatHoaDonNhap.Size = new System.Drawing.Size(74, 23);
            this.btnCapNhatHoaDonNhap.TabIndex = 37;
            this.btnCapNhatHoaDonNhap.Text = "Cập nhật";
            this.btnCapNhatHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnCapNhatHoaDonNhap.Click += new System.EventHandler(this.btnCapNhatHoaDonNhap_Click);
            // 
            // btnXoaHoaDonNhap
            // 
            this.btnXoaHoaDonNhap.Location = new System.Drawing.Point(131, 366);
            this.btnXoaHoaDonNhap.Name = "btnXoaHoaDonNhap";
            this.btnXoaHoaDonNhap.Size = new System.Drawing.Size(56, 23);
            this.btnXoaHoaDonNhap.TabIndex = 36;
            this.btnXoaHoaDonNhap.Text = "Xóa";
            this.btnXoaHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnXoaHoaDonNhap.Click += new System.EventHandler(this.btnXoaHoaDonNhap_Click);
            // 
            // dgvChiTietHDN
            // 
            this.dgvChiTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDN1,
            this.MaSach,
            this.SoLuong,
            this.GiaNhap});
            this.dgvChiTietHDN.Location = new System.Drawing.Point(452, 101);
            this.dgvChiTietHDN.MultiSelect = false;
            this.dgvChiTietHDN.Name = "dgvChiTietHDN";
            this.dgvChiTietHDN.ReadOnly = true;
            this.dgvChiTietHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHDN.Size = new System.Drawing.Size(356, 259);
            this.dgvChiTietHDN.TabIndex = 34;
            this.dgvChiTietHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHDN_CellClick);
            // 
            // MaHDN1
            // 
            this.MaHDN1.DataPropertyName = "MaHDN";
            this.MaHDN1.HeaderText = "Mã HĐN";
            this.MaHDN1.Name = "MaHDN1";
            this.MaHDN1.ReadOnly = true;
            this.MaHDN1.Width = 80;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 80;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 80;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // btnThemHoaDonNhapMoi
            // 
            this.btnThemHoaDonNhapMoi.Location = new System.Drawing.Point(32, 366);
            this.btnThemHoaDonNhapMoi.Name = "btnThemHoaDonNhapMoi";
            this.btnThemHoaDonNhapMoi.Size = new System.Drawing.Size(56, 23);
            this.btnThemHoaDonNhapMoi.TabIndex = 35;
            this.btnThemHoaDonNhapMoi.Text = "Thêm";
            this.btnThemHoaDonNhapMoi.UseVisualStyleBackColor = true;
            this.btnThemHoaDonNhapMoi.Click += new System.EventHandler(this.btnThemHoaDonNhapMoi_Click);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDN,
            this.NhaCC,
            this.NgayLap,
            this.MaNV});
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(2, 101);
            this.dgvHoaDonNhap.MultiSelect = false;
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(444, 259);
            this.dgvHoaDonNhap.TabIndex = 33;
            this.dgvHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellClick);
            // 
            // MaHDN
            // 
            this.MaHDN.DataPropertyName = "MaHDN";
            this.MaHDN.HeaderText = "Mã HĐN";
            this.MaHDN.Name = "MaHDN";
            // 
            // NhaCC
            // 
            this.NhaCC.DataPropertyName = "MaNCC";
            this.NhaCC.HeaderText = "Nhà cung cấp";
            this.NhaCC.Name = "NhaCC";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgayLap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV lập HĐ";
            this.MaNV.Name = "MaNV";
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(504, 29);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(304, 20);
            this.txtSoLuong.TabIndex = 32;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(503, 6);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(305, 20);
            this.txtMaSach.TabIndex = 31;
            // 
            // dtpNgayLapHDN
            // 
            this.dtpNgayLapHDN.Location = new System.Drawing.Point(82, 52);
            this.dtpNgayLapHDN.Name = "dtpNgayLapHDN";
            this.dtpNgayLapHDN.Size = new System.Drawing.Size(360, 20);
            this.dtpNgayLapHDN.TabIndex = 30;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(82, 6);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(361, 20);
            this.txtMaHDN.TabIndex = 28;
            // 
            // cmbNhaCC
            // 
            this.cmbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCC.FormattingEnabled = true;
            this.cmbNhaCC.Location = new System.Drawing.Point(82, 28);
            this.cmbNhaCC.Name = "cmbNhaCC";
            this.cmbNhaCC.Size = new System.Drawing.Size(331, 21);
            this.cmbNhaCC.TabIndex = 53;
            // 
            // btnThemNhaCC
            // 
            this.btnThemNhaCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNhaCC.BackgroundImage")));
            this.btnThemNhaCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemNhaCC.Location = new System.Drawing.Point(419, 27);
            this.btnThemNhaCC.Name = "btnThemNhaCC";
            this.btnThemNhaCC.Size = new System.Drawing.Size(23, 23);
            this.btnThemNhaCC.TabIndex = 54;
            this.btnThemNhaCC.UseVisualStyleBackColor = true;
            this.btnThemNhaCC.Click += new System.EventHandler(this.btnThemNhaCC_Click);
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(-2, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 24);
            this.label13.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(99, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 24);
            this.label9.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(194, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 24);
            this.label10.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(313, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 24);
            this.label11.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(450, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 24);
            this.label7.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(582, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 24);
            this.label12.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(698, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 24);
            this.label14.TabIndex = 63;
            // 
            // ucHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnThemNhaCC);
            this.Controls.Add(this.cmbNhaCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTriGiaHoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhatChiTietHDN);
            this.Controls.Add(this.btnXoaChiTietHDN);
            this.Controls.Add(this.btnThemMoiChiTietHDN);
            this.Controls.Add(this.btnCapNhatHoaDonNhap);
            this.Controls.Add(this.btnXoaHoaDonNhap);
            this.Controls.Add(this.dgvChiTietHDN);
            this.Controls.Add(this.btnThemHoaDonNhapMoi);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.dtpNgayLapHDN);
            this.Controls.Add(this.txtMaHDN);
            this.Name = "ucHoaDonNhap";
            this.Size = new System.Drawing.Size(821, 416);
            this.Load += new System.EventHandler(this.ucHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTriGiaHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhatChiTietHDN;
        private System.Windows.Forms.Button btnXoaChiTietHDN;
        private System.Windows.Forms.Button btnThemMoiChiTietHDN;
        private System.Windows.Forms.Button btnCapNhatHoaDonNhap;
        private System.Windows.Forms.Button btnXoaHoaDonNhap;
        private System.Windows.Forms.DataGridView dgvChiTietHDN;
        private System.Windows.Forms.Button btnThemHoaDonNhapMoi;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHDN;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.ComboBox cmbNhaCC;
        private System.Windows.Forms.Button btnThemNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewComboBoxColumn NhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}
