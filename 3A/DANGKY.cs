using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace _3A
{
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            InitializeComponent();
        }

        public static string manhomnd = "";
        public static bool xn = false;

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "" || txtTentaikhoan.Text == "" || txtMatkhau.Text == "" || txtnhaplaimatkhau.Text == "")
            {
                if (txtManv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtManv.Focus();
                    return;
                }
                else
                {
                    string sql = "select IdNV from NHAN_VIEN where IdNV ='" + txtManv.Text.Trim() + "'";
                    string id = "";
                    if (Ctrl.GetDataToTable(sql) != null)
                    {
                        foreach (DataRow dr in Ctrl.GetDataToTable(sql).Rows)
                        {
                            id = dr["IdNV"].ToString();
                        }
                    }
                    if (id == "")
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại. Có thể nó chưa được thêm vào bảng 'Nhân viên'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtManv.Focus();
                        return;
                    }
                }
                if (txtTentaikhoan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTentaikhoan.Focus();
                    return;
                }
                if (txtMatkhau.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatkhau.Focus();
                    return;
                }
                if (txtnhaplaimatkhau.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa xác nhận lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnhaplaimatkhau.Focus();
                    return;
                }
            }
            else
            {
                if (txtMatkhau.Text.Length < 6)
                {
                    MessageBox.Show("Độ dài mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatkhau.Focus();
                    return;
                }
                if (txtMatkhau.Text != txtnhaplaimatkhau.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu không đúng. Hãy xác nhận lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnhaplaimatkhau.Focus();
                    return;
                }
                string sql = "", sql1 = "", tennd = "", TK = "";
                string danhmuc, quyen = "";

                sql = "select NHOM_QUYEN_HAN.DanhmucTC from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND = '" + txtmanhomnd.Text + "'";
                danhmuc = Ctrl.GetFieldValues(sql);

                sql = "select NHOM_QUYEN_HAN.QuyenDM from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND = '" + txtmanhomnd.Text + "'";
                quyen = Ctrl.GetFieldValues(sql);

                sql = "select TenNV from NHAN_VIEN where IdNV = '" + txtManv.Text.Trim() + "'";
                tennd = Ctrl.GetFieldValues(sql);

                sql = "select TaiKhoan from NHAN_VIEN where IdNV = '" + txtManv.Text.Trim() + "'";
                TK = Ctrl.GetFieldValues(sql);
                TK += txtTentaikhoan.Text.Trim() + ", ";
                // mã hoá mật khẩu bằng thuật toá 3DES với key là 123
                string mk = EncryptDataByTripleDES(txtMatkhau.Text, "123");

                sql = "insert into NGUOI_DUNG values('" + txtmanguoidung.Text.Trim() + "','" + txtmanhomnd.Text.Trim() + "','" + txtManv.Text.Trim() + "',N'" + tennd + "','" + txtTentaikhoan.Text.Trim() + "','" + mk + "','" + DateTime.Now + "',N'" + danhmuc + "',N'" + quyen + "')";

                sql1 = "update NHAN_VIEN set Taikhoan = '" + TK + "' where IdNV = '" + txtManv.Text.Trim() + "'";

                try
                {
                    Ctrl.RunSQL(sql);
                    Ctrl.RunSQL(sql1);
                    MessageBox.Show("Đăng ký thành công!", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //mã hoá bằng 3DES
        public static string EncryptDataByTripleDES(string Message, string password)
        {
            byte[] Results;
            var UTF8 = new UTF8Encoding();
            var HashProvider = new MD5CryptoServiceProvider();
            var TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = HashProvider.ComputeHash(UTF8.GetBytes(password));
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            var DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                Results = TDESAlgorithm.CreateEncryptor().TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtManv_Leave(object sender, EventArgs e)
        {
            txtManv_TextChanged(sender, e);
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            if (txtMatkhau.Text != "")
            {
                if (Ctrl.CheckMK(txtMatkhau) == 1)
                {
                    erp.SetError(txtMatkhau, "Mật khẩu phải chứa ít nhất 6 ký tự!");
                    txtnhaplaimatkhau.Text = "";
                }
                else if (Ctrl.CheckMK(txtMatkhau) == 2)
                {
                    erp.Clear();
                    lblmatkhau.Text = "Yếu!";
                    lblmatkhau.ForeColor = Color.Gray;
                }
                else if (Ctrl.CheckMK(txtMatkhau) == 3)
                {
                    erp.Clear();
                    lblmatkhau.Text = "Trung bình!";
                    lblmatkhau.ForeColor = Color.YellowGreen;
                }
                else if (Ctrl.CheckMK(txtMatkhau) == 4)
                {
                    erp.Clear();
                    lblmatkhau.Text = "Mạnh!";
                    lblmatkhau.ForeColor = Color.Green;
                }
            }
            else
            {
                erp.SetError(txtMatkhau, "Mật khẩu không được để trống!");
                lblmatkhau.Text = "";
            }
        }

        private void txtnhaplaimatkhau_Leave(object sender, EventArgs e)
        {
            if (txtnhaplaimatkhau.Text != "")
            {
                if (txtMatkhau.Text != txtnhaplaimatkhau.Text)
                {
                    MessageBox.Show("Mật khẩu vừa nhập không đúng!", "Incorrectly!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatkhau.Text = "";
                    txtnhaplaimatkhau.Text = "";
                    lblmatkhau.Text = "";
                    txtMatkhau.Focus();
                    return;
                }
            }
        }

        private void txtTentaikhoan_Leave(object sender, EventArgs e)
        {
            txtTentaikhoan_TextChanged(sender, e);
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            if (txtManv.Text.Length != 0)
            {
                string sql = "select * from NHAN_VIEN where IdNV ='" + txtManv.Text.Trim() + "'";
                string id = "";
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    foreach (DataRow dr in Ctrl.GetDataToTable(sql).Rows)
                    {
                        id = dr["IdNV"].ToString();
                    }
                }
                if (id != "")
                {
                    erp.Clear();
                    txtTentaikhoan.Enabled = true;
                    txtMatkhau.Enabled = true;
                    txtnhaplaimatkhau.Enabled = true;
                    btnDangky.Enabled = true;
                    if (txtManv.Text.Substring(0, 3) == "NQT")
                    {
                        string str = "";
                        sql = "SELECT IdNND from NHOM_NGUOI_DUNG WHERE TenNND = N'Nhóm người dùng là nhân viên quản trị'";
                        id = "";
                        if (Ctrl.GetDataToTable(sql) != null)
                        {
                            foreach (DataRow dr in Ctrl.GetDataToTable(sql).Rows)
                            {
                                id = dr["IdNND"].ToString();
                            }
                        }
                        if (id != "")
                        {
                            txtmanhomnd.Text = id;
                            txttennhomnd.Text = "Nhóm người dùng là nhân viên quản trị";

                            str = "SELECT IdNhomQH FROM NHOM_NGUOI_DUNG WHERE IdNND = '" + txtmanhomnd.Text + "'";
                            txtmanhomqh.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT TenNQH FROM NHOM_QUYEN_HAN WHERE IdNQH = '" + txtmanhomqh.Text + "'";
                            txttennhomqh.Text = Ctrl.GetFieldValues(str);
                        }
                    }

                    if (txtManv.Text.Substring(0, 3) == "NKT")
                    {
                        string str = "";
                        sql = "SELECT IdNND from NHOM_NGUOI_DUNG WHERE TenNND = N'Nhóm người dùng là nhân viên kế toán'";
                        id = "";
                        if (Ctrl.GetDataToTable(sql) != null)
                        {
                            foreach (DataRow dr in Ctrl.GetDataToTable(sql).Rows)
                            {
                                id = dr["IdNND"].ToString();
                            }
                        }
                        if (id != "")
                        {
                            txtmanhomnd.Text = id;
                            txttennhomnd.Text = "Nhóm người dùng là nhân viên kế toán";

                            str = "SELECT IdNhomQH FROM NHOM_NGUOI_DUNG WHERE IdNND = '" + txtmanhomnd.Text + "'";
                            txtmanhomqh.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT TenNQH FROM NHOM_QUYEN_HAN WHERE IdNQH = '" + txtmanhomqh.Text + "'";
                            txttennhomqh.Text = Ctrl.GetFieldValues(str);
                        }

                    }

                    if (txtManv.Text.Substring(0, 3) == "NBH")
                    {
                        string str = "";
                        sql = "SELECT IdNND from NHOM_NGUOI_DUNG WHERE TenNND = N'Nhóm người dùng là nhân viên bán hàng'";
                        id = "";
                        if (Ctrl.GetDataToTable(sql) != null)
                        {
                            foreach (DataRow dr in Ctrl.GetDataToTable(sql).Rows)
                            {
                                id = dr["IdNND"].ToString();
                            }
                        }
                        if (id != "")
                        {
                            txtmanhomnd.Text = id;
                            txttennhomnd.Text = "Nhóm người dùng là nhân viên bán hàng";

                            str = "SELECT IdNhomQH FROM NHOM_NGUOI_DUNG WHERE IdNND = '" + txtmanhomnd.Text + "'";
                            txtmanhomqh.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT TenNQH FROM NHOM_QUYEN_HAN WHERE IdNQH = '" + txtmanhomqh.Text + "'";
                            txttennhomqh.Text = Ctrl.GetFieldValues(str);
                        }
                    }

                    if (txtManv.Text.Substring(0, 3) == "NTK")
                    {
                        string str = "";
                        sql = "SELECT IdNND from NHOM_NGUOI_DUNG WHERE TenNND = N'Nhóm người dùng là nhân viên thủ kho'";
                        id = "";
                        if (Ctrl.GetDataToTable(sql) != null)
                        {
                            foreach (DataRow dr in Ctrl.GetDataToTable(sql).Rows)
                            {
                                id = dr["IdNND"].ToString();
                            }
                        }
                        if (id != "")
                        {
                            txtmanhomnd.Text = id;
                            txttennhomnd.Text = "Nhóm người dùng là nhân viên thủ kho";

                            str = "SELECT IdNhomQH FROM NHOM_NGUOI_DUNG WHERE IdNND = '" + txtmanhomnd.Text + "'";
                            txtmanhomqh.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT TenNQH FROM NHOM_QUYEN_HAN WHERE IdNQH = '" + txtmanhomqh.Text + "'";
                            txttennhomqh.Text = Ctrl.GetFieldValues(str);
                        }

                    }
                }
                else
                {
                    erp.SetError(txtManv, "Mã nhân viên này không tồn tại. Có thể nhân viên chưa được thêm vào bảng 'Nhân viên'!");
                    erp.SetIconAlignment(txtManv, ErrorIconAlignment.MiddleRight);
                    txtTentaikhoan.Enabled = false;
                    txtMatkhau.Enabled = false;
                    txtnhaplaimatkhau.Enabled = false;
                    txtnhaplaimatkhau.Text = "";
                    txtTentaikhoan.Text = "";
                    txtMatkhau.Text = "";
                    txtmanhomnd.Text = "";
                    txttennhomnd.Text = "";
                    txttennhomqh.Text = "";
                    txtmanhomqh.Text = "";
                    lblmatkhau.Text = "";
                    btnDangky.Enabled = false;
                }
            }
            else
            {
                erp.SetError(txtManv, "Mã nhân viên không được để trống!");
                erp.SetIconAlignment(txtManv, ErrorIconAlignment.MiddleRight);
                txtTentaikhoan.Enabled = false;
                txtMatkhau.Enabled = false;
                txtnhaplaimatkhau.Enabled = false;
                txtnhaplaimatkhau.Text = "";
                txtTentaikhoan.Text = "";
                txtMatkhau.Text = "";
                txtmanhomnd.Text = "";
                txttennhomnd.Text = "";
                txttennhomqh.Text = "";
                txtmanhomqh.Text = "";
                lblmatkhau.Text = "";
                btnDangky.Enabled = false;
            }
        }

        private void btnxemquyen_Click(object sender, EventArgs e)
        {
            manhomnd = txtmanhomnd.Text;
            xn = true;
            XEMQUYEN xq = new XEMQUYEN();
            xq.ShowDialog();
        }

        private void DANGKY_Load(object sender, EventArgs e)
        {
            txtTentaikhoan.Enabled = false;
            txtMatkhau.Enabled = false;
            txtnhaplaimatkhau.Enabled = false;
            btnDangky.Enabled = false;
            string sql = "";
            //tạo mã ngẫu nhiên
            int gt;
            bool kt = false;
            Random rand = new Random();
            sql = "select * from NGUOI_DUNG";
            gt = rand.Next(100000000, 999999999);
            string ma = "ND" + gt;
            DataRow drt;
            if (Ctrl.GetDataToTable(sql).Rows.Count > 0)
            {
                while (kt == false)
                {
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        drt = Ctrl.GetDataToTable(sql).Rows[i];
                        if (ma == drt["IdND"].ToString())
                        {
                            kt = false;
                            gt = rand.Next(100000000, 999999999);
                            ma = "ND" + gt;
                            break;
                        }
                        else
                        {
                            kt = true;
                        }
                    }
                }
                txtmanguoidung.Text = ma;
            }
            else
            {
                txtmanguoidung.Text = ma;
            }
        }

        private void txtTentaikhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTentaikhoan.Text != "")
            {
                if (Ctrl.CheckTenTK(txtTentaikhoan) == 1)
                {
                    erp.SetError(txtTentaikhoan, "Tài khoản phải chứa ít nhất 6 ký tự!");
                    erp.SetIconAlignment(txtTentaikhoan, ErrorIconAlignment.MiddleRight);
                    txtTentaikhoan.Focus();
                    btnDangky.Enabled = false;
                }
                else if (Ctrl.CheckTenTK(txtTentaikhoan) == 2)
                {
                    erp.SetError(txtTentaikhoan, "Tài khoản không được chứa dấu cách hoặc ký tự đặc biệt!");
                    erp.SetIconAlignment(txtTentaikhoan, ErrorIconAlignment.MiddleRight);
                    txtTentaikhoan.Focus();
                    btnDangky.Enabled = false;
                }

                string taikhoan = "";
                string sql = "select * from NGUOI_DUNG";
                bool kt = false;
                DataRow dr;
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        dr = Ctrl.GetDataToTable(sql).Rows[i];
                        taikhoan = dr["TenTK"].ToString();
                        if (txtTentaikhoan.Text.Trim() == taikhoan)
                        {
                            kt = true;
                            break;
                        }
                        else
                        {
                            kt = false;
                        }
                    }
                }
                if (kt == true)
                {
                    erp.SetError(txtTentaikhoan, "Tài khoản này đã tồn tại. Hãy chọn tên khác!");
                    erp.SetIconAlignment(txtTentaikhoan, ErrorIconAlignment.MiddleRight);
                    txtTentaikhoan.Focus();
                    btnDangky.Enabled = false;
                }
                if ((Ctrl.CheckTenTK(txtTentaikhoan) != 1 && Ctrl.CheckTenTK(txtTentaikhoan) != 2) && kt == false)
                {
                    erp.Clear();
                    btnDangky.Enabled = true;
                }
            }
            else
            {
                erp.SetError(txtTentaikhoan, "Tài khoản không được để trống!");
                erp.SetIconAlignment(txtTentaikhoan, ErrorIconAlignment.MiddleRight);
            }
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            txtMatkhau_Leave(sender, e);
        }
    }
}
