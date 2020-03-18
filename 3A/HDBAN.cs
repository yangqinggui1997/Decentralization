using System;
using System.Windows.Forms;

namespace _3A
{
    public partial class HDBAN : Form
    {
        public HDBAN()
        {
            InitializeComponent();
        }

        private void HDBAN_Load(object sender, EventArgs e)
        {
            btnThemmoi.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnInhoadon.Enabled = false;
            if (MAIN.tkhdb == false)
            {
                string[] danhmuctmp = DANGNHAP.Danhmuc.Split('|');
                string[] quyenhan = DANGNHAP.Quyen.Split('|');

                for (int j = 0; j < danhmuctmp.Length; ++j)
                {
                    if (danhmuctmp[j].Trim() == "Quản lý hoá đơn")
                    {
                        string[] nv;
                        nv = quyenhan[j].Split(';');
                        if (nv != null)
                        {
                            foreach (string items in nv)
                            {
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    btnThemmoi.Enabled = true;
                                    btnInhoadon.Enabled = true;
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    btnXoa.Enabled = true;
                                }
                            }
                        }
                        break;
                    }

                }
            }
            else
            {
                MAIN.tkhdb = false;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DANGNHAP.thaotac += "Thêm, ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Xoá, ";
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "In hoá đơn, ";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
        }

        private void HDBAN_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }
    }
}
