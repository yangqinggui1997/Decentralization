using System;
using System.Windows.Forms;

namespace _3A
{
    public partial class CONGNO : Form
    {
        public CONGNO()
        {
            InitializeComponent();
        }

        private void CONGNO_Load(object sender, EventArgs e)
        {
            btnprint.Enabled = false;
            btnXoa.Enabled = false;
            string[] danhmuctmp = DANGNHAP.Danhmuc.Split('|');
            string[] quyenhan = DANGNHAP.Quyen.Split('|');

            for (int j = 0; j < danhmuctmp.Length; ++j)
            {
                if (danhmuctmp[j].Trim() == "Thống kê, báo cáo")
                {
                    string[] nv;
                    nv = quyenhan[j].Split(';');
                    if (nv != null)
                    {
                        foreach (string items in nv)
                        {
                            if (items.Trim() == "Thêm (tạo) bản ghi")
                            {
                                btnprint.Enabled = true;
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CONGNO_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "In bản ghi, ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Xoá, ";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
        }
    }
}
