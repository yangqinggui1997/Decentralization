using System;
using System.Windows.Forms;

namespace _3A
{
    public partial class NCU : Form
    {
        public NCU()
        {
            InitializeComponent();
        }

        private void NCU_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnXoa.Enabled = false;
            if (MAIN.tkncu == false)
            {
                string[] danhmuctmp = DANGNHAP.Danhmuc.Split('|');
                string[] quyenhan = DANGNHAP.Quyen.Split('|');

                for (int j = 0; j < danhmuctmp.Length; ++j)
                {
                    if (danhmuctmp[j].Trim() == "Quản lý nhà cung ứng")
                    {
                        string[] nv;
                        nv = quyenhan[j].Split(';');
                        if (nv != null)
                        {
                            foreach (string items in nv)
                            {
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    btnThem.Enabled = true;
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    btnSua.Enabled = true;
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
                MAIN.tkncu = false;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            DANGNHAP.thaotac += "Thêm, ";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void NCU_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Xoá, ";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Sửa, ";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
        }
    }
}
