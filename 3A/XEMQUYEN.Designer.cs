namespace _3A
{
    partial class XEMQUYEN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnok = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkqlncu = new System.Windows.Forms.CheckBox();
            this.chkQuantri = new System.Windows.Forms.CheckBox();
            this.chktkbc = new System.Windows.Forms.CheckBox();
            this.chkqlhd = new System.Windows.Forms.CheckBox();
            this.chkqlsp = new System.Windows.Forms.CheckBox();
            this.chkqlkh = new System.Windows.Forms.CheckBox();
            this.chkqlnv = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabxacnhanquyen = new System.Windows.Forms.TabControl();
            this.tabqlnv = new System.Windows.Forms.TabPage();
            this.clbqlnv = new System.Windows.Forms.CheckedListBox();
            this.tabqlkh = new System.Windows.Forms.TabPage();
            this.clbqlkh = new System.Windows.Forms.CheckedListBox();
            this.tabqlncu = new System.Windows.Forms.TabPage();
            this.tabqlsp = new System.Windows.Forms.TabPage();
            this.tabqlhd = new System.Windows.Forms.TabPage();
            this.clbqlhd = new System.Windows.Forms.CheckedListBox();
            this.tabqltkbc = new System.Windows.Forms.TabPage();
            this.clbqltkbc = new System.Windows.Forms.CheckedListBox();
            this.tabqlnd = new System.Windows.Forms.TabPage();
            this.clbquantri = new System.Windows.Forms.CheckedListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.clbqlsp = new System.Windows.Forms.CheckedListBox();
            this.clbqlncu = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabxacnhanquyen.SuspendLayout();
            this.tabqlnv.SuspendLayout();
            this.tabqlkh.SuspendLayout();
            this.tabqlncu.SuspendLayout();
            this.tabqlsp.SuspendLayout();
            this.tabqlhd.SuspendLayout();
            this.tabqltkbc.SuspendLayout();
            this.tabqlnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnok
            // 
            this.btnok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnok.BackColor = System.Drawing.Color.Blue;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(317, 11);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(107, 33);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(737, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 421);
            this.splitter2.TabIndex = 40;
            this.splitter2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkqlncu);
            this.groupBox4.Controls.Add(this.chkQuantri);
            this.groupBox4.Controls.Add(this.chktkbc);
            this.groupBox4.Controls.Add(this.chkqlhd);
            this.groupBox4.Controls.Add(this.chkqlsp);
            this.groupBox4.Controls.Add(this.chkqlkh);
            this.groupBox4.Controls.Add(this.chkqlnv);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 421);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh mục được phép truy cập";
            // 
            // chkqlncu
            // 
            this.chkqlncu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkqlncu.AutoSize = true;
            this.chkqlncu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkqlncu.Location = new System.Drawing.Point(18, 76);
            this.chkqlncu.Name = "chkqlncu";
            this.chkqlncu.Size = new System.Drawing.Size(148, 19);
            this.chkqlncu.TabIndex = 12;
            this.chkqlncu.Text = "Quản lý nhà cung ứng.";
            this.chkqlncu.UseVisualStyleBackColor = true;
            // 
            // chkQuantri
            // 
            this.chkQuantri.AutoSize = true;
            this.chkQuantri.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuantri.Location = new System.Drawing.Point(17, 180);
            this.chkQuantri.Name = "chkQuantri";
            this.chkQuantri.Size = new System.Drawing.Size(244, 19);
            this.chkQuantri.TabIndex = 11;
            this.chkQuantri.Text = "Quản trị hệ thống (quản lý người dùng).";
            this.chkQuantri.UseVisualStyleBackColor = true;
            // 
            // chktkbc
            // 
            this.chktkbc.AutoSize = true;
            this.chktkbc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktkbc.Location = new System.Drawing.Point(18, 154);
            this.chktkbc.Name = "chktkbc";
            this.chktkbc.Size = new System.Drawing.Size(128, 19);
            this.chktkbc.TabIndex = 10;
            this.chktkbc.Text = "Thống kê, báo cáo.";
            this.chktkbc.UseVisualStyleBackColor = true;
            // 
            // chkqlhd
            // 
            this.chkqlhd.AutoSize = true;
            this.chkqlhd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkqlhd.Location = new System.Drawing.Point(18, 128);
            this.chkqlhd.Name = "chkqlhd";
            this.chkqlhd.Size = new System.Drawing.Size(120, 19);
            this.chkqlhd.TabIndex = 9;
            this.chkqlhd.Text = "Quản lý hoá đơn.";
            this.chkqlhd.UseVisualStyleBackColor = true;
            // 
            // chkqlsp
            // 
            this.chkqlsp.AutoSize = true;
            this.chkqlsp.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkqlsp.Location = new System.Drawing.Point(18, 102);
            this.chkqlsp.Name = "chkqlsp";
            this.chkqlsp.Size = new System.Drawing.Size(128, 19);
            this.chkqlsp.TabIndex = 8;
            this.chkqlsp.Text = "Quản lý sản phẩm.";
            this.chkqlsp.UseVisualStyleBackColor = true;
            // 
            // chkqlkh
            // 
            this.chkqlkh.AutoSize = true;
            this.chkqlkh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkqlkh.Location = new System.Drawing.Point(18, 50);
            this.chkqlkh.Name = "chkqlkh";
            this.chkqlkh.Size = new System.Drawing.Size(137, 19);
            this.chkqlkh.TabIndex = 7;
            this.chkqlkh.Text = "Quản lý khách hàng.";
            this.chkqlkh.UseVisualStyleBackColor = true;
            // 
            // chkqlnv
            // 
            this.chkqlnv.AutoSize = true;
            this.chkqlnv.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkqlnv.Location = new System.Drawing.Point(18, 24);
            this.chkqlnv.Name = "chkqlnv";
            this.chkqlnv.Size = new System.Drawing.Size(129, 19);
            this.chkqlnv.TabIndex = 6;
            this.chkqlnv.Text = "Quản lý nhân viên.";
            this.chkqlnv.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabxacnhanquyen);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(267, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 421);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền cụ thể cho từng danh mục";
            // 
            // tabxacnhanquyen
            // 
            this.tabxacnhanquyen.Controls.Add(this.tabqlnv);
            this.tabxacnhanquyen.Controls.Add(this.tabqlkh);
            this.tabxacnhanquyen.Controls.Add(this.tabqlncu);
            this.tabxacnhanquyen.Controls.Add(this.tabqlsp);
            this.tabxacnhanquyen.Controls.Add(this.tabqlhd);
            this.tabxacnhanquyen.Controls.Add(this.tabqltkbc);
            this.tabxacnhanquyen.Controls.Add(this.tabqlnd);
            this.tabxacnhanquyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabxacnhanquyen.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabxacnhanquyen.Location = new System.Drawing.Point(3, 19);
            this.tabxacnhanquyen.Name = "tabxacnhanquyen";
            this.tabxacnhanquyen.SelectedIndex = 0;
            this.tabxacnhanquyen.Size = new System.Drawing.Size(464, 399);
            this.tabxacnhanquyen.TabIndex = 0;
            // 
            // tabqlnv
            // 
            this.tabqlnv.AutoScroll = true;
            this.tabqlnv.BackColor = System.Drawing.SystemColors.Control;
            this.tabqlnv.Controls.Add(this.clbqlnv);
            this.tabqlnv.Location = new System.Drawing.Point(4, 24);
            this.tabqlnv.Name = "tabqlnv";
            this.tabqlnv.Padding = new System.Windows.Forms.Padding(3);
            this.tabqlnv.Size = new System.Drawing.Size(456, 371);
            this.tabqlnv.TabIndex = 0;
            this.tabqlnv.Text = "Quản lý nhân viên";
            // 
            // clbqlnv
            // 
            this.clbqlnv.BackColor = System.Drawing.SystemColors.Control;
            this.clbqlnv.CheckOnClick = true;
            this.clbqlnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbqlnv.FormattingEnabled = true;
            this.clbqlnv.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbqlnv.Location = new System.Drawing.Point(3, 3);
            this.clbqlnv.Name = "clbqlnv";
            this.clbqlnv.Size = new System.Drawing.Size(450, 365);
            this.clbqlnv.TabIndex = 0;
            // 
            // tabqlkh
            // 
            this.tabqlkh.AutoScroll = true;
            this.tabqlkh.BackColor = System.Drawing.SystemColors.Control;
            this.tabqlkh.Controls.Add(this.clbqlkh);
            this.tabqlkh.Location = new System.Drawing.Point(4, 24);
            this.tabqlkh.Name = "tabqlkh";
            this.tabqlkh.Padding = new System.Windows.Forms.Padding(3);
            this.tabqlkh.Size = new System.Drawing.Size(456, 371);
            this.tabqlkh.TabIndex = 6;
            this.tabqlkh.Text = "Quản lý khách hàng";
            // 
            // clbqlkh
            // 
            this.clbqlkh.BackColor = System.Drawing.SystemColors.Control;
            this.clbqlkh.CheckOnClick = true;
            this.clbqlkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbqlkh.FormattingEnabled = true;
            this.clbqlkh.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbqlkh.Location = new System.Drawing.Point(3, 3);
            this.clbqlkh.Name = "clbqlkh";
            this.clbqlkh.Size = new System.Drawing.Size(450, 365);
            this.clbqlkh.TabIndex = 1;
            // 
            // tabqlncu
            // 
            this.tabqlncu.BackColor = System.Drawing.SystemColors.Control;
            this.tabqlncu.Controls.Add(this.clbqlncu);
            this.tabqlncu.Location = new System.Drawing.Point(4, 24);
            this.tabqlncu.Name = "tabqlncu";
            this.tabqlncu.Size = new System.Drawing.Size(456, 371);
            this.tabqlncu.TabIndex = 11;
            this.tabqlncu.Text = "Quản lý nhà cung ứng";
            // 
            // tabqlsp
            // 
            this.tabqlsp.AutoScroll = true;
            this.tabqlsp.BackColor = System.Drawing.SystemColors.Control;
            this.tabqlsp.Controls.Add(this.clbqlsp);
            this.tabqlsp.Location = new System.Drawing.Point(4, 24);
            this.tabqlsp.Name = "tabqlsp";
            this.tabqlsp.Padding = new System.Windows.Forms.Padding(3);
            this.tabqlsp.Size = new System.Drawing.Size(456, 371);
            this.tabqlsp.TabIndex = 7;
            this.tabqlsp.Text = "Quản lý sản phẩm";
            // 
            // tabqlhd
            // 
            this.tabqlhd.AutoScroll = true;
            this.tabqlhd.BackColor = System.Drawing.SystemColors.Control;
            this.tabqlhd.Controls.Add(this.clbqlhd);
            this.tabqlhd.Location = new System.Drawing.Point(4, 24);
            this.tabqlhd.Name = "tabqlhd";
            this.tabqlhd.Padding = new System.Windows.Forms.Padding(3);
            this.tabqlhd.Size = new System.Drawing.Size(456, 371);
            this.tabqlhd.TabIndex = 8;
            this.tabqlhd.Text = "Quản lý hoá đơn";
            // 
            // clbqlhd
            // 
            this.clbqlhd.BackColor = System.Drawing.SystemColors.Control;
            this.clbqlhd.CheckOnClick = true;
            this.clbqlhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbqlhd.FormattingEnabled = true;
            this.clbqlhd.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbqlhd.Location = new System.Drawing.Point(3, 3);
            this.clbqlhd.Name = "clbqlhd";
            this.clbqlhd.Size = new System.Drawing.Size(450, 365);
            this.clbqlhd.TabIndex = 1;
            // 
            // tabqltkbc
            // 
            this.tabqltkbc.AutoScroll = true;
            this.tabqltkbc.BackColor = System.Drawing.SystemColors.Control;
            this.tabqltkbc.Controls.Add(this.clbqltkbc);
            this.tabqltkbc.Location = new System.Drawing.Point(4, 24);
            this.tabqltkbc.Name = "tabqltkbc";
            this.tabqltkbc.Padding = new System.Windows.Forms.Padding(3);
            this.tabqltkbc.Size = new System.Drawing.Size(456, 371);
            this.tabqltkbc.TabIndex = 9;
            this.tabqltkbc.Text = "Thống kê, báo cáo";
            // 
            // clbqltkbc
            // 
            this.clbqltkbc.BackColor = System.Drawing.SystemColors.Control;
            this.clbqltkbc.CheckOnClick = true;
            this.clbqltkbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbqltkbc.FormattingEnabled = true;
            this.clbqltkbc.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbqltkbc.Location = new System.Drawing.Point(3, 3);
            this.clbqltkbc.Name = "clbqltkbc";
            this.clbqltkbc.Size = new System.Drawing.Size(450, 365);
            this.clbqltkbc.TabIndex = 1;
            // 
            // tabqlnd
            // 
            this.tabqlnd.AutoScroll = true;
            this.tabqlnd.BackColor = System.Drawing.SystemColors.Control;
            this.tabqlnd.Controls.Add(this.clbquantri);
            this.tabqlnd.Location = new System.Drawing.Point(4, 24);
            this.tabqlnd.Name = "tabqlnd";
            this.tabqlnd.Padding = new System.Windows.Forms.Padding(3);
            this.tabqlnd.Size = new System.Drawing.Size(456, 371);
            this.tabqlnd.TabIndex = 10;
            this.tabqlnd.Text = "Quản trị hệ thống (quản lý người dùng)";
            this.tabqlnd.ToolTipText = "Quản trị hệ thống (quản lý người dùng)";
            // 
            // clbquantri
            // 
            this.clbquantri.BackColor = System.Drawing.SystemColors.Control;
            this.clbquantri.CheckOnClick = true;
            this.clbquantri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbquantri.FormattingEnabled = true;
            this.clbquantri.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbquantri.Location = new System.Drawing.Point(3, 3);
            this.clbquantri.Name = "clbquantri";
            this.clbquantri.Size = new System.Drawing.Size(450, 365);
            this.clbquantri.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(267, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 421);
            this.splitter1.TabIndex = 43;
            this.splitter1.TabStop = false;
            // 
            // clbqlsp
            // 
            this.clbqlsp.BackColor = System.Drawing.SystemColors.Control;
            this.clbqlsp.CheckOnClick = true;
            this.clbqlsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbqlsp.FormattingEnabled = true;
            this.clbqlsp.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbqlsp.Location = new System.Drawing.Point(3, 3);
            this.clbqlsp.Name = "clbqlsp";
            this.clbqlsp.Size = new System.Drawing.Size(450, 365);
            this.clbqlsp.TabIndex = 1;
            // 
            // clbqlncu
            // 
            this.clbqlncu.BackColor = System.Drawing.SystemColors.Control;
            this.clbqlncu.CheckOnClick = true;
            this.clbqlncu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbqlncu.FormattingEnabled = true;
            this.clbqlncu.Items.AddRange(new object[] {
            "Xem (đọc).",
            "Thêm (tạo) bản ghi.",
            "Sửa (cập nhật) bản ghi.",
            "Xoá (huỷ) bản ghi."});
            this.clbqlncu.Location = new System.Drawing.Point(0, 0);
            this.clbqlncu.Name = "clbqlncu";
            this.clbqlncu.Size = new System.Drawing.Size(456, 371);
            this.clbqlncu.TabIndex = 3;
            // 
            // XEMQUYEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 476);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XEMQUYEN";
            this.Text = "Xem quyền hạn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XEMQUYEN_FormClosed);
            this.Load += new System.EventHandler(this.XEMQUYEN_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabxacnhanquyen.ResumeLayout(false);
            this.tabqlnv.ResumeLayout(false);
            this.tabqlkh.ResumeLayout(false);
            this.tabqlncu.ResumeLayout(false);
            this.tabqlsp.ResumeLayout(false);
            this.tabqlhd.ResumeLayout(false);
            this.tabqltkbc.ResumeLayout(false);
            this.tabqlnd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkqlncu;
        private System.Windows.Forms.CheckBox chkQuantri;
        private System.Windows.Forms.CheckBox chktkbc;
        private System.Windows.Forms.CheckBox chkqlhd;
        private System.Windows.Forms.CheckBox chkqlsp;
        private System.Windows.Forms.CheckBox chkqlkh;
        private System.Windows.Forms.CheckBox chkqlnv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabxacnhanquyen;
        private System.Windows.Forms.TabPage tabqlnv;
        private System.Windows.Forms.CheckedListBox clbqlnv;
        private System.Windows.Forms.TabPage tabqlkh;
        private System.Windows.Forms.CheckedListBox clbqlkh;
        private System.Windows.Forms.TabPage tabqlncu;
        private System.Windows.Forms.TabPage tabqlsp;
        private System.Windows.Forms.TabPage tabqlhd;
        private System.Windows.Forms.CheckedListBox clbqlhd;
        private System.Windows.Forms.TabPage tabqltkbc;
        private System.Windows.Forms.CheckedListBox clbqltkbc;
        private System.Windows.Forms.TabPage tabqlnd;
        private System.Windows.Forms.CheckedListBox clbquantri;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckedListBox clbqlncu;
        private System.Windows.Forms.CheckedListBox clbqlsp;
    }
}