namespace QuanLyNhaSach
{
    partial class ucHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoaDonBan));
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.dtpNgayLapHDB = new System.Windows.Forms.DateTimePicker();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChiTietHDB = new System.Windows.Forms.DataGridView();
            this.btnThemHoaDonBanMoi = new System.Windows.Forms.Button();
            this.btnXoaHoaDonBan = new System.Windows.Forms.Button();
            this.btnCapNhatHoaDonBan = new System.Windows.Forms.Button();
            this.btnThemMoiChiTietHDB = new System.Windows.Forms.Button();
            this.btnXoaChiTietHDB = new System.Windows.Forms.Button();
            this.btnCapNhatChiTietHDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnTriGiaHoaDon = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MaHDB1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(102, 3);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(370, 20);
            this.txtMaHDB.TabIndex = 0;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(102, 26);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(369, 20);
            this.txtHoTenKH.TabIndex = 2;
            // 
            // dtpNgayLapHDB
            // 
            this.dtpNgayLapHDB.Location = new System.Drawing.Point(102, 49);
            this.dtpNgayLapHDB.Name = "dtpNgayLapHDB";
            this.dtpNgayLapHDB.Size = new System.Drawing.Size(369, 20);
            this.dtpNgayLapHDB.TabIndex = 3;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(551, 3);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(260, 20);
            this.txtMaSach.TabIndex = 4;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(552, 26);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(259, 20);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.MaNV,
            this.HoTenKH,
            this.NgayLapHD});
            this.dgvHoaDonBan.Location = new System.Drawing.Point(19, 98);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.ReadOnly = true;
            this.dgvHoaDonBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(453, 263);
            this.dgvHoaDonBan.TabIndex = 6;
            this.dgvHoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonBan_CellClick);
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MaHDB";
            this.MaHDB.HeaderText = "Mã HĐB";
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.ReadOnly = true;
            this.MaHDB.Width = 80;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 80;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Họ tên KH";
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.ReadOnly = true;
            this.HoTenKH.Width = 140;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            // 
            // dgvChiTietHDB
            // 
            this.dgvChiTietHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB1,
            this.MaSach,
            this.SoLuong});
            this.dgvChiTietHDB.Location = new System.Drawing.Point(500, 98);
            this.dgvChiTietHDB.Name = "dgvChiTietHDB";
            this.dgvChiTietHDB.ReadOnly = true;
            this.dgvChiTietHDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHDB.Size = new System.Drawing.Size(311, 263);
            this.dgvChiTietHDB.TabIndex = 7;
            this.dgvChiTietHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHDB_CellClick);
            // 
            // btnThemHoaDonBanMoi
            // 
            this.btnThemHoaDonBanMoi.Location = new System.Drawing.Point(41, 367);
            this.btnThemHoaDonBanMoi.Name = "btnThemHoaDonBanMoi";
            this.btnThemHoaDonBanMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemHoaDonBanMoi.TabIndex = 8;
            this.btnThemHoaDonBanMoi.Text = "Thêm mới";
            this.btnThemHoaDonBanMoi.UseVisualStyleBackColor = true;
            this.btnThemHoaDonBanMoi.Click += new System.EventHandler(this.btnThemHoaDonBanMoi_Click);
            // 
            // btnXoaHoaDonBan
            // 
            this.btnXoaHoaDonBan.Location = new System.Drawing.Point(153, 367);
            this.btnXoaHoaDonBan.Name = "btnXoaHoaDonBan";
            this.btnXoaHoaDonBan.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHoaDonBan.TabIndex = 9;
            this.btnXoaHoaDonBan.Text = "Xóa";
            this.btnXoaHoaDonBan.UseVisualStyleBackColor = true;
            this.btnXoaHoaDonBan.Click += new System.EventHandler(this.btnXoaHoaDonBan_Click);
            // 
            // btnCapNhatHoaDonBan
            // 
            this.btnCapNhatHoaDonBan.Location = new System.Drawing.Point(268, 367);
            this.btnCapNhatHoaDonBan.Name = "btnCapNhatHoaDonBan";
            this.btnCapNhatHoaDonBan.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatHoaDonBan.TabIndex = 10;
            this.btnCapNhatHoaDonBan.Text = "Cập nhật";
            this.btnCapNhatHoaDonBan.UseVisualStyleBackColor = true;
            this.btnCapNhatHoaDonBan.Click += new System.EventHandler(this.btnCapNhatHoaDonBan_Click);
            // 
            // btnThemMoiChiTietHDB
            // 
            this.btnThemMoiChiTietHDB.Location = new System.Drawing.Point(525, 367);
            this.btnThemMoiChiTietHDB.Name = "btnThemMoiChiTietHDB";
            this.btnThemMoiChiTietHDB.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoiChiTietHDB.TabIndex = 12;
            this.btnThemMoiChiTietHDB.Text = "Thêm mới";
            this.btnThemMoiChiTietHDB.UseVisualStyleBackColor = true;
            this.btnThemMoiChiTietHDB.Click += new System.EventHandler(this.btnThemMoiChiTietHDB_Click);
            // 
            // btnXoaChiTietHDB
            // 
            this.btnXoaChiTietHDB.Location = new System.Drawing.Point(630, 367);
            this.btnXoaChiTietHDB.Name = "btnXoaChiTietHDB";
            this.btnXoaChiTietHDB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaChiTietHDB.TabIndex = 13;
            this.btnXoaChiTietHDB.Text = "Xóa";
            this.btnXoaChiTietHDB.UseVisualStyleBackColor = true;
            this.btnXoaChiTietHDB.Click += new System.EventHandler(this.btnXoaChiTietHDB_Click);
            // 
            // btnCapNhatChiTietHDB
            // 
            this.btnCapNhatChiTietHDB.Location = new System.Drawing.Point(737, 367);
            this.btnCapNhatChiTietHDB.Name = "btnCapNhatChiTietHDB";
            this.btnCapNhatChiTietHDB.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatChiTietHDB.TabIndex = 14;
            this.btnCapNhatChiTietHDB.Text = "Cập nhật";
            this.btnCapNhatChiTietHDB.UseVisualStyleBackColor = true;
            this.btnCapNhatChiTietHDB.Click += new System.EventHandler(this.btnCapNhatChiTietHDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã HĐB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Họ tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày lập HĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mã sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tên sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(554, 49);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(256, 20);
            this.txtTenSach.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(554, 72);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(256, 20);
            this.txtGiaBan.TabIndex = 23;
            this.txtGiaBan.Text = "0";
            // 
            // btnTriGiaHoaDon
            // 
            this.btnTriGiaHoaDon.Location = new System.Drawing.Point(381, 367);
            this.btnTriGiaHoaDon.Name = "btnTriGiaHoaDon";
            this.btnTriGiaHoaDon.Size = new System.Drawing.Size(91, 23);
            this.btnTriGiaHoaDon.TabIndex = 25;
            this.btnTriGiaHoaDon.Text = "Trị giá hóa đơn";
            this.btnTriGiaHoaDon.UseVisualStyleBackColor = true;
            this.btnTriGiaHoaDon.Click += new System.EventHandler(this.btnTriGiaHoaDon_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(102, 72);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(369, 20);
            this.txtTimKiem.TabIndex = 26;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tìm kiếm";
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(5, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 24);
            this.label13.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(118, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 24);
            this.label9.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(230, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 24);
            this.label10.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(345, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 24);
            this.label11.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(490, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 24);
            this.label12.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(600, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 24);
            this.label14.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(701, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 24);
            this.label15.TabIndex = 38;
            // 
            // MaHDB1
            // 
            this.MaHDB1.DataPropertyName = "MaHDB";
            this.MaHDB1.HeaderText = "Mã HĐB";
            this.MaHDB1.Name = "MaHDB1";
            this.MaHDB1.ReadOnly = true;
            this.MaHDB1.Width = 90;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 90;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ucHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTriGiaHoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhatChiTietHDB);
            this.Controls.Add(this.btnXoaChiTietHDB);
            this.Controls.Add(this.btnThemMoiChiTietHDB);
            this.Controls.Add(this.btnCapNhatHoaDonBan);
            this.Controls.Add(this.btnXoaHoaDonBan);
            this.Controls.Add(this.btnThemHoaDonBanMoi);
            this.Controls.Add(this.dgvChiTietHDB);
            this.Controls.Add(this.dgvHoaDonBan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.dtpNgayLapHDB);
            this.Controls.Add(this.txtHoTenKH);
            this.Controls.Add(this.txtMaHDB);
            this.Name = "ucHoaDonBan";
            this.Size = new System.Drawing.Size(821, 416);
            this.Load += new System.EventHandler(this.ucHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHDB;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.DataGridView dgvChiTietHDB;
        private System.Windows.Forms.Button btnThemHoaDonBanMoi;
        private System.Windows.Forms.Button btnXoaHoaDonBan;
        private System.Windows.Forms.Button btnCapNhatHoaDonBan;
        private System.Windows.Forms.Button btnThemMoiChiTietHDB;
        private System.Windows.Forms.Button btnXoaChiTietHDB;
        private System.Windows.Forms.Button btnCapNhatChiTietHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnTriGiaHoaDon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
