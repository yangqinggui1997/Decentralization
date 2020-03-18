namespace _3A
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudoimk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuxemquyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStartpage = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoigiaodien = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnumanage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnund = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhomnd_qh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutruycap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhacungung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhangton = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucongno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutkhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutkhdban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutkhdnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutkkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutksanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutknhacu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnugoithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhuongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuStartpage,
            this.exitToolStripMenuItem});
            this.fileMenu.ForeColor = System.Drawing.Color.White;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            this.fileMenu.CheckedChanged += new System.EventHandler(this.fileMenu_CheckedChanged);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnudoimk,
            this.mnuxemquyen});
            this.mnuTaiKhoan.Image = global::_3A.Properties.Resources.BO_User_32x32;
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(152, 22);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = global::_3A.Properties.Resources.Action_Logoff_32x32;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(145, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnudoimk
            // 
            this.mnudoimk.Image = global::_3A.Properties.Resources.Action_Security_ChangePassword_32x32;
            this.mnudoimk.Name = "mnudoimk";
            this.mnudoimk.Size = new System.Drawing.Size(145, 22);
            this.mnudoimk.Text = "Đổi mật khẩu";
            this.mnudoimk.Click += new System.EventHandler(this.mnudoimk_Click);
            // 
            // mnuxemquyen
            // 
            this.mnuxemquyen.Image = global::_3A.Properties.Resources.Action_ShowItemOnDashboard_32x32;
            this.mnuxemquyen.Name = "mnuxemquyen";
            this.mnuxemquyen.Size = new System.Drawing.Size(145, 22);
            this.mnuxemquyen.Text = "Xem quyền";
            this.mnuxemquyen.Click += new System.EventHandler(this.mnuxemquyen_Click);
            // 
            // mnuStartpage
            // 
            this.mnuStartpage.Image = global::_3A.Properties.Resources.BO_Address_32x32;
            this.mnuStartpage.Name = "mnuStartpage";
            this.mnuStartpage.Size = new System.Drawing.Size(152, 22);
            this.mnuStartpage.Text = "StartPage";
            this.mnuStartpage.Click += new System.EventHandler(this.mnuStartpage_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::_3A.Properties.Resources.Ribbon_Exit_32x32;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoigiaodien,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.ForeColor = System.Drawing.Color.White;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            this.windowsMenu.CheckedChanged += new System.EventHandler(this.windowsMenu_CheckedChanged);
            // 
            // mnuDoigiaodien
            // 
            this.mnuDoigiaodien.Name = "mnuDoigiaodien";
            this.mnuDoigiaodien.Size = new System.Drawing.Size(152, 22);
            this.mnuDoigiaodien.Text = "Đổi giao diện";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // mnumanage
            // 
            this.mnumanage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunguoidung,
            this.mnunhanvien,
            this.mnuKhachhang,
            this.mnuHD,
            this.mnuSanpham,
            this.mnunhacungung});
            this.mnumanage.ForeColor = System.Drawing.Color.White;
            this.mnumanage.Name = "mnumanage";
            this.mnumanage.Size = new System.Drawing.Size(62, 20);
            this.mnumanage.Text = "&Manage";
            this.mnumanage.CheckedChanged += new System.EventHandler(this.mnumanage_CheckedChanged);
            // 
            // mnunguoidung
            // 
            this.mnunguoidung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnund,
            this.mnunhomnd_qh,
            this.mnutruycap});
            this.mnunguoidung.Enabled = false;
            this.mnunguoidung.Image = global::_3A.Properties.Resources.BO_Lead_32x32;
            this.mnunguoidung.Name = "mnunguoidung";
            this.mnunguoidung.Size = new System.Drawing.Size(207, 22);
            this.mnunguoidung.Text = "Người dùng, phân quyền";
            // 
            // mnund
            // 
            this.mnund.Enabled = false;
            this.mnund.Image = global::_3A.Properties.Resources.BO_User_32x321;
            this.mnund.Name = "mnund";
            this.mnund.Size = new System.Drawing.Size(270, 22);
            this.mnund.Text = "Người dùng";
            this.mnund.Click += new System.EventHandler(this.mnund_Click);
            // 
            // mnunhomnd_qh
            // 
            this.mnunhomnd_qh.Enabled = false;
            this.mnunhomnd_qh.Image = global::_3A.Properties.Resources.BO_Department_32x32;
            this.mnunhomnd_qh.Name = "mnunhomnd_qh";
            this.mnunhomnd_qh.Size = new System.Drawing.Size(270, 22);
            this.mnunhomnd_qh.Text = "Nhóm người dùng, nhóm quyền hạn";
            this.mnunhomnd_qh.Click += new System.EventHandler(this.mnunhomnd_qh_Click);
            // 
            // mnutruycap
            // 
            this.mnutruycap.Enabled = false;
            this.mnutruycap.Image = global::_3A.Properties.Resources.BO_Contact_32x32;
            this.mnutruycap.Name = "mnutruycap";
            this.mnutruycap.Size = new System.Drawing.Size(270, 22);
            this.mnutruycap.Text = "QL Truy cập";
            this.mnutruycap.Click += new System.EventHandler(this.mnutruycap_Click);
            // 
            // mnunhanvien
            // 
            this.mnunhanvien.Enabled = false;
            this.mnunhanvien.Image = global::_3A.Properties.Resources.BO_Employee_32x32;
            this.mnunhanvien.Name = "mnunhanvien";
            this.mnunhanvien.Size = new System.Drawing.Size(207, 22);
            this.mnunhanvien.Text = "Nhân viên";
            this.mnunhanvien.Click += new System.EventHandler(this.mnunhanvien_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Enabled = false;
            this.mnuKhachhang.Image = global::_3A.Properties.Resources.BO_Customer_32x32;
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(207, 22);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhoadonnhap,
            this.mnuhoadonban});
            this.mnuHD.Image = global::_3A.Properties.Resources.ModelEditor_Categorized_32x32;
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(207, 22);
            this.mnuHD.Text = "Hoá đơn";
            // 
            // mnuhoadonnhap
            // 
            this.mnuhoadonnhap.Enabled = false;
            this.mnuhoadonnhap.Image = global::_3A.Properties.Resources.ModelEditor_ModelMerge_32x32;
            this.mnuhoadonnhap.Name = "mnuhoadonnhap";
            this.mnuhoadonnhap.Size = new System.Drawing.Size(152, 22);
            this.mnuhoadonnhap.Text = "Hoá đơn nhập";
            this.mnuhoadonnhap.Click += new System.EventHandler(this.mnuhoadonnhap_Click);
            // 
            // mnuhoadonban
            // 
            this.mnuhoadonban.Enabled = false;
            this.mnuhoadonban.Image = global::_3A.Properties.Resources.BO_Sale_32x32;
            this.mnuhoadonban.Name = "mnuhoadonban";
            this.mnuhoadonban.Size = new System.Drawing.Size(152, 22);
            this.mnuhoadonban.Text = "Hoá đơn bán";
            this.mnuhoadonban.Click += new System.EventHandler(this.mnuhoadonban_Click);
            // 
            // mnuSanpham
            // 
            this.mnuSanpham.Enabled = false;
            this.mnuSanpham.Image = global::_3A.Properties.Resources.BO_Product_32x32;
            this.mnuSanpham.Name = "mnuSanpham";
            this.mnuSanpham.Size = new System.Drawing.Size(207, 22);
            this.mnuSanpham.Text = "Sản phẩm";
            this.mnuSanpham.Click += new System.EventHandler(this.mnuSanpham_Click);
            // 
            // mnunhacungung
            // 
            this.mnunhacungung.Enabled = false;
            this.mnunhacungung.Image = global::_3A.Properties.Resources.BO_Vendor_32x32;
            this.mnunhacungung.Name = "mnunhacungung";
            this.mnunhacungung.Size = new System.Drawing.Size(207, 22);
            this.mnunhacungung.Text = "Nhà cung ứng";
            this.mnunhacungung.Click += new System.EventHandler(this.mnunhacungung_Click);
            // 
            // mnuStatistics
            // 
            this.mnuStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhangton,
            this.mnudoanhthu,
            this.mnucongno});
            this.mnuStatistics.ForeColor = System.Drawing.Color.White;
            this.mnuStatistics.Name = "mnuStatistics";
            this.mnuStatistics.Size = new System.Drawing.Size(65, 20);
            this.mnuStatistics.Text = "&Statistics";
            this.mnuStatistics.CheckedChanged += new System.EventHandler(this.mnuStatistics_CheckedChanged);
            // 
            // mnuhangton
            // 
            this.mnuhangton.Enabled = false;
            this.mnuhangton.Image = global::_3A.Properties.Resources.BO_Opportunity_32x32;
            this.mnuhangton.Name = "mnuhangton";
            this.mnuhangton.Size = new System.Drawing.Size(152, 22);
            this.mnuhangton.Text = "Hàng tồn";
            this.mnuhangton.Click += new System.EventHandler(this.mnuhangton_Click);
            // 
            // mnudoanhthu
            // 
            this.mnudoanhthu.Enabled = false;
            this.mnudoanhthu.Image = global::_3A.Properties.Resources.BO_PivotChart_32x32;
            this.mnudoanhthu.Name = "mnudoanhthu";
            this.mnudoanhthu.Size = new System.Drawing.Size(152, 22);
            this.mnudoanhthu.Text = "Doanh thu";
            this.mnudoanhthu.Click += new System.EventHandler(this.mnudoanhthu_Click);
            // 
            // mnucongno
            // 
            this.mnucongno.Enabled = false;
            this.mnucongno.Image = global::_3A.Properties.Resources.Action_PivotChart_Data_Unbind_32x32;
            this.mnucongno.Name = "mnucongno";
            this.mnucongno.Size = new System.Drawing.Size(152, 22);
            this.mnucongno.Text = "Công nợ";
            this.mnucongno.Click += new System.EventHandler(this.mnucongno_Click);
            // 
            // mnusearch
            // 
            this.mnusearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutkhoadon,
            this.mnutkkhachhang,
            this.mnutksanpham,
            this.mnutknhacu});
            this.mnusearch.ForeColor = System.Drawing.Color.White;
            this.mnusearch.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnusearch.Name = "mnusearch";
            this.mnusearch.Size = new System.Drawing.Size(54, 20);
            this.mnusearch.Text = "&Search";
            this.mnusearch.CheckedChanged += new System.EventHandler(this.mnusearch_CheckedChanged);
            // 
            // mnutkhoadon
            // 
            this.mnutkhoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutkhdban,
            this.mnutkhdnhap});
            this.mnutkhoadon.Name = "mnutkhoadon";
            this.mnutkhoadon.Size = new System.Drawing.Size(152, 22);
            this.mnutkhoadon.Text = "Hoá đơn";
            // 
            // mnutkhdban
            // 
            this.mnutkhdban.Name = "mnutkhdban";
            this.mnutkhdban.Size = new System.Drawing.Size(152, 22);
            this.mnutkhdban.Text = "Hoá đơn bán";
            this.mnutkhdban.Click += new System.EventHandler(this.mnutkhdban_Click);
            // 
            // mnutkhdnhap
            // 
            this.mnutkhdnhap.Name = "mnutkhdnhap";
            this.mnutkhdnhap.Size = new System.Drawing.Size(152, 22);
            this.mnutkhdnhap.Text = "Hoá đơn nhập";
            this.mnutkhdnhap.Click += new System.EventHandler(this.mnutkhdnhap_Click);
            // 
            // mnutkkhachhang
            // 
            this.mnutkkhachhang.Name = "mnutkkhachhang";
            this.mnutkkhachhang.Size = new System.Drawing.Size(152, 22);
            this.mnutkkhachhang.Text = "Khách hàng";
            this.mnutkkhachhang.Click += new System.EventHandler(this.mnutkkhachhang_Click);
            // 
            // mnutksanpham
            // 
            this.mnutksanpham.Name = "mnutksanpham";
            this.mnutksanpham.Size = new System.Drawing.Size(152, 22);
            this.mnutksanpham.Text = "Sản phẩm";
            this.mnutksanpham.Click += new System.EventHandler(this.mnutksanpham_Click);
            // 
            // mnutknhacu
            // 
            this.mnutknhacu.Name = "mnutknhacu";
            this.mnutknhacu.Size = new System.Drawing.Size(152, 22);
            this.mnutknhacu.Text = "Nhà cung ứng";
            this.mnutknhacu.Click += new System.EventHandler(this.mnutknhacu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.mnugoithieu,
            this.mnuhuongdan});
            this.helpMenu.ForeColor = System.Drawing.Color.White;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            this.helpMenu.CheckedChanged += new System.EventHandler(this.helpMenu_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(131, 6);
            // 
            // mnugoithieu
            // 
            this.mnugoithieu.Name = "mnugoithieu";
            this.mnugoithieu.Size = new System.Drawing.Size(134, 22);
            this.mnugoithieu.Text = "Giới thiệu";
            // 
            // mnuhuongdan
            // 
            this.mnuhuongdan.Name = "mnuhuongdan";
            this.mnuhuongdan.Size = new System.Drawing.Size(134, 22);
            this.mnuhuongdan.Text = "Hướng dẫn";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Green;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.windowsMenu,
            this.mnumanage,
            this.mnuStatistics,
            this.mnusearch,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::_3A.Properties.Resources.tải_xuống__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HOẠT ĐỘNG KINH DOANH ĐIỆN TỬ - ĐIỆN MÁY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MAIN_FormClosed);
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        public System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnudoimk;
        private System.Windows.Forms.ToolStripMenuItem mnuStartpage;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuDoigiaodien;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnumanage;
        private System.Windows.Forms.ToolStripMenuItem mnunguoidung;
        private System.Windows.Forms.ToolStripMenuItem mnunhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuHD;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonban;
        private System.Windows.Forms.ToolStripMenuItem mnuSanpham;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics;
        private System.Windows.Forms.ToolStripMenuItem mnuhangton;
        private System.Windows.Forms.ToolStripMenuItem mnudoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnucongno;
        private System.Windows.Forms.ToolStripMenuItem mnusearch;
        private System.Windows.Forms.ToolStripMenuItem mnutkhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnutkhdban;
        private System.Windows.Forms.ToolStripMenuItem mnutkhdnhap;
        private System.Windows.Forms.ToolStripMenuItem mnutkkhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnutksanpham;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnugoithieu;
        private System.Windows.Forms.ToolStripMenuItem mnuhuongdan;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuxemquyen;
        private System.Windows.Forms.ToolStripMenuItem mnunhacungung;
        private System.Windows.Forms.ToolStripMenuItem mnund;
        private System.Windows.Forms.ToolStripMenuItem mnunhomnd_qh;
        private System.Windows.Forms.ToolStripMenuItem mnutknhacu;
        private System.Windows.Forms.ToolStripMenuItem mnutruycap;
    }
}



