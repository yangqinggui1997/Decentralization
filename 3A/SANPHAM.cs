using System;
using System.Windows.Forms;

namespace _3A
{
    public partial class SANPHAM : Form
    {
        public SANPHAM()
        {
            InitializeComponent();
        }

        private void SANPHAM_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnOpenAnhSP.Enabled = false;
            if (MAIN.tksp == false)
            {
                string[] danhmuctmp = DANGNHAP.Danhmuc.Split('|');
                string[] quyenhan = DANGNHAP.Quyen.Split('|');

                for (int j = 0; j < danhmuctmp.Length; ++j)
                {
                    if (danhmuctmp[j].Trim() == "Quản lý sản phẩm")
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
                                    btnOpenAnhSP.Enabled = true;
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
                MAIN.tksp = false;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Xoá, ";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Sửa, ";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
        }

        private void SANPHAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }
    }
}
