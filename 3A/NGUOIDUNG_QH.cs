using System;
using System.Data;
using System.Windows.Forms;

namespace _3A
{
    public partial class NGUOIDUNG_QH : Form
    {
        public NGUOIDUNG_QH()
        {
            InitializeComponent();
        }

        public DataTable nd;
        public static string manhomND = "";
        public static bool xacnhan = false;

        private void NGUOIDUNG_QH_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from NHOM_NGUOI_DUNG";
            Ctrl.FillCombo(sql, cbManhomnd, "IdNND", "IdNND");
            cbManhomnd.SelectedIndex = -1;
            sql = "SELECT * from NGUOI_DUNG";
            Ctrl.FillCombo(sql, cbtenND, "TenND", "TenND");
            cbtenND.SelectedIndex = -1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnxemquyen.Enabled = false;
            LoadDataGridViewnd();
        }

        public void LoadDataGridViewnd()
        {
            string sql;
            sql = "SELECT * from NGUOI_DUNG";
            nd = Ctrl.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvNguoidung.DataSource = nd;
            dgvNguoidung.AllowUserToAddRows = false;
            dgvNguoidung.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void ResetValuesnd()
        {
            txtMand.Text = "";
            cbManhomnd.Text = "";
            txtMaNV.Text = "";
            cbtenND.Text = "";
            txtTenTK.Text = "";
            txttennhomnd.Text = "";
            txttennhomqh.Text = "";
            dtpngaytaotk.Value = DateTime.Now;
            chkQuantri.Checked = false;
            chkqlhd.Checked = false;
            chkqlkh.Checked = false;
            chkqlnv.Checked = false;
            chkqlsp.Checked = false;
            chktkbc.Checked = false;
            chkqlncu.Checked = false;

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
            for (int i = 0; i < clbqlnv.Items.Count; ++i)
            {
                clbqlnv.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbqlkh.Items.Count; ++i)
            {
                clbqlkh.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbqlncu.Items.Count; ++i)
            {
                clbqlncu.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbqlsp.Items.Count; ++i)
            {
                clbqlsp.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbqlhd.Items.Count; ++i)
            {
                clbqlhd.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbqltkbc.Items.Count; ++i)
            {
                clbqltkbc.SetItemChecked(i, false);
            }
            for (int i = 0; i < clbquantri.Items.Count; ++i)
            {
                clbquantri.SetItemChecked(i, false);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
            string sql;
            if ((cbManhomnd.Text.Trim() == "") && (cbtenND.Text.Trim() == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //search on Nguoi_Dung table
            if (cbtenND.Text.Trim() != "" && cbManhomnd.Text.Trim() == "")
            {
                sql = "SELECT * from NGUOI_DUNG WHERE TenND=N'" + cbtenND.Text.Trim() + "'";
                nd = Ctrl.GetDataToTable(sql);
                if (nd.Rows.Count == 0)
                    lblkqtknd.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknd.Text = "Có " + nd.Rows.Count + " bản ghi được tìm thấy!";
                dgvNguoidung.DataSource = nd;
                ResetValuesnd();
                btnxemquyen.Enabled = false;
            }
            if (cbManhomnd.Text.Trim() != "" && cbtenND.Text.Trim() == "")
            {
                sql = "SELECT * from NGUOI_DUNG WHERE IdNND='" + cbManhomnd.Text.Trim() + "'";
                nd = Ctrl.GetDataToTable(sql);
                if (nd.Rows.Count == 0)
                    lblkqtknd.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknd.Text = "Có " + nd.Rows.Count + " bản ghi được tìm thấy!";
                dgvNguoidung.DataSource = nd;
                ResetValuesnd();
                btnxemquyen.Enabled = false;
            }
            if(cbManhomnd.Text.Trim() != "" && cbtenND.Text.Trim() != "")
            {
                sql = "SELECT * from NGUOI_DUNG WHERE IdNND='" + cbManhomnd.Text.Trim() + "' and TenND=N'"+cbtenND.Text.Trim()+"'";
                nd = Ctrl.GetDataToTable(sql);
                if (nd.Rows.Count == 0)
                    lblkqtknd.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknd.Text = "Có " + nd.Rows.Count + " bản ghi được tìm thấy!";
                dgvNguoidung.DataSource = nd;
                ResetValuesnd();
                btnxemquyen.Enabled = false;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM NGUOI_DUNG";
            nd = Ctrl.GetDataToTable(sql);
            dgvNguoidung.DataSource = nd;
            lblkqtknd.Text = "";
        }

        private void btnxoand_Click(object sender, EventArgs e)
        {
            string sql;
            if (nd.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMand.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xoá người dùng sẽ xoá tất cả các thông tin truy cập có liên quan với người dùng này. Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "select IdNV from NGUOI_DUNG where IdND ='" + dgvNguoidung.CurrentRow.Cells["IdND"].Value.ToString() + "'";
                string ma = Ctrl.GetFieldValues(sql);

                sql = "delete TRUY_CAP where IdND ='" + dgvNguoidung.CurrentRow.Cells["IdND"].Value.ToString() + "'";
                Ctrl.RunSqlDel(sql);

                //Tìm tên tài khoản trên bảng nhân viên để xoá tài
                sql = "select Taikhoan from NHAN_VIEN where IdNV ='" + dgvNguoidung.CurrentRow.Cells["IdNV"].Value.ToString() + "'";
                string taikhoan = Ctrl.GetFieldValues(sql), TK = "";
                string[] tk = taikhoan.Split(',');
                foreach(string items in tk)
                {
                    if (items.Trim().Length>6 && items.Trim() != txtTenTK.Text)
                    {
                        TK += items.Trim() + ", ";
                    }
                }
                sql = "update NHAN_VIEN set Taikhoan ='" + TK + "' where IdNV ='" + ma + "'";
                Ctrl.RunSQL(sql);

                sql = "DELETE NGUOI_DUNG WHERE IdND='" + dgvNguoidung.CurrentRow.Cells["IdND"].Value.ToString() + "'";
                Ctrl.RunSqlDel(sql);

                LoadDataGridViewnd();
                ResetValuesnd();
                DANGNHAP.thaotac += "Xoá, ";
            }

            sql = "SELECT * from NGUOI_DUNG";
            Ctrl.FillCombo(sql, cbtenND, "TenND", "TenND");
            cbtenND.SelectedIndex = -1;

            lblkqtknd.Text = "";
        }



        private void dgvNguoidung_Click(object sender, EventArgs e)
        {
            if (nd.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvNguoidung.CurrentRow.IsNewRow == true)
            {
                MessageBox.Show("Hãy chọn dòng có thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResetValuesnd();
            cbManhomnd.Text = dgvNguoidung.CurrentRow.Cells["IdNND"].Value.ToString();

            string sql = "";

            sql = "select TenNND from NHOM_NGUOI_DUNG where IdNND = '" + cbManhomnd.Text + "'";
            txttennhomnd.Text = Ctrl.GetFieldValues(sql);

            sql = "select NHOM_QUYEN_HAN.TenNQH from NHOM_NGUOI_DUNG, NHOM_QUYEN_HAN where NHOM_NGUOI_DUNG.IdNhomQH = NHOM_QUYEN_HAN.IdNQH and NHOM_NGUOI_DUNG.IdNND = '" + cbManhomnd.Text + "'";
            txttennhomqh.Text = Ctrl.GetFieldValues(sql);

            txtMand.Text = dgvNguoidung.CurrentRow.Cells["IdND"].Value.ToString();
            txtMaNV.Text = dgvNguoidung.CurrentRow.Cells["IdNV"].Value.ToString();
            cbtenND.Text = dgvNguoidung.CurrentRow.Cells["TenND"].Value.ToString();
            txtTenTK.Text = dgvNguoidung.CurrentRow.Cells["TenTK"].Value.ToString();
            dtpngaytaotk.Text = dgvNguoidung.CurrentRow.Cells["NgayTaoTK"].Value.ToString();
            string[] danhmuctmp = dgvNguoidung.CurrentRow.Cells["DanhmucTC"].Value.ToString().Split('|');
            string[] quyentmp = dgvNguoidung.CurrentRow.Cells["QuyenDM"].Value.ToString().Split('|');
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

            chkqlhd.Enabled = true;
            chkqlkh.Enabled = true;
            chkqlnv.Enabled = true;
            chkqlsp.Enabled = true;
            chkQuantri.Enabled = true;
            chktkbc.Enabled = true;
            chkqlncu.Enabled = true;

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnxemquyen.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbManhomnd.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhóm người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbManhomnd.Focus();
                return;
            }
            else
            {
                //kiểm tra nhóm người dùng có tồn tại không
                bool kt = false;
                for (int i = 0; i < cbManhomnd.Items.Count; ++i)
                {
                    if (cbManhomnd.Text.Trim() == cbManhomnd.GetItemText(cbManhomnd.Items[i]))
                    {
                        kt = true;
                        break;
                    }
                    else
                    {
                        kt = false;
                    }
                }
                if (kt == false)
                {
                    MessageBox.Show("Mã nhóm người dùng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbManhomnd.Focus();
                    return;
                }
                else
                {
                    if (chkqlhd.Checked == false && chkqlkh.Checked == false && chkqlnv.Checked == false && chkqlsp.Checked == false && chkQuantri.Checked == false && chktkbc.Checked == false && chkqlncu.Checked == false)
                    {
                        MessageBox.Show("Bạn chưa chọn danh mục quản lý nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string danhmuc = "", quyen = "";

                    if (chkqlnv.Checked == true)
                    {
                        danhmuc = chkqlnv.Text.Substring(0, chkqlnv.Text.Length - 1);
                        if (!clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản lý nhân viên'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc)";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Thêm (tạo) bản ghi";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Sửa (cập nhật) bản ghi";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            //cho 2 quyen
                            if (clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Thêm (tạo) bản ghi";
                                goto Label1;
                            }
                            if (clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Sửa (cập nhật) bản ghi";
                                goto Label1;
                            }
                            if (clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            //chon 3 quyen
                            if (clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label1;
                            }
                            if (clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            if (!clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            if (clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                            //chon 4 quyen
                            if (clbqlnv.GetItemChecked(0) && clbqlnv.GetItemChecked(1) && clbqlnv.GetItemChecked(2) && clbqlnv.GetItemChecked(3))
                            {
                                quyen = "Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label1;
                            }
                        }
                    }
                    Label1:
                    if (chkqlkh.Checked == true)
                    {
                        danhmuc += " | " + chkqlkh.Text.Substring(0, chkqlkh.Text.Length - 1);
                        if (!clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản lý khách hàng'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc)";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            //cho 2 quyen
                            if (clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi";
                                goto Label2;
                            }
                            if (clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi";
                                goto Label2;
                            }
                            if (clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            //chon 3 quyen
                            if (clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && !clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label2;
                            }
                            if (clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && !clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            if (!clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            if (clbqlkh.GetItemChecked(0) && !clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                            //chon 4 quyen
                            if (clbqlkh.GetItemChecked(0) && clbqlkh.GetItemChecked(1) && clbqlkh.GetItemChecked(2) && clbqlkh.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label2;
                            }
                        }
                    }
                    Label2:
                    if (chkqlsp.Checked == true)
                    {
                        danhmuc += " | " + chkqlsp.Text.Substring(0, chkqlsp.Text.Length - 1);
                        if (!clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản lý sản phẩm'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc)";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            //cho 2 quyen
                            if (clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi";
                                goto Label3;
                            }
                            if (clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi";
                                goto Label3;
                            }
                            if (clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            //chon 3 quyen
                            if (clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && !clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label3;
                            }
                            if (clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && !clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            if (!clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            if (clbqlsp.GetItemChecked(0) && !clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                            //chon 4 quyen
                            if (clbqlsp.GetItemChecked(0) && clbqlsp.GetItemChecked(1) && clbqlsp.GetItemChecked(2) && clbqlsp.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label3;
                            }
                        }
                    }
                    Label3:
                    if (chkqlhd.Checked == true)
                    {
                        danhmuc += " | " + chkqlhd.Text.Substring(0, chkqlhd.Text.Length - 1);
                        if (!clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản lý hoá đơn'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc)";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            //cho 2 quyen
                            if (clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi";
                                goto Label4;
                            }
                            if (clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi";
                                goto Label4;
                            }
                            if (clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            //chon 3 quyen
                            if (clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && !clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label4;
                            }
                            if (clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && !clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            if (!clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            if (clbqlhd.GetItemChecked(0) && !clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                            //chon 4 quyen
                            if (clbqlhd.GetItemChecked(0) && clbqlhd.GetItemChecked(1) && clbqlhd.GetItemChecked(2) && clbqlhd.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label4;
                            }
                        }
                    }
                    Label4:
                    if (chktkbc.Checked == true)
                    {
                        danhmuc += " | " + chktkbc.Text.Substring(0, chktkbc.Text.Length - 1);
                        if (!clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Thống kê, báo cáo'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc)";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                            //cho 2 quyen
                            if (clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi";
                                goto Label5;
                            }
                            if (clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi";
                                goto Label5;
                            }
                            if (clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label5;
                            }

                            //chon 3 quyen
                            if (clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && !clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label5;
                            }
                            if (clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && !clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                            if (!clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                            if (clbqltkbc.GetItemChecked(0) && !clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                            //chon 4 quyen
                            if (clbqltkbc.GetItemChecked(0) && clbqltkbc.GetItemChecked(1) && clbqltkbc.GetItemChecked(2) && clbqltkbc.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label5;
                            }
                        }
                    }
                    Label5:
                    if (chkQuantri.Checked == true)
                    {
                        danhmuc += " | " + chkQuantri.Text.Substring(0, chkQuantri.Text.Length - 1);
                        if (!clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản trị hệ thống (quản lý người dùng)'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc)";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            //cho 2 quyen
                            if (clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi";
                                goto Label6;
                            }
                            if (clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi";
                                goto Label6;
                            }
                            if (clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            //chon 3 quyen
                            if (clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && !clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                                goto Label6;
                            }
                            if (clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && !clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            if (!clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            if (clbquantri.GetItemChecked(0) && !clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                            //chon 4 quyen
                            if (clbquantri.GetItemChecked(0) && clbquantri.GetItemChecked(1) && clbquantri.GetItemChecked(2) && clbquantri.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                                goto Label6;
                            }
                        }
                    }
                    Label6:
                    if (chkqlncu.Checked == true)
                    {
                        danhmuc += " | " + chkqlncu.Text.Substring(0, chkqlncu.Text.Length - 1);
                        if (!clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                        {
                            MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản lý nhà cung ứng'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //chon 1 quyen
                            if (clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc)";
                            }
                            if (!clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi";
                            }
                            if (!clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi";
                            }
                            if (!clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xoá (huỷ) bản ghi";
                            }
                            //cho 2 quyen
                            if (clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi";
                            }
                            if (clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi";
                            }
                            if (clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Xoá (huỷ) bản ghi";
                            }
                            if (!clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                            }
                            if (!clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                            }
                            if (!clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                            }
                            //chon 3 quyen
                            if (clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && !clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi";
                            }
                            if (clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && !clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Xoá (huỷ) bản ghi";
                            }
                            if (!clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                            }
                            if (clbqlncu.GetItemChecked(0) && !clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                            }
                            //chon 4 quyen
                            if (clbqlncu.GetItemChecked(0) && clbqlncu.GetItemChecked(1) && clbqlncu.GetItemChecked(2) && clbqlncu.GetItemChecked(3))
                            {
                                quyen += " | Xem (đọc); Thêm (tạo) bản ghi; Sửa (cập nhật) bản ghi; Xoá (huỷ) bản ghi";
                            }
                        }
                    }

                    sql = "select IdNND from NGUOI_DUNG where IdND = '" + txtMand.Text + "'";
                    string manhomnd = Ctrl.GetFieldValues(sql);
                    if (manhomnd != cbManhomnd.Text.Trim())
                    {
                        if (MessageBox.Show("Nếu thay đổi nhóm người dùng của người dùng hiện tại thì tất cả các quyền của người dùng hiện tại sẽ bị huỷ. Bạn có muốn tiếp tục không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            sql = "select NHOM_QUYEN_HAN.DanhmucTC from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_NGUOI_DUNG.IdNhomQH = NHOM_QUYEN_HAN.IdNQH and IdNND = '" + cbManhomnd.Text.Trim() + "'";
                            string danhmuctmp = Ctrl.GetFieldValues(sql);

                            sql = "select NHOM_QUYEN_HAN.QuyenDM from NHOM_QUYEN_HAN, NHOM_NGUOI_DUNG where NHOM_NGUOI_DUNG.IdNhomQH = NHOM_QUYEN_HAN.IdNQH and IdNND = '" + cbManhomnd.Text.Trim() + "'";
                            string quyentmp = Ctrl.GetFieldValues(sql);

                            sql = "UPDATE NGUOI_DUNG SET IdNND='" + cbManhomnd.Text.Trim() + "',DanhmucTC = N'" + danhmuctmp + "',QuyenDM = N'" + quyentmp + "' WHERE IdND='" + txtMand.Text + "'";
                            Ctrl.RunSQL(sql);
                            LoadDataGridViewnd();
                            ResetValuesnd();
                            btnsua.Enabled = false;
                            btnxoa.Enabled = false;
                            btnxemquyen.Enabled = false;
                            lblkqtknd.Text = "";
                            DANGNHAP.thaotac += "Sửa, ";
                        }
                    }
                    else
                    {
                        sql = "UPDATE NGUOI_DUNG SET IdNND='" + cbManhomnd.Text.Trim() + "',DanhmucTC = N'" + danhmuc + "',QuyenDM = N'" + quyen + "' WHERE IdND='" + txtMand.Text + "'";
                        Ctrl.RunSQL(sql);
                        LoadDataGridViewnd();
                        ResetValuesnd();
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;
                        btnxemquyen.Enabled = false;
                        lblkqtknd.Text = "";
                        DANGNHAP.thaotac += "Sửa, ";
                    }
                }
            }
        }

        private void btnxemquyen_Click(object sender, EventArgs e)
        {
            xacnhan = true;
            manhomND = cbManhomnd.Text;
            XEMQUYEN xq = new XEMQUYEN();
            xq.ShowDialog();
        }

        private void cbManhomnd_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbManhomnd.Text.Trim() == "")
            {
                txttennhomnd.Text = "";
                txttennhomqh.Text = "";
                btnxemquyen.Enabled = false;
            }
            else
            {
                // Khi chọn mã nhóm người dùng thì tên nhóm người dùng và tên nhóm quyền hạn hiện ra
                if (cbManhomnd.Items.Count > 0)
                {
                    for (int i = 0; i < cbManhomnd.Items.Count; ++i)
                    {
                        if (cbManhomnd.Text.Trim() == cbManhomnd.GetItemText(cbManhomnd.Items[i]))
                        {
                            str = "SELECT TenNND FROM NHOM_NGUOI_DUNG WHERE IdNND ='" + cbManhomnd.GetItemText(cbManhomnd.Items[i]) + "'";
                            txttennhomnd.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT NHOM_QUYEN_HAN.TenNQH FROM NHOM_NGUOI_DUNG, NHOM_QUYEN_HAN WHERE NHOM_QUYEN_HAN.IdNQH = NHOM_NGUOI_DUNG.IdNhomQH and IdNND ='" + cbManhomnd.GetItemText(cbManhomnd.Items[i]) + "'";
                            txttennhomqh.Text = Ctrl.GetFieldValues(str);

                            btnxemquyen.Enabled = true;
                            break;
                        }
                        else
                        {
                            txttennhomnd.Text = "";
                            txttennhomqh.Text = "";
                            btnxemquyen.Enabled = false;
                        }
                    }

                }
            }
        }

        private void txttennhomnd_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.ToolTipIcon = ToolTipIcon.Info;
            tt.ToolTipTitle = "Tên nhóm người dùng: ";
            tt.SetToolTip(txttennhomnd, txttennhomnd.Text);
        }

        private void txttennhomqh_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.ToolTipIcon = ToolTipIcon.Info;
            tt.ToolTipTitle = "Tên nhóm quyền hạn: ";
            tt.SetToolTip(txttennhomqh, txttennhomqh.Text);
        }

        private void chkqlnv_CheckedChanged(object sender, EventArgs e)
        {
            if (chkqlnv.Checked == true)
            {
                clbqlnv.Enabled = true;
            }
            else
            {
                clbqlnv.Enabled = false;
            }
        }

        private void chkqlkh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkqlkh.Checked == true)
            {
                clbqlkh.Enabled = true;
            }
            else
            {
                clbqlkh.Enabled = false;
            }
        }

        private void chkqlsp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkqlsp.Checked == true)
            {
                clbqlsp.Enabled = true;
            }
            else
            {
                clbqlsp.Enabled = false;
            }
        }

        private void chkqlhd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkqlhd.Checked == true)
            {
                clbqlhd.Enabled = true;
            }
            else
            {
                clbqlhd.Enabled = false;
            }
        }

        private void chktkbc_CheckedChanged(object sender, EventArgs e)
        {
            if (chktkbc.Checked == true)
            {
                clbqltkbc.Enabled = true;
            }
            else
            {
                clbqltkbc.Enabled = false;
            }
        }

        private void chkQuantri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQuantri.Checked == true)
            {
                clbquantri.Enabled = true;
            }
            else
            {
                clbquantri.Enabled = false;
            }
        }

        private void cbtenND_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbtenND.Text == "")
            {
                ResetValuesnd();
            }
            else
            {
                // Khi chọn mã nhóm người dùng thì tên nhóm người dùng và tên nhóm quyền hạn hiện ra
                if (cbtenND.Items.Count > 0)
                {
                    for (int i = 0; i < cbtenND.Items.Count; ++i)
                    {
                        if (cbtenND.Text.Trim() == cbtenND.GetItemText(cbtenND.Items[i]))
                        {
                            ResetValuesnd();
                            str = "SELECT IdND FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            txtMand.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT IdNND FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            cbManhomnd.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT IdNV FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            txtMaNV.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT TenND FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            cbtenND.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT TenTK FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            txtTenTK.Text = Ctrl.GetFieldValues(str);

                            //gọi lại sự kiện cbManhomnd_TextChanged
                            cbManhomnd_TextChanged(sender, e);

                            str = "SELECT NgayTaoTK FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            dtpngaytaotk.Text = Ctrl.GetFieldValues(str);

                            str = "SELECT DanhmucTC FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            string danhmuc = Ctrl.GetFieldValues(str);

                            str = "SELECT QuyenDM FROM NGUOI_DUNG WHERE TenND =N'" + cbtenND.GetItemText(cbtenND.Items[i]) + "'";
                            string quyendm = Ctrl.GetFieldValues(str);

                            string[] danhmuctmp = danhmuc.Split('|');
                            string[] quyentmp = quyendm.Split('|');

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
                            chkqlhd.Enabled = true;
                            chkqlkh.Enabled = true;
                            chkqlnv.Enabled = true;
                            chkqlsp.Enabled = true;
                            chkQuantri.Enabled = true;
                            chktkbc.Enabled = true;

                            break;
                        }
                        else
                        {
                            txtMand.Text = "";
                            cbManhomnd.Text = "";
                            cbManhomnd_TextChanged(sender, e);
                            txtMaNV.Text = "";
                            txtTenTK.Text = "";
                            dtpngaytaotk.Value = DateTime.Now;

                            chkqlhd.Enabled = true;
                            chkqlkh.Enabled = true;
                            chkqlnv.Enabled = true;
                            chkqlsp.Enabled = true;
                            chkQuantri.Enabled = true;
                            chktkbc.Enabled = true;

                            chkqlhd.Checked = false;
                            chkqlkh.Checked = false;
                            chkqlnv.Checked = false;
                            chkqlsp.Checked = false;
                            chkQuantri.Checked = false;
                            chktkbc.Checked = false;

                        }
                    }

                }
            }
        }

        private void chkqlncu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkqlncu.Checked == true)
            {
                clbqlncu.Enabled = true;
            }
            else
            {
                clbqlncu.Enabled = false;
            }
        }

        private void NGUOIDUNG_QH_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }
    }
}
