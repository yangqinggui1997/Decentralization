using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3A
{
    public partial class DOI_MK : Form
    {
        public DOI_MK()
        {
            InitializeComponent();
        }

        private void DOI_MK_Load(object sender, EventArgs e)
        {
            btnok.Enabled = false;
            txtmkmoi.Enabled = false;
            txtnhaplaimk.Enabled = false;
        }

        private void txtmkcu_TextChanged(object sender, EventArgs e)
        {
            if (txtmkcu.Text == "")
            {
                txtmkmoi.Enabled = false;
                txtnhaplaimk.Enabled = false;
                txtmkmoi.Text = "";
                txtnhaplaimk.Text = "";
                lblmatkhau.Text = "";
                btnok.Enabled = false;
            }
            else
            {
                if (txtmkcu.Text != DANGNHAP.pass)
                {
                    erp.SetError(txtmkcu, "Mật khẩu vừa nhập không đúng!");
                    txtmkmoi.Enabled = false;
                    txtnhaplaimk.Enabled = false;
                    txtmkmoi.Text = "";
                    txtnhaplaimk.Text = "";
                    lblmatkhau.Text = "";
                    btnok.Enabled = false;
                }
                else
                {
                    txtmkmoi.Enabled = true;
                    erp.Clear();
                    btnok.Enabled = false;
                }
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtnhaplaimk.Text == "")
            {
                MessageBox.Show("Bạn phải xác nhận mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmkmoi.Text = "";
                txtnhaplaimk.Text = "";
                lblmatkhau.Text = "";
                txtmkmoi.Focus();
                txtnhaplaimk.Enabled = false;
                btnok.Enabled = false;
                return;
            }
            else
            {
                string sql = "";
                sql = "update NGUOI_DUNG set PassWord = N'" + txtmkmoi.Text + "' where IdNV = '" + DANGNHAP.IdNV + "'";
                try
                {
                    Ctrl.RunSQL(sql);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sql= "update TRUY_CAP set LanDMKCuoi = '" + DateTime.Now + "' where IdND = '" + DANGNHAP.mand + "'";
                    Ctrl.RunSQL(sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnhaplaimk_Leave(object sender, EventArgs e)
        {
            if (txtnhaplaimk.Text != "")
            {
                if (txtmkmoi.Text != txtnhaplaimk.Text)
                {
                    MessageBox.Show("Mật khẩu vừa nhập không đúng!", "Incorrectly!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmkmoi.Text = "";
                    txtnhaplaimk.Text = "";
                    lblmatkhau.Text = "";
                    txtmkmoi.Focus();
                    return;
                }
                else
                {
                    btnok.Enabled = true;
                }
            }
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            if (txtmkmoi.Text != "")
            {
                if (Ctrl.CheckMK(txtmkmoi) == 1)
                {
                    erp.SetError(txtmkmoi, "Mật khẩu phải chứa ít nhất 6 ký tự!");
                    txtnhaplaimk.Text = "";
                    txtnhaplaimk.Enabled = false;
                    lblmatkhau.Text = "";
                    btnok.Enabled = false;
                }
                else 
                {
                    if (txtmkcu.Text != txtmkmoi.Text)
                    {
                        if (Ctrl.CheckMK(txtmkmoi) == 2)
                        {
                            erp.Clear();
                            lblmatkhau.Text = "Yếu!";
                            lblmatkhau.ForeColor = Color.Gray;
                            txtnhaplaimk.Enabled = true;
                        }
                        else if (Ctrl.CheckMK(txtmkmoi) == 3)
                        {
                            erp.Clear();
                            lblmatkhau.Text = "Trung bình!";
                            lblmatkhau.ForeColor = Color.YellowGreen;
                            txtnhaplaimk.Enabled = true;
                        }
                        else if (Ctrl.CheckMK(txtmkmoi) == 4)
                        {
                            erp.Clear();
                            lblmatkhau.Text = "Mạnh!";
                            lblmatkhau.ForeColor = Color.Green;
                            txtnhaplaimk.Enabled = true;
                        }
                    }
                    else
                    {
                        erp.SetError(txtmkmoi, "Mật khẩu mới không được trùng với mật khẩu cũ!");
                        txtnhaplaimk.Text = "";
                        txtnhaplaimk.Enabled = false;
                        lblmatkhau.Text = "";
                        btnok.Enabled = false;
                    }
                }
            }
            else
            {
                erp.SetError(txtmkmoi, "Mật khẩu mới không được để trống!");
                lblmatkhau.Text = "";
                txtnhaplaimk.Enabled = false;
                txtnhaplaimk.Text = "";
                btnok.Enabled = false;
            }
        }

        private void txtnhaplaimk_TextChanged(object sender, EventArgs e)
        {
            if (txtnhaplaimk.Text != "")
            {
                if (txtmkmoi.Text == txtnhaplaimk.Text)
                {
                    btnok.Enabled = true;
                }
                else
                {
                    btnok.Enabled = false;
                }
            }
            else
            {
                btnok.Enabled = false;
            }
        }
    }
}
