namespace _3A
{
    partial class DOI_MK
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnhaplaimk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblmatkhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancel.BackColor = System.Drawing.Color.Red;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(252, 232);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(113, 35);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnok.BackColor = System.Drawing.Color.Blue;
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(90, 232);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(113, 35);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmkmoi.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkmoi.Location = new System.Drawing.Point(196, 110);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.PasswordChar = '•';
            this.txtmkmoi.Size = new System.Drawing.Size(171, 23);
            this.txtmkmoi.TabIndex = 1;
            this.txtmkmoi.TextChanged += new System.EventHandler(this.txtmkmoi_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmkcu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkcu.Location = new System.Drawing.Point(196, 64);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.PasswordChar = '•';
            this.txtmkcu.Size = new System.Drawing.Size(171, 23);
            this.txtmkcu.TabIndex = 0;
            this.txtmkcu.TextChanged += new System.EventHandler(this.txtmkcu_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Xác nhận lại mật khẩu";
            // 
            // txtnhaplaimk
            // 
            this.txtnhaplaimk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnhaplaimk.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhaplaimk.Location = new System.Drawing.Point(196, 156);
            this.txtnhaplaimk.Name = "txtnhaplaimk";
            this.txtnhaplaimk.PasswordChar = '•';
            this.txtnhaplaimk.Size = new System.Drawing.Size(171, 23);
            this.txtnhaplaimk.TabIndex = 2;
            this.txtnhaplaimk.TextChanged += new System.EventHandler(this.txtnhaplaimk_TextChanged);
            this.txtnhaplaimk.Leave += new System.EventHandler(this.txtnhaplaimk_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(108, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.ForeColor = System.Drawing.Color.Red;
            this.lblmatkhau.Location = new System.Drawing.Point(372, 116);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(0, 14);
            this.lblmatkhau.TabIndex = 33;
            // 
            // DOI_MK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 286);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnhaplaimk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DOI_MK";
            this.Load += new System.EventHandler(this.DOI_MK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtnhaplaimk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblmatkhau;
    }
}