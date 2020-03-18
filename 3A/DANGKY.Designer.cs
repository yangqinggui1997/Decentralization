namespace _3A
{
    partial class DANGKY
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTentaikhoan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxemquyen = new System.Windows.Forms.Button();
            this.txttennhomqh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmanhomqh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttennhomnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmanhomnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtmanguoidung = new System.Windows.Forms.TextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(151, 133);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '•';
            this.txtMatkhau.ShortcutsEnabled = false;
            this.txtMatkhau.Size = new System.Drawing.Size(241, 23);
            this.txtMatkhau.TabIndex = 29;
            this.toolTip1.SetToolTip(this.txtMatkhau, "Mật khẩu phải chứa ít nhất 3 ký tự, phải có ít nhất 1 ký tự chữ, 1 ký tự số, 1 ký" +
        " tự khoảng trắng hoặc 1 ký tự đặc biệt!\r\n");
            this.txtMatkhau.TextChanged += new System.EventHandler(this.txtMatkhau_TextChanged);
            this.txtMatkhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // txtTentaikhoan
            // 
            this.txtTentaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTentaikhoan.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentaikhoan.Location = new System.Drawing.Point(151, 97);
            this.txtTentaikhoan.Name = "txtTentaikhoan";
            this.txtTentaikhoan.Size = new System.Drawing.Size(241, 23);
            this.txtTentaikhoan.TabIndex = 28;
            this.toolTip1.SetToolTip(this.txtTentaikhoan, "Tên người dùng không được chứa khoảng trắng hoặc ký tự đặc biệt!");
            this.txtTentaikhoan.TextChanged += new System.EventHandler(this.txtTentaikhoan_TextChanged);
            this.txtTentaikhoan.Leave += new System.EventHandler(this.txtTentaikhoan_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 73);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(262, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 63);
            this.panel2.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThoat);
            this.panel6.Controls.Add(this.btnDangky);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 63);
            this.panel6.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(273, 14);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 34);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangky.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangky.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangky.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.Color.White;
            this.btnDangky.Location = new System.Drawing.Point(91, 14);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(116, 34);
            this.btnDangky.TabIndex = 0;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = false;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(480, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 63);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(483, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 399);
            this.panel4.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxemquyen);
            this.groupBox2.Controls.Add(this.txttennhomqh);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtmanhomqh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txttennhomnd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtmanhomnd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 399);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhóm người dùng liên quan";
            // 
            // btnxemquyen
            // 
            this.btnxemquyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnxemquyen.BackColor = System.Drawing.Color.Green;
            this.btnxemquyen.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnxemquyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemquyen.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemquyen.ForeColor = System.Drawing.Color.White;
            this.btnxemquyen.Location = new System.Drawing.Point(200, 173);
            this.btnxemquyen.Name = "btnxemquyen";
            this.btnxemquyen.Size = new System.Drawing.Size(98, 33);
            this.btnxemquyen.TabIndex = 0;
            this.btnxemquyen.Text = "Xem quyền";
            this.btnxemquyen.UseVisualStyleBackColor = false;
            this.btnxemquyen.Click += new System.EventHandler(this.btnxemquyen_Click);
            // 
            // txttennhomqh
            // 
            this.txttennhomqh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttennhomqh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhomqh.Location = new System.Drawing.Point(131, 133);
            this.txttennhomqh.Name = "txttennhomqh";
            this.txttennhomqh.ReadOnly = true;
            this.txttennhomqh.Size = new System.Drawing.Size(241, 23);
            this.txttennhomqh.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên nhóm QH";
            // 
            // txtmanhomqh
            // 
            this.txtmanhomqh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmanhomqh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhomqh.Location = new System.Drawing.Point(131, 97);
            this.txtmanhomqh.Name = "txtmanhomqh";
            this.txtmanhomqh.ReadOnly = true;
            this.txtmanhomqh.Size = new System.Drawing.Size(241, 23);
            this.txtmanhomqh.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã nhóm QH";
            // 
            // txttennhomnd
            // 
            this.txttennhomnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttennhomnd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhomnd.Location = new System.Drawing.Point(131, 61);
            this.txttennhomnd.Name = "txttennhomnd";
            this.txttennhomnd.ReadOnly = true;
            this.txttennhomnd.Size = new System.Drawing.Size(241, 23);
            this.txttennhomnd.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tên nhóm ND";
            // 
            // txtmanhomnd
            // 
            this.txtmanhomnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmanhomnd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhomnd.Location = new System.Drawing.Point(131, 25);
            this.txtmanhomnd.Name = "txtmanhomnd";
            this.txtmanhomnd.ReadOnly = true;
            this.txtmanhomnd.Size = new System.Drawing.Size(241, 23);
            this.txtmanhomnd.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mã nhóm ND";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(480, 73);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 399);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 399);
            this.panel5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblmatkhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnhaplaimatkhau);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.txtmanguoidung);
            this.groupBox1.Controls.Add(this.txtTentaikhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã nhân viên";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.ForeColor = System.Drawing.Color.Red;
            this.lblmatkhau.Location = new System.Drawing.Point(398, 138);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(0, 14);
            this.lblmatkhau.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã người dùng";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mật khẩu";
            // 
            // txtnhaplaimatkhau
            // 
            this.txtnhaplaimatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnhaplaimatkhau.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhaplaimatkhau.Location = new System.Drawing.Point(151, 169);
            this.txtnhaplaimatkhau.Name = "txtnhaplaimatkhau";
            this.txtnhaplaimatkhau.PasswordChar = '•';
            this.txtnhaplaimatkhau.ShortcutsEnabled = false;
            this.txtnhaplaimatkhau.Size = new System.Drawing.Size(241, 23);
            this.txtnhaplaimatkhau.TabIndex = 30;
            this.txtnhaplaimatkhau.Leave += new System.EventHandler(this.txtnhaplaimatkhau_Leave);
            // 
            // txtManv
            // 
            this.txtManv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtManv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtManv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtManv.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Location = new System.Drawing.Point(151, 61);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(241, 23);
            this.txtManv.TabIndex = 27;
            this.txtManv.TextChanged += new System.EventHandler(this.txtManv_TextChanged);
            this.txtManv.Leave += new System.EventHandler(this.txtManv_Leave);
            // 
            // txtmanguoidung
            // 
            this.txtmanguoidung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmanguoidung.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanguoidung.Location = new System.Drawing.Point(151, 25);
            this.txtmanguoidung.Name = "txtmanguoidung";
            this.txtmanguoidung.ReadOnly = true;
            this.txtmanguoidung.Size = new System.Drawing.Size(241, 23);
            this.txtmanguoidung.TabIndex = 31;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // DANGKY
            // 
            this.AcceptButton = this.btnDangky;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(874, 535);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DANGKY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DANGKY_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnxemquyen;
        private System.Windows.Forms.TextBox txtmanhomnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.TextBox txttennhomqh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmanhomqh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttennhomnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhaplaimatkhau;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtmanguoidung;
        private System.Windows.Forms.TextBox txtTentaikhoan;
    }
}