namespace QuanLyNhaSach
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sach = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_HoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_HoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiTríToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_DongTab = new System.Windows.Forms.ToolStripButton();
            this.TSB_DongTatCaCacTab = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.TSMI_ThongKe,
            this.giảiTríToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DoiMatKhau,
            this.TSMI_DangXuat});
            this.trangChủToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trangChủToolStripMenuItem.Image")));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // TSMI_DoiMatKhau
            // 
            this.TSMI_DoiMatKhau.Name = "TSMI_DoiMatKhau";
            this.TSMI_DoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.TSMI_DoiMatKhau.Text = "Đổi mật khẩu";
            this.TSMI_DoiMatKhau.Click += new System.EventHandler(this.TSMI_DoiMatKhau_Click);
            // 
            // TSMI_DangXuat
            // 
            this.TSMI_DangXuat.Name = "TSMI_DangXuat";
            this.TSMI_DangXuat.Size = new System.Drawing.Size(145, 22);
            this.TSMI_DangXuat.Text = "Đăng xuất";
            this.TSMI_DangXuat.Click += new System.EventHandler(this.TSMI_DangXuat_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_NhanVien,
            this.TSMI_Sach,
            this.TSMI_HoaDonBan,
            this.TSMI_HoaDonNhap});
            this.danhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhMụcToolStripMenuItem.Image")));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // TSMI_NhanVien
            // 
            this.TSMI_NhanVien.Enabled = false;
            this.TSMI_NhanVien.Name = "TSMI_NhanVien";
            this.TSMI_NhanVien.Size = new System.Drawing.Size(150, 22);
            this.TSMI_NhanVien.Text = "Nhân viên";
            this.TSMI_NhanVien.Click += new System.EventHandler(this.TSMI_NhanVien_Click);
            // 
            // TSMI_Sach
            // 
            this.TSMI_Sach.Name = "TSMI_Sach";
            this.TSMI_Sach.Size = new System.Drawing.Size(150, 22);
            this.TSMI_Sach.Text = "Sách";
            this.TSMI_Sach.Click += new System.EventHandler(this.TSMI_Sach_Click);
            // 
            // TSMI_HoaDonBan
            // 
            this.TSMI_HoaDonBan.Name = "TSMI_HoaDonBan";
            this.TSMI_HoaDonBan.Size = new System.Drawing.Size(150, 22);
            this.TSMI_HoaDonBan.Text = "Hóa đơn bán";
            this.TSMI_HoaDonBan.Click += new System.EventHandler(this.TSMI_HoaDonBan_Click);
            // 
            // TSMI_HoaDonNhap
            // 
            this.TSMI_HoaDonNhap.Name = "TSMI_HoaDonNhap";
            this.TSMI_HoaDonNhap.Size = new System.Drawing.Size(150, 22);
            this.TSMI_HoaDonNhap.Text = "Hóa đơn nhập";
            this.TSMI_HoaDonNhap.Click += new System.EventHandler(this.TSMI_HoaDonNhap_Click);
            // 
            // TSMI_ThongKe
            // 
            this.TSMI_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_ThongKe.Image")));
            this.TSMI_ThongKe.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TSMI_ThongKe.Name = "TSMI_ThongKe";
            this.TSMI_ThongKe.Size = new System.Drawing.Size(85, 20);
            this.TSMI_ThongKe.Text = "Thống kê";
            this.TSMI_ThongKe.Click += new System.EventHandler(this.TSMI_ThongKe_Click);
            // 
            // giảiTríToolStripMenuItem
            // 
            this.giảiTríToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.giảiTríToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giảiTríToolStripMenuItem.Image")));
            this.giảiTríToolStripMenuItem.Name = "giảiTríToolStripMenuItem";
            this.giảiTríToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.giảiTríToolStripMenuItem.Text = "Giải trí";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongTin.Location = new System.Drawing.Point(330, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(464, 24);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "label1";
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_DongTab,
            this.TSB_DongTatCaCacTab});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_DongTab
            // 
            this.TSB_DongTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_DongTab.Image = ((System.Drawing.Image)(resources.GetObject("TSB_DongTab.Image")));
            this.TSB_DongTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_DongTab.Name = "TSB_DongTab";
            this.TSB_DongTab.Size = new System.Drawing.Size(23, 22);
            this.TSB_DongTab.Text = "Đóng Tab";
            this.TSB_DongTab.Click += new System.EventHandler(this.TSB_DongTab_Click);
            // 
            // TSB_DongTatCaCacTab
            // 
            this.TSB_DongTatCaCacTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_DongTatCaCacTab.Image = ((System.Drawing.Image)(resources.GetObject("TSB_DongTatCaCacTab.Image")));
            this.TSB_DongTatCaCacTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_DongTatCaCacTab.Name = "TSB_DongTatCaCacTab";
            this.TSB_DongTatCaCacTab.Size = new System.Drawing.Size(23, 22);
            this.TSB_DongTatCaCacTab.Text = "Đóng tất cả các Tab";
            this.TSB_DongTatCaCacTab.Click += new System.EventHandler(this.TSB_DongTatCaCacTab_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(821, 416);
            this.tabControl.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiệm sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sach;
        private System.Windows.Forms.ToolStripMenuItem TSMI_HoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem TSMI_HoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem giảiTríToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_DongTab;
        private System.Windows.Forms.ToolStripButton TSB_DongTatCaCacTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
    }
}

