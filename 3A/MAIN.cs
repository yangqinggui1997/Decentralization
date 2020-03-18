using System;
using System.Windows.Forms;
using System.Drawing;

namespace _3A
{
    public partial class MAIN : Form
    {

        public MAIN()
        {
            InitializeComponent();
        }

        public static bool tkhdb, tkhdn, tkkh, tknv, tksp, tkncu, xemquyen;

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP dn = new DANGNHAP();
            if (DANGNHAP.ghinhomk == true)
            {
                dn.txtPass.Text = DANGNHAP.pass;
                dn.txtUsers.Text = DANGNHAP.user;
                dn.ckbgn.Checked = true;
                dn.btndangnhap.Enabled = true;
            }
            string sql = "update TRUY_CAP set DanhmucTC = N'" + DANGNHAP.danhmuctc + "', Thaotac = N'" + DANGNHAP.thaotac + "' where IdTC = '" + DANGNHAP.matc + "'";
            Ctrl.RunSQL(sql);
            dn.Show();
        }

        private void mnuStartpage_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý nhân viên | ";
            DANGNHAP.thaotac += "Xem, ";
            NHANVIEN sp = new NHANVIEN();
            sp.MdiParent = this;
            sp.Show();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý khách hàng | ";
            DANGNHAP.thaotac += "Xem, ";
            KHACHHANG kh = new KHACHHANG();
            kh.MdiParent = this;
            kh.Show();
        }

        private void mnudoimk_Click(object sender, EventArgs e)
        {
            DOI_MK doimnk = new DOI_MK();
            doimnk.MdiParent = this;
            doimnk.Show();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            mnunguoidung.Enabled = false;
            mnunhanvien.Enabled = false;
            mnuKhachhang.Enabled = false;
            mnuSanpham.Enabled = false;
            mnuhoadonban.Enabled = false;
            mnuhoadonnhap.Enabled = false;
            mnunhacungung.Enabled = false;
            mnund.Enabled = false;
            mnunhomnd_qh.Enabled = false;
            string[] danhmuctmp = DANGNHAP.Danhmuc.Split('|');
            for (int j = 0; j < danhmuctmp.Length; ++j)
            {
                if (danhmuctmp[j].Trim() == "Quản lý nhân viên")
                {
                    mnunhanvien.Enabled = false;
                }
                else if (danhmuctmp[j].Trim() == "Quản lý khách hàng")
                {
                    mnuKhachhang.Enabled = true;
                }
                else if (danhmuctmp[j].Trim() == "Quản lý nhà cung ứng")
                {
                    mnunhacungung.Enabled = true;
                }
                else if (danhmuctmp[j].Trim() == "Quản lý sản phẩm")
                {
                    mnuSanpham.Enabled = true;
                }
                else if (danhmuctmp[j].Trim() == "Quản lý hoá đơn")
                {
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NQT")
                    {
                        mnuhoadonban.Enabled = true;
                        mnuhoadonnhap.Enabled = true;
                    }
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NBH")
                    {
                        mnuhoadonban.Enabled = true;
                    }
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NKT")
                    {
                        mnuhoadonban.Enabled = true;
                        mnuhoadonnhap.Enabled = true;
                    }
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NTK")
                    {
                        mnuhoadonnhap.Enabled = true;
                    }
                }
                else if (danhmuctmp[j].Trim() == "Thống kê, báo cáo")
                {
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NQT")
                    {
                        mnucongno.Enabled = true;
                        mnudoanhthu.Enabled = true;
                        mnuhangton.Enabled = true;
                    }
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NBH")
                    {
                        mnucongno.Enabled = true;
                        mnuhangton.Enabled = true;
                    }
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NKT")
                    {
                        mnuhangton.Enabled = true;
                        mnucongno.Enabled = true;
                        mnudoanhthu.Enabled = true;
                    }
                    if (DANGNHAP.IdNV.Substring(0, 3) == "NTK")
                    {
                        mnuhangton.Enabled = true;
                    }
                }
                else if (danhmuctmp[j].Trim() == "Quản trị hệ thống (quản lý người dùng)")
                {
                    mnunguoidung.Enabled = true;
                    mnunhanvien.Enabled = true;
                    mnuKhachhang.Enabled = true;
                    mnuSanpham.Enabled = true;
                    mnuhoadonban.Enabled = true;
                    mnuhoadonnhap.Enabled = true;
                    mnunhacungung.Enabled = true;
                    mnunhomnd_qh.Enabled = true;
                    mnund.Enabled = true;
                    mnutruycap.Enabled = true;
                }
            }
        }

        private void mnuhoadonnhap_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý hoá đơn nhập | ";
            DANGNHAP.thaotac += "Xem, ";
            HDNHAP hdn = new HDNHAP();
            hdn.MdiParent = this;
            hdn.Show();
        }

        private void mnuhoadonban_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý hoá đơn bán | ";
            DANGNHAP.thaotac += "Xem, ";
            HDBAN hdb = new HDBAN();
            hdb.MdiParent = this;
            hdb.Show();
        }

        private void mnuSanpham_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý sản phẩm | ";
            DANGNHAP.thaotac += "Xem, ";
            SANPHAM sp = new SANPHAM();
            sp.MdiParent = this;
            sp.Show();
        }

        private void mnunhacungung_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý nhà cung ứng | ";
            DANGNHAP.thaotac += "Xem, ";
            NCU ncu = new NCU();
            ncu.MdiParent = this;
            ncu.Show();
        }

        private void mnund_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý người dùng và quyền hạn | ";
            DANGNHAP.thaotac += "Xem, ";
            NGUOIDUNG_QH nd_qh = new NGUOIDUNG_QH();
            nd_qh.MdiParent = this;
            nd_qh.Show();
        }

        private void mnunhomnd_qh_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý nhóm người dùng và nhóm quyền hạn | ";
            DANGNHAP.thaotac += "Xem, ";
            NHOMND_NHOMQH nhomnd_nhom_qh = new NHOMND_NHOMQH();
            nhomnd_nhom_qh.MdiParent = this;
            nhomnd_nhom_qh.Show();
        }

        private void mnuhangton_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Thống kê hàng tồn | ";
            DANGNHAP.thaotac += "Xem, ";
            HANGTON ht = new HANGTON();
            ht.MdiParent = this;
            ht.Show();
        }

        private void mnudoanhthu_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Thống kê doanh thu | ";
            DANGNHAP.thaotac += "Xem, ";
            DOANHTHU ht = new DOANHTHU();
            ht.MdiParent = this;
            ht.Show();
        }

        private void mnucongno_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Thống kê công nợ | ";
            DANGNHAP.thaotac += "Xem, ";
            CONGNO cn = new CONGNO();
            cn.MdiParent = this;
            cn.Show();
        }

        private void mnutkhdban_Click(object sender, EventArgs e)
        {
            tkhdb = true;
            mnuhoadonban_Click(sender, e);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DANGNHAP dn = new DANGNHAP();
            if (DANGNHAP.ghinhomk == true)
            {
                dn.txtPass.Text = DANGNHAP.pass;
                dn.txtUsers.Text = DANGNHAP.user;
                dn.ckbgn.Checked = true;
                dn.btndangnhap.Enabled = true;
            }
            dn.Show();
            Close();
        }

        private void mnutruycap_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Quản lý truy cập | ";
            DANGNHAP.thaotac += "Xem, ";
            QLTRUYCAP tc = new QLTRUYCAP();
            tc.MdiParent = this;
            tc.Show();
        }       

        private void windowsMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (windowsMenu.Checked)
            {
                windowsMenu.ForeColor = Color.Black;
            }
            else
            {
                windowsMenu.ForeColor = Color.White;
            }
        }

        private void mnumanage_CheckedChanged(object sender, EventArgs e)
        {
            if (mnumanage.Checked)
            {
                mnumanage.ForeColor = Color.Black;
            }
            else
            {
                mnumanage.ForeColor = Color.White;
            }
        }

        private void mnuStatistics_CheckedChanged(object sender, EventArgs e)
        {
            if (mnuStatistics.Checked)
            {
                mnuStatistics.ForeColor = Color.Black;
            }
            else
            {
                mnuStatistics.ForeColor = Color.White;
            }
        }

        private void helpMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (helpMenu.Checked)
            {
                helpMenu.ForeColor = Color.Black;
            }
            else
            {
                helpMenu.ForeColor = Color.White;
            }
        }
      
        private void fileMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (fileMenu.Checked)
            {
                fileMenu.ForeColor = Color.Black;
            }
            else
            {
                fileMenu.ForeColor = Color.White;
            }
        }

        private void mnusearch_CheckedChanged(object sender, EventArgs e)
        {
            if (mnusearch.Checked)
            {
                mnusearch.ForeColor = Color.Black;
            }
            else
            {
                mnusearch.ForeColor = Color.White;
            }
        }

        private void mnuxemquyen_Click(object sender, EventArgs e)
        {
            DANGNHAP.danhmuctc += DateTime.Now + " ; Xem quyền người dùng | ";
            DANGNHAP.thaotac += "Xem, ";
            xemquyen = true;
            XEMQUYEN xq = new XEMQUYEN();
            xq.MdiParent = this;
            xq.Show();
        }

        private void mnutkhdnhap_Click(object sender, EventArgs e)
        {
            tkhdn = true;
            mnuhoadonnhap_Click(sender, e);
        }

        private void mnutkkhachhang_Click(object sender, EventArgs e)
        {
            tkkh = true;
            mnuKhachhang_Click(sender, e);
        }

        private void mnutknhanvien_Click(object sender, EventArgs e)
        {
            tknv = true;
            mnunhanvien_Click(sender, e);
        }

        private void mnutksanpham_Click(object sender, EventArgs e)
        {
            tksp = true;
            mnuSanpham_Click(sender, e);
        }

        private void mnutknhacu_Click(object sender, EventArgs e)
        {
            tkncu = true;
            mnunhacungung_Click(sender, e);
        }
    }
}
