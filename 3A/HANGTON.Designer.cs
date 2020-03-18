namespace _3A
{
    partial class HANGTON
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpngaytk = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbngaynhap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtensp = new System.Windows.Forms.ComboBox();
            this.lblsoluongtk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvhangton = new System.Windows.Forms.DataGridView();
            this.IdHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpngaytk);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.cbngaynhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbtensp);
            this.panel1.Controls.Add(this.lblsoluongtk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 223);
            this.panel1.TabIndex = 8;
            // 
            // dtpngaytk
            // 
            this.dtpngaytk.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaytk.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaytk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytk.Location = new System.Drawing.Point(328, 170);
            this.dtpngaytk.Name = "dtpngaytk";
            this.dtpngaytk.Size = new System.Drawing.Size(172, 23);
            this.dtpngaytk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn ngày TK";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Indigo;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(372, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 33);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá bản ghi";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbngaynhap
            // 
            this.cbngaynhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbngaynhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbngaynhap.DropDownHeight = 1;
            this.cbngaynhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbngaynhap.DropDownWidth = 1;
            this.cbngaynhap.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbngaynhap.FormattingEnabled = true;
            this.cbngaynhap.IntegralHeight = false;
            this.cbngaynhap.Location = new System.Drawing.Point(613, 124);
            this.cbngaynhap.Name = "cbngaynhap";
            this.cbngaynhap.Size = new System.Drawing.Size(172, 23);
            this.cbngaynhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Nhập";
            // 
            // cbtensp
            // 
            this.cbtensp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbtensp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtensp.DropDownHeight = 1;
            this.cbtensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbtensp.DropDownWidth = 1;
            this.cbtensp.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtensp.FormattingEnabled = true;
            this.cbtensp.IntegralHeight = false;
            this.cbtensp.Location = new System.Drawing.Point(328, 124);
            this.cbtensp.Name = "cbtensp";
            this.cbtensp.Size = new System.Drawing.Size(172, 23);
            this.cbtensp.TabIndex = 3;
            // 
            // lblsoluongtk
            // 
            this.lblsoluongtk.AutoSize = true;
            this.lblsoluongtk.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluongtk.ForeColor = System.Drawing.Color.Red;
            this.lblsoluongtk.Location = new System.Drawing.Point(12, 203);
            this.lblsoluongtk.Name = "lblsoluongtk";
            this.lblsoluongtk.Size = new System.Drawing.Size(0, 15);
            this.lblsoluongtk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên S.Phẩm";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(670, 65);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 33);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.OrangeRed;
            this.btntimkiem.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.White;
            this.btntimkiem.Location = new System.Drawing.Point(521, 65);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(107, 33);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Green;
            this.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(223, 65);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(107, 33);
            this.btnprint.TabIndex = 0;
            this.btnprint.Text = "In bản ghi";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ HÀNG TỒN";
            // 
            // dgvhangton
            // 
            this.dgvhangton.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhangton.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhangton.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvhangton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhangton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHT,
            this.IdSP,
            this.IdNCU,
            this.TenSP,
            this.NgaySX,
            this.NgayHH,
            this.NgayNhap,
            this.SLCon,
            this.NgayTK});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhangton.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvhangton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhangton.Location = new System.Drawing.Point(0, 223);
            this.dgvhangton.Name = "dgvhangton";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhangton.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvhangton.RowHeadersVisible = false;
            this.dgvhangton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhangton.Size = new System.Drawing.Size(1000, 330);
            this.dgvhangton.TabIndex = 9;
            // 
            // IdHT
            // 
            this.IdHT.DataPropertyName = "IdHT";
            this.IdHT.HeaderText = "Mã HT";
            this.IdHT.Name = "IdHT";
            this.IdHT.ReadOnly = true;
            // 
            // IdSP
            // 
            this.IdSP.DataPropertyName = "IdSP";
            this.IdSP.HeaderText = "Mã Sản Phẩm";
            this.IdSP.Name = "IdSP";
            this.IdSP.ReadOnly = true;
            // 
            // IdNCU
            // 
            this.IdNCU.DataPropertyName = "IdNCU";
            this.IdNCU.HeaderText = "Mã Nhà Cung Ứng";
            this.IdNCU.Name = "IdNCU";
            this.IdNCU.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên S.Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // NgaySX
            // 
            this.NgaySX.DataPropertyName = "NgaySX";
            this.NgaySX.HeaderText = "Ngày Sản Xuất";
            this.NgaySX.Name = "NgaySX";
            this.NgaySX.ReadOnly = true;
            // 
            // NgayHH
            // 
            this.NgayHH.DataPropertyName = "NgayHH";
            this.NgayHH.HeaderText = "Ngày Hết Hạn SD";
            this.NgayHH.Name = "NgayHH";
            this.NgayHH.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // SLCon
            // 
            this.SLCon.DataPropertyName = "SLCon";
            this.SLCon.HeaderText = "Số Lượng Tồn";
            this.SLCon.Name = "SLCon";
            this.SLCon.ReadOnly = true;
            // 
            // NgayTK
            // 
            this.NgayTK.DataPropertyName = "NgayTK";
            this.NgayTK.HeaderText = "Ngày Thống Kê";
            this.NgayTK.Name = "NgayTK";
            this.NgayTK.ReadOnly = true;
            // 
            // HANGTON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 553);
            this.Controls.Add(this.dgvhangton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HANGTON";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HANGTON_FormClosed);
            this.Load += new System.EventHandler(this.HANGTON_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpngaytk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbngaynhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtensp;
        private System.Windows.Forms.Label lblsoluongtk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvhangton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTK;
    }
}