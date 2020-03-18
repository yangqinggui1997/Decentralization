using System;
using System.Windows.Forms;

namespace _3A
{
    public partial class XEMQUYEN : Form
    {
        public XEMQUYEN()
        {
            InitializeComponent();
        }

        private void XEMQUYEN_Load(object sender, EventArgs e)
        {
            NGUOIDUNG_QH nq = new NGUOIDUNG_QH();
            if (NGUOIDUNG_QH.xacnhan == true)
            {
                string danhmuc, quyen = "";

                string sql = "select NHOM_QUYEN_HAN.DanhmucTC from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND = '" + NGUOIDUNG_QH.manhomND + "'";
                danhmuc = Ctrl.GetFieldValues(sql);

                sql = "select NHOM_QUYEN_HAN.QuyenDM from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND = '" + NGUOIDUNG_QH.manhomND + "'";
                quyen = Ctrl.GetFieldValues(sql);

                string[] danhmuctmp = danhmuc.Split('|');
                string[] quyentmp = quyen.Split('|');

                for (int j = 0; j < danhmuctmp.Length; ++j)
                {
                    if (danhmuctmp[j].Trim() == "Quản lý nhân viên")
                    {
                        chkqlnv.Checked = true;
                        string[] nv;
                        nv = quyentmp[j].Split(';');
                        if (nv != null)
                        {
                            foreach (string items in nv)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlnv.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý khách hàng")
                    {
                        chkqlkh.Checked = true;
                        string[] kh;
                        kh = quyentmp[j].Split(';');
                        if (kh != null)
                        {
                            foreach (string items in kh)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlkh.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý nhà cung ứng")
                    {
                        chkqlncu.Checked = true;
                        string[] ncu;
                        ncu = quyentmp[j].Split(';');
                        if (ncu != null)
                        {
                            foreach (string items in ncu)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlncu.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý sản phẩm")
                    {
                        chkqlsp.Checked = true;
                        string[] sp;
                        sp = quyentmp[j].Split(';');
                        if (sp != null)
                        {
                            foreach (string items in sp)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlsp.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý hoá đơn")
                    {
                        chkqlhd.Checked = true;
                        string[] hd;
                        hd = quyentmp[j].Split(';');
                        if (hd != null)
                        {
                            foreach (string items in hd)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlhd.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Thống kê, báo cáo")
                    {
                        chktkbc.Checked = true;
                        string[] tk;
                        tk = quyentmp[j].Split(';');
                        if (tk != null)
                        {
                            foreach (string items in tk)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqltkbc.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản trị hệ thống (quản lý người dùng)")
                    {
                        chkQuantri.Checked = true;
                        string[] qt;
                        qt = quyentmp[j].Split(';');
                        if (qt != null)
                        {
                            foreach (string items in qt)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbquantri.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbquantri.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbquantri.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbquantri.SetItemChecked(3, true);
                                }
                            }
                        }
                    }

                }
                NGUOIDUNG_QH.manhomND = "";
                NGUOIDUNG_QH.xacnhan = false;
            }

            DANGKY dk = new DANGKY();
            if (DANGKY.xn == true)
            {
                string danhmuc, quyen = "";

                string sql = "select NHOM_QUYEN_HAN.DanhmucTC from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND = '" + DANGKY.manhomnd + "'";
                danhmuc = Ctrl.GetFieldValues(sql);

                sql = "select NHOM_QUYEN_HAN.QuyenDM from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND = '" + DANGKY.manhomnd + "'";
                quyen = Ctrl.GetFieldValues(sql);

                string[] danhmuctmp = danhmuc.Split('|');
                string[] quyentmp = quyen.Split('|');

                for (int j = 0; j < danhmuctmp.Length; ++j)
                {
                    if (danhmuctmp[j].Trim() == "Quản lý nhân viên")
                    {
                        chkqlnv.Checked = true;
                        string[] nv;
                        nv = quyentmp[j].Split(';');
                        if (nv != null)
                        {
                            foreach (string items in nv)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlnv.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý khách hàng")
                    {
                        chkqlkh.Checked = true;
                        string[] kh;
                        kh = quyentmp[j].Split(';');
                        if (kh != null)
                        {
                            foreach (string items in kh)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlkh.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý nhà cung ứng")
                    {
                        chkqlncu.Checked = true;
                        string[] ncu;
                        ncu = quyentmp[j].Split(';');
                        if (ncu != null)
                        {
                            foreach (string items in ncu)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlncu.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý sản phẩm")
                    {
                        chkqlsp.Checked = true;
                        string[] sp;
                        sp = quyentmp[j].Split(';');
                        if (sp != null)
                        {
                            foreach (string items in sp)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlsp.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý hoá đơn")
                    {
                        chkqlhd.Checked = true;
                        string[] hd;
                        hd = quyentmp[j].Split(';');
                        if (hd != null)
                        {
                            foreach (string items in hd)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlhd.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Thống kê, báo cáo")
                    {
                        chktkbc.Checked = true;
                        string[] tk;
                        tk = quyentmp[j].Split(';');
                        if (tk != null)
                        {
                            foreach (string items in tk)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqltkbc.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản trị hệ thống (quản lý người dùng)")
                    {
                        chkQuantri.Checked = true;
                        string[] qt;
                        qt = quyentmp[j].Split(';');
                        if (qt != null)
                        {
                            foreach (string items in qt)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbquantri.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbquantri.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbquantri.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbquantri.SetItemChecked(3, true);
                                }
                            }
                        }
                    }

                }
                DANGKY.manhomnd = "";
                DANGKY.xn = false;
            }

            MAIN xemq = new MAIN();
            if (MAIN.xemquyen == true)
            {
                string[] danhmuctmp = DANGNHAP.Danhmuc.Split('|');
                string[] quyentmp = DANGNHAP.Quyen.Split('|');

                for (int j = 0; j < danhmuctmp.Length; ++j)
                {
                    if (danhmuctmp[j].Trim() == "Quản lý nhân viên")
                    {
                        chkqlnv.Checked = true;
                        string[] nv;
                        nv = quyentmp[j].Split(';');
                        if (nv != null)
                        {
                            foreach (string items in nv)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlnv.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlnv.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý khách hàng")
                    {
                        chkqlkh.Checked = true;
                        string[] kh;
                        kh = quyentmp[j].Split(';');
                        if (kh != null)
                        {
                            foreach (string items in kh)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlkh.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlkh.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý nhà cung ứng")
                    {
                        chkqlncu.Checked = true;
                        string[] ncu;
                        ncu = quyentmp[j].Split(';');
                        if (ncu != null)
                        {
                            foreach (string items in ncu)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlncu.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlncu.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý sản phẩm")
                    {
                        chkqlsp.Checked = true;
                        string[] sp;
                        sp = quyentmp[j].Split(';');
                        if (sp != null)
                        {
                            foreach (string items in sp)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlsp.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlsp.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản lý hoá đơn")
                    {
                        chkqlhd.Checked = true;
                        string[] hd;
                        hd = quyentmp[j].Split(';');
                        if (hd != null)
                        {
                            foreach (string items in hd)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqlhd.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqlhd.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Thống kê, báo cáo")
                    {
                        chktkbc.Checked = true;
                        string[] tk;
                        tk = quyentmp[j].Split(';');
                        if (tk != null)
                        {
                            foreach (string items in tk)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbqltkbc.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbqltkbc.SetItemChecked(3, true);
                                }
                            }
                        }
                    }
                    else if (danhmuctmp[j].Trim() == "Quản trị hệ thống (quản lý người dùng)")
                    {
                        chkQuantri.Checked = true;
                        string[] qt;
                        qt = quyentmp[j].Split(';');
                        if (qt != null)
                        {
                            foreach (string items in qt)
                            {
                                if (items.Trim() == "Xem (đọc)")
                                {
                                    clbquantri.SetItemChecked(0, true);
                                }
                                if (items.Trim() == "Thêm (tạo) bản ghi")
                                {
                                    clbquantri.SetItemChecked(1, true);
                                }
                                if (items.Trim() == "Sửa (cập nhật) bản ghi")
                                {
                                    clbquantri.SetItemChecked(2, true);
                                }
                                if (items.Trim() == "Xoá (huỷ) bản ghi")
                                {
                                    clbquantri.SetItemChecked(3, true);
                                }
                            }
                        }
                    }

                }
                MAIN.xemquyen = false;
            }

            chkQuantri.Enabled = false;
            chkqlhd.Enabled = false;
            chkqlkh.Enabled = false;
            chkqlnv.Enabled = false;
            chkqlsp.Enabled = false;
            chktkbc.Enabled = false;
            chkqlncu.Enabled = false;

            clbqlhd.Enabled = false;
            clbqlkh.Enabled = false;
            clbqlnv.Enabled = false;
            clbqlsp.Enabled = false;
            clbqltkbc.Enabled = false;
            clbquantri.Enabled = false;
            clbqlncu.Enabled = false;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XEMQUYEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }
    }
}
