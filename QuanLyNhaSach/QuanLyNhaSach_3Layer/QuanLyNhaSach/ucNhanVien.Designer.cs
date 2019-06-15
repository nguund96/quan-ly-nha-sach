namespace QuanLyNhaSach
{
    partial class ucNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhanVien));
            this.btnCapNhatTK = new System.Windows.Forms.Button();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rdbNgung = new System.Windows.Forms.RadioButton();
            this.rdbCon = new System.Windows.Forms.RadioButton();
            this.gbQuyen = new System.Windows.Forms.GroupBox();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.gbTinhTrang = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayNhanViec = new System.Windows.Forms.DateTimePicker();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgayNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhatNhanVien = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbQuyen.SuspendLayout();
            this.gbTinhTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatTK
            // 
            this.btnCapNhatTK.Location = new System.Drawing.Point(667, 366);
            this.btnCapNhatTK.Name = "btnCapNhatTK";
            this.btnCapNhatTK.Size = new System.Drawing.Size(141, 23);
            this.btnCapNhatTK.TabIndex = 95;
            this.btnCapNhatTK.Text = "Đặt lại mật khẩu mặc định";
            this.btnCapNhatTK.UseVisualStyleBackColor = true;
            this.btnCapNhatTK.Click += new System.EventHandler(this.btnCapNhatTK_Click);
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rdbNgung
            // 
            this.rdbNgung.AutoSize = true;
            this.rdbNgung.Location = new System.Drawing.Point(19, 36);
            this.rdbNgung.Name = "rdbNgung";
            this.rdbNgung.Size = new System.Drawing.Size(99, 17);
            this.rdbNgung.TabIndex = 1;
            this.rdbNgung.TabStop = true;
            this.rdbNgung.Text = "Ngưng làm việc";
            this.rdbNgung.UseVisualStyleBackColor = true;
            // 
            // rdbCon
            // 
            this.rdbCon.AutoSize = true;
            this.rdbCon.Checked = true;
            this.rdbCon.Location = new System.Drawing.Point(19, 18);
            this.rdbCon.Name = "rdbCon";
            this.rdbCon.Size = new System.Drawing.Size(86, 17);
            this.rdbCon.TabIndex = 0;
            this.rdbCon.TabStop = true;
            this.rdbCon.Text = "Còn làm việc";
            this.rdbCon.UseVisualStyleBackColor = true;
            // 
            // gbQuyen
            // 
            this.gbQuyen.Controls.Add(this.rdbNhanVien);
            this.gbQuyen.Controls.Add(this.rdbQuanLy);
            this.gbQuyen.Location = new System.Drawing.Point(690, 65);
            this.gbQuyen.Name = "gbQuyen";
            this.gbQuyen.Size = new System.Drawing.Size(118, 62);
            this.gbQuyen.TabIndex = 93;
            this.gbQuyen.TabStop = false;
            this.gbQuyen.Text = "Quyền";
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Checked = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(19, 34);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(75, 17);
            this.rdbNhanVien.TabIndex = 1;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân Viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.Location = new System.Drawing.Point(19, 17);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(65, 17);
            this.rdbQuanLy.TabIndex = 0;
            this.rdbQuanLy.TabStop = true;
            this.rdbQuanLy.Text = "Quản Lý";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tìm kiếm";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(480, 29);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 90;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // gbTinhTrang
            // 
            this.gbTinhTrang.Controls.Add(this.rdbNgung);
            this.gbTinhTrang.Controls.Add(this.rdbCon);
            this.gbTinhTrang.Location = new System.Drawing.Point(690, 3);
            this.gbTinhTrang.Name = "gbTinhTrang";
            this.gbTinhTrang.Size = new System.Drawing.Size(118, 56);
            this.gbTinhTrang.TabIndex = 89;
            this.gbTinhTrang.TabStop = false;
            this.gbTinhTrang.Text = "Tình trạng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(101, 107);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(189, 20);
            this.txtTimKiem.TabIndex = 91;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Ngày Nhận Việc";
            // 
            // dtpNgayNhanViec
            // 
            this.dtpNgayNhanViec.Location = new System.Drawing.Point(101, 81);
            this.dtpNgayNhanViec.Name = "dtpNgayNhanViec";
            this.dtpNgayNhanViec.Size = new System.Drawing.Size(189, 20);
            this.dtpNgayNhanViec.TabIndex = 87;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(425, 29);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 86;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Tên NV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, -337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Họ tên KH";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(101, 55);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(189, 20);
            this.txtTenNV.TabIndex = 83;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(424, 3);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(210, 20);
            this.dtpNgaySinh.TabIndex = 69;
            // 
            // txtHoNV
            // 
            this.txtHoNV.AccessibleDescription = "o";
            this.txtHoNV.Location = new System.Drawing.Point(101, 29);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(189, 20);
            this.txtHoNV.TabIndex = 68;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(101, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(189, 20);
            this.txtMaNV.TabIndex = 67;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(425, 103);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(214, 20);
            this.txtLuong.TabIndex = 81;
            this.txtLuong.Text = "0";
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Số ĐT";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(424, 78);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(214, 20);
            this.txtSoDT.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(424, 52);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(215, 20);
            this.txtDiaChi.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Ngày Sinh";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(4, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
            this.lbl1.TabIndex = 74;
            this.lbl1.Tag = "";
            this.lbl1.Text = "Họ NV";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã NV";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(35, 366);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(120, 23);
            this.btnThemNhanVien.TabIndex = 71;
            this.btnThemNhanVien.Text = "Thêm Nhân Viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.HoNV,
            this.TenNV,
            this.NgaySinh,
            this.Nu,
            this.NgayNV,
            this.DiaChi,
            this.SoDT,
            this.Luong,
            this.TinhTrang});
            this.dgvNhanVien.Location = new System.Drawing.Point(-1, 133);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(809, 227);
            this.dgvNhanVien.TabIndex = 70;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MaNV";
            this.MaHDB.HeaderText = "Mã NV";
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.ReadOnly = true;
            this.MaHDB.Width = 80;
            // 
            // HoNV
            // 
            this.HoNV.DataPropertyName = "HoNV";
            this.HoNV.HeaderText = "Họ NV";
            this.HoNV.Name = "HoNV";
            this.HoNV.ReadOnly = true;
            this.HoNV.Width = 80;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // Nu
            // 
            this.Nu.DataPropertyName = "Nu";
            this.Nu.FalseValue = "0";
            this.Nu.HeaderText = "Giới Tính";
            this.Nu.Name = "Nu";
            this.Nu.ReadOnly = true;
            this.Nu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Nu.TrueValue = "1";
            this.Nu.Width = 40;
            // 
            // NgayNV
            // 
            this.NgayNV.DataPropertyName = "NgayNV";
            this.NgayNV.HeaderText = "Ngày Nhận Việc";
            this.NgayNV.Name = "NgayNV";
            this.NgayNV.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // btnCapNhatNhanVien
            // 
            this.btnCapNhatNhanVien.Location = new System.Drawing.Point(336, 366);
            this.btnCapNhatNhanVien.Name = "btnCapNhatNhanVien";
            this.btnCapNhatNhanVien.Size = new System.Drawing.Size(120, 23);
            this.btnCapNhatNhanVien.TabIndex = 72;
            this.btnCapNhatNhanVien.Text = "Cập nhật Thông Tin";
            this.btnCapNhatNhanVien.UseVisualStyleBackColor = true;
            this.btnCapNhatNhanVien.Click += new System.EventHandler(this.btnCapNhatNhanVien_Click);
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(-1, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 24);
            this.label13.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(299, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 24);
            this.label11.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(631, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 24);
            this.label12.TabIndex = 98;
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCapNhatTK);
            this.Controls.Add(this.gbQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.gbTinhTrang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNgayNhanViec);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnCapNhatNhanVien);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(821, 416);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            this.gbQuyen.ResumeLayout(false);
            this.gbQuyen.PerformLayout();
            this.gbTinhTrang.ResumeLayout(false);
            this.gbTinhTrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatTK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.RadioButton rdbNgung;
        private System.Windows.Forms.RadioButton rdbCon;
        private System.Windows.Forms.GroupBox gbQuyen;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.GroupBox gbTinhTrang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanViec;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button btnCapNhatNhanVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
