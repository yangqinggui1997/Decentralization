using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _3A
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        public static string Danhmuc = "", Quyen = "", user = "", pass = "", IdNV = "";
        public static string matc = "", mand = "", danhmuctc = "", thaotac = "";
        public static bool ghinhomk = false;

        private void DANGNHAP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ctrl.disconnect();
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            if (ghinhomk == true)
            {
                btndangnhap.Enabled = true;
            }
            else
            {
                btndangnhap.Enabled = false;
            }
            danhmuctc = "";
            thaotac = "";
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ctrl.con.State == ConnectionState.Closed)
                {
                    Ctrl.connect();
                }
            }
            catch
            {
                MessageBox.Show("Kết nối cơ sỡ dữ liệu thất bại. Hãy thử lại lần nữa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Ctrl.con.State == ConnectionState.Open)
            {
                string sql = "select * from NGUOI_DUNG";
                Danhmuc = "";
                Quyen = "";
                IdNV = "";
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    DataRow dr;
                    bool kt = false;
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        string tentk = "", mk = "";
                        dr = Ctrl.GetDataToTable(sql).Rows[i];
                        tentk = dr["TenTK"].ToString();
                        mk = DecryptDataByTripleDES(dr["PassWord"].ToString(), "123");
                        if (tentk == txtUsers.Text.Trim() && mk == txtPass.Text)
                        {
                            kt = true;
                            Danhmuc = dr["DanhmucTC"].ToString();
                            Quyen = dr["QuyenDM"].ToString();
                            IdNV = dr["IdNV"].ToString();

                            //lấy mã người dùng, lần đăng nhập cuối
                            mand = dr["IdND"].ToString();

                            break;
                        }
                        else
                        {
                            kt = false;
                        }

                    }
                    if (kt == true)
                    {
                        if (ckbgn.CheckState == CheckState.Checked)
                        {
                            ghinhomk = true;
                        }
                        else
                        {
                            ghinhomk = false;
                        }
                        user = txtUsers.Text;
                        pass = txtPass.Text;

                        // tạo dữ liệu trên bảng truy cập
                        //tạo mã ngẫu nhiên
                        int gt;
                        bool k = false;
                        Random rand = new Random();
                        sql = "select * from TRUY_CAP";
                        gt = rand.Next(100000000, 999999999);
                        string ma = "TC" + gt;
                        DataRow drt;
                        if (Ctrl.GetDataToTable(sql).Rows.Count > 0)
                        {
                            while (k == false)
                            {
                                for (int j = 0; j < Ctrl.GetDataToTable(sql).Rows.Count; ++j)
                                {
                                    drt = Ctrl.GetDataToTable(sql).Rows[j];
                                    if (ma == drt["IdTC"].ToString())
                                    {
                                        k = false;
                                        gt = rand.Next(100000000, 999999999);
                                        ma = "TC" + gt;
                                        break;
                                    }
                                    else
                                    {
                                        k = true;
                                    }
                                }
                            }
                            matc = ma;
                        }
                        else
                        {
                            matc = ma;
                        }

                        //chèn dữ liệu vào bảng truy cập
                        sql = "insert into TRUY_CAP(IdTC, IdND, TenTK, LanDNCuoi) values('" + matc + "','" + mand + "','" + user + "','" + DateTime.Now + "')";

                        Ctrl.RunSQL(sql);

                        Hide();
                        MAIN m = new MAIN();
                        m.mnuTaiKhoan.Text = txtUsers.Text;
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mặt khẩu không đúng hoặc không tồn tại! Bạn chưa đăng ký tài khoản?");
                        txtPass.Text = "";
                        txtPass.Focus();
                        return;
                    }
                }
            }
        }

        //giải mã bằng 3DES
        public static string DecryptDataByTripleDES(string Message, string password)
        {
            byte[] Results;
            var UTF8 = new UTF8Encoding();
            var HashProvider = new MD5CryptoServiceProvider();
            var TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = HashProvider.ComputeHash(UTF8.GetBytes(password));
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            var DataToDecrypt = Convert.FromBase64String(Message);
            try
            {
                Results = TDESAlgorithm.CreateDecryptor().TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }

        private void txtUsers_TextChanged(object sender, EventArgs e)
        {
            if (txtUsers.Text == "" || txtPass.Text == "")
            {
                btndangnhap.Enabled = false;
            }
            else if (txtUsers.Text != "" && txtPass.Text != "")
            {
                btndangnhap.Enabled = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Ctrl.disconnect();
            Application.Exit();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtUsers.Text == "" || txtPass.Text == "")
            {
                btndangnhap.Enabled = false;
            }
            else if (txtUsers.Text != "" && txtPass.Text != "")
            {
                btndangnhap.Enabled = true;
            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            DANGKY dk = new DANGKY();
            dk.ShowDialog();
        }
    }
}
