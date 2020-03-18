using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _3A
{
    public partial class NHOMND_NHOMQH : Form
    {
        public NHOMND_NHOMQH()
        {
            InitializeComponent();
        }

        private DataTable nnd, nqh;

        private void NHOMND_NHOMND_Load(object sender, EventArgs e)
        {
            string[] tennnd = { "Nhóm người dùng là nhân viên quản trị", "Nhóm người dùng là nhân viên kế toán", "Nhóm người dùng là nhân viên bán hàng", "Nhóm người dùng là nhân viên thủ kho" };
            cbTennhomnd.Items.AddRange(tennnd);
            string[] tennqh = { "Nhóm nhân viên quản trị", "Nhóm nhân viên kế toán", "Nhóm nhân viên bán hàng", "Nhóm nhân viên thủ kho" };
            cbtennhomqh.Items.AddRange(tennqh);
            string sql;
            sql = "SELECT * from NHOM_QUYEN_HAN";
            Ctrl.FillCombo(sql, cbmanhomqh, "IdNQH", "IdNQH");
            cbmanhomqh.SelectedIndex = -1;
            btnluunhomnd.Enabled = false;
            btnluunhomqh.Enabled = false;
            btnHuy.Enabled = false;
            LoadDataGridViewnnd();
            LoadDataGridViewnqh();
        }

        public void LoadDataGridViewnnd()
        {
            string sql;
            sql = "SELECT * from NHOM_NGUOI_DUNG";
            nnd = Ctrl.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvNhomND.DataSource = nnd;
            dgvNhomND.AllowUserToAddRows = false;
            dgvNhomND.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void LoadDataGridViewnqh()
        {
            string sql;
            sql = "SELECT * from NHOM_QUYEN_HAN";
            nqh = Ctrl.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvNhomQH.DataSource = nqh;
            dgvNhomQH.AllowUserToAddRows = false;
            dgvNhomQH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void ResetValuesnnd()
        {
            txtManhomnd.Text = "";
            txtmotanhomnd.Text = "";
            cbTennhomnd.Text = "";
            cbmanhomqh.Text = "";
            txttennhomqh.Text = "";
        }

        public void ResetValuesnqh()
        {
            txtmanhomqh.Text = "";
            txtmotanhomqh.Text = "";
            cbtennhomqh.Text = "";
            chkqlhd.Enabled = false;
            chkqlhd.Checked = false;
            chkqlkh.Enabled = false;
            chkqlkh.Checked = false;
            chkqlncu.Enabled = false;
            chkqlncu.Checked = false;
            chkqlnv.Enabled = false;
            chkqlnv.Checked = false;
            chkqlsp.Enabled = false;
            chkqlsp.Checked = false;
            chkQuantri.Enabled = false;
            chkQuantri.Checked = false;
            chktkbc.Enabled = false;
            chktkbc.Checked = false;
            clbqlhd.Enabled = false;
            clbqlncu.Enabled = false;
            clbqlkh.Enabled = false;
            clbqlnv.Enabled = false;
            clbqlsp.Enabled = false;
            clbqltkbc.Enabled = false;
            clbquantri.Enabled = false;
            for (int i=0; i < clbqlnv.Items.Count; ++i)
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

        private void btnthemnhomnd_Click(object sender, EventArgs e)
        {
            btnsuanhomnd.Enabled = false;
            btnxoanhomnd.Enabled = false;
            btnHuy.Enabled = true;
            btnluunhomnd.Enabled = true;
            btnthemnhomnd.Enabled = false;
            ResetValuesnnd();
            cbTennhomnd.Focus();
            lblkqtknhomnd.Text = "";
            cbmanhomqh.Text = "";
            //tạo mã ngẫu nhiên
            int gt;
            bool kt = false;
            string sql = "";
            Random rand = new Random();
            sql = "select * from NHOM_NGUOI_DUNG";
            gt = rand.Next(100000000, 999999999);
            string manhomnd = "NND" + gt;
            DataRow dr;
            if (Ctrl.GetDataToTable(sql).Rows.Count != 0)
            {
                while (kt == false)
                {
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        dr = Ctrl.GetDataToTable(sql).Rows[i];
                        if (manhomnd == dr["IdNND"].ToString())
                        {
                            kt = false;
                            gt = rand.Next(100000000, 999999999);
                            manhomnd = "NND" + gt;
                            break;
                        }
                        else
                        {
                            kt = true;
                        }
                    }
                }
                txtManhomnd.Text = manhomnd;
            }
            else
            {
                txtManhomnd.Text = manhomnd;
            }
        }

        private void btnsuanhomnd_Click(object sender, EventArgs e)
        {
            string sql;
            if (nnd.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhomnd.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //if (cbTennhomnd.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập tên nhóm người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cbTennhomnd.Focus();
            //    return;
            //}
            //else
            //{
            //    if (cbTennhomnd.Text.Trim() != dgvNhomND.CurrentRow.Cells["TenNND"].Value.ToString())
            //    {
            //        //kiểm tra tên nhóm người dùng có trùng lặp không
            //        bool kt = false;
            //        for (int i = 0; i < cbTennhomnd.Items.Count; ++i)
            //        {
            //            if (cbTennhomnd.Text.Trim() == cbTennhomnd.GetItemText(cbTennhomnd.Items[i]) && cbTennhomnd.Text.Trim() != dgvNhomND.CurrentRow.Cells["TenNND"].Value.ToString())
            //            {
            //                kt = true;
            //                break;
            //            }
            //            else
            //            {
            //                kt = false;
            //            }
            //        }
            //        if (kt == true)
            //        {
            //            MessageBox.Show("Tên nhóm người dùng này đã có. Hãy nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            cbTennhomnd.Focus();
            //            return;
            //        }
            //    }
            //}
            if (cbmanhomqh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm quyền hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmanhomqh.Focus();
                return;
            }
            else
            {
                //kiểm tra nhóm quyền hạn có tồn tại không
                bool kt = false;
                for (int i = 0; i < cbmanhomqh.Items.Count; ++i)
                {
                    if (cbmanhomqh.Text.Trim() == cbmanhomqh.GetItemText(cbmanhomqh.Items[i]))
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
                    MessageBox.Show("Mã nhóm quyền hạn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmanhomqh.Focus();
                    return;
                }
            }

            sql = "UPDATE NHOM_NGUOI_DUNG SET IdNhomQH = '" + cbmanhomqh.Text.Trim() + "',MoTaNND=N'" + txtmotanhomnd.Text.Trim() + "' WHERE IdNND='" + txtManhomnd.Text + "'";
            Ctrl.RunSQL(sql);
            LoadDataGridViewnnd();
            ResetValuesnnd();

            DANGNHAP.thaotac += "Sửa nhóm người dùng, ";
            btnHuy.Enabled = false;
            lblkqtknhomqh.Text = "";
            lblkqtknhomnd.Text = "";

        }

        private void btnluunhomnd_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbTennhomnd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTennhomnd.Focus();
                return;
            }
            else
            {
                //kiểm tra tên nhóm người dùng có trùng lặp không
                sql = "select * from NHOM_NGUOI_DUNG";
                DataRow dr;
                string tennnd;
                bool kt = false;
                for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                {
                    dr = Ctrl.GetDataToTable(sql).Rows[i];
                    tennnd = dr["TenNND"].ToString();
                    if (tennnd == cbTennhomnd.Text.Trim())
                    {
                        kt = true;
                        break;
                    }
                    else
                    {
                        kt = false;
                    }
                }
                if (kt == true)
                {
                    MessageBox.Show("Tên nhóm người dùng này đã có. Hãy nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbTennhomnd.Focus();
                    return;
                }
                //kiểm tra tên nhóm người dùng có nhập dúng không.
                bool kttennnd = false;
                for (int i = 0; i < cbTennhomnd.Items.Count; ++i)
                {
                    if (cbTennhomnd.Text.Trim() == cbTennhomnd.GetItemText(cbTennhomnd.Items[i]))
                    {
                        kttennnd = true;
                        break;
                    }
                    else
                    {
                        kttennnd = false;
                    }
                }
                if (kttennnd == false)
                {
                    MessageBox.Show("Tên nhóm người dùng không đúng. Tên nhóm bao gồm: 'Nhóm người dùng là nhân viên quản trị', 'Nhóm người dùng là nhân viên kế toán', 'Nhóm nhân người dùng là nhân viên bán hàng', 'Nhóm nhân người dùng là viên thủ kho'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbtennhomqh.Focus();
                    return;
                }
            }
            if (cbmanhomqh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm quyền hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmanhomqh.Focus();
                return;
            }
            else
            {
                //kiểm tra nhóm quyền hạn có tồn tại không
                bool kt = false;
                for (int i = 0; i < cbmanhomqh.Items.Count; ++i)
                {
                    if (cbmanhomqh.Text.Trim() == cbmanhomqh.GetItemText(cbmanhomqh.Items[i]))
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
                    MessageBox.Show("Mã nhóm quyền hạn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmanhomqh.Focus();
                    return;
                }
            }

            //Chèn thêm
            sql = "INSERT INTO NHOM_NGUOI_DUNG VALUES ('" + txtManhomnd.Text + "','" + cbmanhomqh.Text.Trim() + "',N'" + cbTennhomnd.Text.Trim() + "',N'" + txtmotanhomnd.Text.Trim() + "')";
            Ctrl.RunSQL(sql);
            LoadDataGridViewnnd();
            ResetValuesnnd();

            DANGNHAP.thaotac += "Thêm nhóm người dùng, ";

            btnxoanhomqh.Enabled = true;
            btnthemnhomnd.Enabled = true;
            btnsuanhomnd.Enabled = true;
            btnHuy.Enabled = false;
            btnluunhomnd.Enabled = false;
            lblkqtknhomqh.Text = "";
            lblkqtknhomnd.Text = "";

        }

        private void btnthemnhomqh_Click(object sender, EventArgs e)
        {
            btnsuanhomqh.Enabled = false;
            btnluunhomqh.Enabled = true;
            btnxoanhomqh.Enabled = false;
            btnHuy.Enabled = true;
            btnthemnhomqh.Enabled = false;
            ResetValuesnqh();
            cbtennhomqh.Focus();

            chkqlhd.Enabled = true;
            chkqlkh.Enabled = true;
            chkqlnv.Enabled = true;
            chkqlsp.Enabled = true;
            chkQuantri.Enabled = true;
            chktkbc.Enabled = true;
            chkqlncu.Enabled = true;

            lblkqtknhomqh.Text = "";
            //tạo mã ngẫu nhiên
            int gt;
            bool kt = false;
            string sql = "";
            Random rand = new Random();
            sql = "select * from NHOM_QUYEN_HAN";
            gt = rand.Next(100000000, 999999999);
            string manhomqh = "NQH" + gt;
            DataRow dr;
            if (Ctrl.GetDataToTable(sql) != null)
            {
                while (kt == false)
                {
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        dr = Ctrl.GetDataToTable(sql).Rows[i];
                        if (manhomqh == dr["IdNQH"].ToString())
                        {
                            kt = false;
                            gt = rand.Next(100000000, 999999999);
                            manhomqh = "NQH" + gt;
                            break;
                        }
                        else
                        {
                            kt = true;
                        }
                    }
                }
                txtmanhomqh.Text = manhomqh;
            }
            else
            {
                txtmanhomqh.Text = manhomqh;
            }
        }

        private void btnsuanhomqh_Click(object sender, EventArgs e)
        {
            string sql;
            if (nqh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhomqh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //if (cbtennhomqh.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập tên nhóm quyền hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cbtennhomqh.Focus();
            //    return;
            //}
            //else
            //{
            //    //kiểm tra tên nhóm quyền hạn có trùng lặp không
            //    if (cbtennhomqh.Text.Trim() != dgvNhomQH.CurrentRow.Cells["TenNQH"].Value.ToString())
            //    {
            //        bool kt = false;
            //        for (int i = 0; i < cbtennhomqh.Items.Count; ++i)
            //        {
            //            if (cbtennhomqh.Text.Trim() == cbtennhomqh.GetItemText(cbtennhomqh.Items[i]) && cbtennhomqh.Text.Trim() != dgvNhomQH.CurrentRow.Cells["TenNQH"].Value.ToString())
            //            {
            //                kt = true;
            //                break;
            //            }
            //            else
            //            {
            //                kt = false;
            //            }
            //        }
            //        if (kt == true)
            //        {
            //            MessageBox.Show("Tên nhóm quyền hạn này đã có. Hãy nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            cbtennhomqh.Focus();
            //            return;
            //        }
            //    }
            //}
            if (chkqlhd.Checked == false && chkqlkh.Checked == false && chkqlnv.Checked == false && chkqlsp.Checked == false && chkQuantri.Checked == false && chktkbc.Checked == false && chkqlncu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn danh mục quản lý nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string danhmuc = "", quyen = "";
            if (chkqlnv.Checked == true)
            {
                danhmuc = chkqlnv.Text.Substring(0, chkqlnv.Text.Length - 1);
                if(!clbqlnv.GetItemChecked(0)&& !clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
                {
                    MessageBox.Show("Bạn chưa xác nhận quyền hạn đối với danh mục 'Quản lý nhân viên'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //chon 1 quyen
                    if(clbqlnv.GetItemChecked(0) && !clbqlnv.GetItemChecked(1) && !clbqlnv.GetItemChecked(2) && !clbqlnv.GetItemChecked(3))
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
                        goto Label3 ;
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
                        goto Label4 ;
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

            sql = "UPDATE NHOM_QUYEN_HAN SET MoTa=N'" + txtmotanhomqh.Text.Trim() + "',DanhmucTC=N'" + danhmuc + "',QuyenDM=N'" + quyen + "' WHERE IdNQH='" + txtmanhomqh.Text + "'";
            Ctrl.RunSQL(sql);
            LoadDataGridViewnqh();
            ResetValuesnqh();

            btnHuy.Enabled = false;
            lblkqtknhomqh.Text = "";
            lblkqtknhomnd.Text = "";

            DANGNHAP.thaotac += "Sửa nhóm quyền hạn, ";
        }

        private void btnluunhomqh_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbtennhomqh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm quyền hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbtennhomqh.Focus();
                return;
            }
            else
            {
                sql = "select * from NHOM_QUYEN_HAN";
                DataRow dr;
                string tennqh;
                //kiểm tra tên nhóm quyền hạn có trùng lặp không
                bool kt = false;
                for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                {
                    dr = Ctrl.GetDataToTable(sql).Rows[i];
                    tennqh = dr["TenNQH"].ToString();
                    if (tennqh == cbtennhomqh.Text.Trim())
                    {
                        kt = true;
                        break;
                    }
                    else
                    {
                        kt = false;
                    }
                }
                if (kt == true)
                {
                    MessageBox.Show("Tên nhóm quyền hạn này đã có. Hãy nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbtennhomqh.Focus();
                    return;
                }
                //kiểm tra tên nhóm quyền hạn có nhập dúng không.
                bool kttennqh = false;
                for(int i = 0; i < cbtennhomqh.Items.Count; ++i)
                {
                    if (cbtennhomqh.Text.Trim() == cbtennhomqh.GetItemText(cbtennhomqh.Items[i]))
                    {
                        kttennqh = true;
                        break;
                    }
                    else
                    {
                        kttennqh = false;
                    }
                }
                if (kttennqh == false)
                {
                    MessageBox.Show("Tên nhóm quyền hạn không đúng. Tên nhóm bao gồm: 'Nhóm nhân viên quản trị', 'Nhóm nhân viên kế toán', 'Nhóm nhân viên bán hàng', 'Nhóm nhân viên thủ kho'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbtennhomqh.Focus();
                    return;
                }
            }
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
            //Chèn thêm
            sql = "INSERT INTO NHOM_QUYEN_HAN VALUES ('" + txtmanhomqh.Text + "',N'" + cbtennhomqh.Text.Trim() + "',N'" + txtmotanhomqh.Text.Trim() + "',N'" + danhmuc + "',N'" + quyen + "')";
            Ctrl.RunSQL(sql);
            LoadDataGridViewnqh();
            ResetValuesnqh();


            sql = "SELECT * from NHOM_QUYEN_HAN";
            Ctrl.FillCombo(sql, cbmanhomqh, "IdNQH", "IdNQH");
            cbmanhomqh.SelectedIndex = -1;

            DANGNHAP.thaotac += "Thêm nhóm quyền hạn, ";

            btnxoanhomqh.Enabled = true;
            btnthemnhomqh.Enabled = true;
            btnsuanhomqh.Enabled = true;
            btnHuy.Enabled = false;
            btnluunhomqh.Enabled = false;

            lblkqtknhomqh.Text = "";
            lblkqtknhomnd.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
            string sql;
            if (cbTennhomnd.Text.Trim() == "" && cbtennhomqh.Text.Trim() == "" && cbmanhomqh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTennhomnd.Text.Trim() != "" && cbmanhomqh.Text.Trim() == "")
            {
                sql = "SELECT * from NHOM_NGUOI_DUNG WHERE TenNND= N'" + cbTennhomnd.Text.Trim() + "'";
                nnd = Ctrl.GetDataToTable(sql);
                if (nnd.Rows.Count == 0)
                    lblkqtknhomnd.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknhomnd.Text = "Có " + nnd.Rows.Count + " bản ghi được tìm thấy!";
                dgvNhomND.DataSource = nnd;
                ResetValuesnnd();
            }
            if (cbtennhomqh.Text.Trim() != "")
            {
                sql = "SELECT * from NHOM_QUYEN_HAN WHERE TenNQH= N'" + cbtennhomqh.Text.Trim() + "'";
                nqh = Ctrl.GetDataToTable(sql);
                if (nqh.Rows.Count == 0)
                    lblkqtknhomqh.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknhomqh.Text = "Có " + nqh.Rows.Count + " bản ghi được tìm thấy!";
                dgvNhomQH.DataSource = nqh;
                ResetValuesnqh();
            }
            if (cbmanhomqh.Text.Trim() != "" && cbTennhomnd.Text.Trim() == "")
            {
                sql = "SELECT * from NHOM_NGUOI_DUNG WHERE IdNhomQH='" + cbmanhomqh.Text.Trim() + "'";
                nnd = Ctrl.GetDataToTable(sql);
                if (nnd.Rows.Count == 0)
                    lblkqtknhomnd.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknhomnd.Text = "Có " + nnd.Rows.Count + " bản ghi được tìm thấy!";
                dgvNhomND.DataSource = nnd;
                ResetValuesnnd();
            }

            if (cbmanhomqh.Text.Trim() != "" && cbTennhomnd.Text.Trim() != "")
            {
                string manqh = "", tennnd = "";
                for(int i = 0; i < cbmanhomqh.Items.Count; ++i)
                {
                    if (cbmanhomqh.Text.Trim() == cbmanhomqh.GetItemText(cbmanhomqh.Items[i]))
                    {
                        manqh = cbmanhomqh.GetItemText(cbmanhomqh.Items[i]);
                        break;
                    }
                }
                for (int i = 0; i < cbTennhomnd.Items.Count; ++i)
                {
                    if (cbTennhomnd.Text.Trim() == cbTennhomnd.GetItemText(cbTennhomnd.Items[i]))
                    {
                        tennnd = cbTennhomnd.GetItemText(cbTennhomnd.Items[i]);
                        break;
                    }
                }
                sql = "SELECT * from NHOM_NGUOI_DUNG WHERE NHOM_NGUOI_DUNG.IdNhomQH='" + manqh + "' and NHOM_NGUOI_DUNG.TenNND = N'" + tennnd + "'";
                nnd = Ctrl.GetDataToTable(sql);
                if (nnd.Rows.Count == 0)
                    lblkqtknhomnd.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtknhomnd.Text = "Có " + nnd.Rows.Count + " bản ghi được tìm thấy!";
                dgvNhomND.DataSource = nnd;
                ResetValuesnnd();
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM NHOM_NGUOI_DUNG";
            nnd = Ctrl.GetDataToTable(sql);
            dgvNhomND.DataSource = nnd;
            ResetValuesnnd();
            sql = "SELECT * FROM NHOM_QUYEN_HAN";
            nqh = Ctrl.GetDataToTable(sql);
            dgvNhomQH.DataSource = nqh;
            ResetValuesnqh();
            lblkqtknhomqh.Text = "";
            lblkqtknhomnd.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValuesnnd();
            ResetValuesnqh();
            btnHuy.Enabled = false;

            btnthemnhomnd.Enabled = true;
            btnxoanhomnd.Enabled = true;
            btnsuanhomnd.Enabled = true;
            btnluunhomnd.Enabled = false;

            btnthemnhomqh.Enabled = true;
            btnxoanhomqh.Enabled = true;
            btnsuanhomqh.Enabled = true;
            btnluunhomqh.Enabled = false;

            lblkqtknhomqh.Text = "";
            lblkqtknhomnd.Text = "";
        }

        private void dgvNhomND_Click(object sender, EventArgs e)
        {
            if (btnthemnhomnd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTennhomnd.Focus();
                return;
            }
            if (nnd.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvNhomND.CurrentRow.Index == dgvNhomND.NewRowIndex)
            {
                MessageBox.Show("Hãy chọn dòng có thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtManhomnd.Text = dgvNhomND.CurrentRow.Cells["IdNND"].Value.ToString();
            cbTennhomnd.Text = dgvNhomND.CurrentRow.Cells["TenNND"].Value.ToString();
            cbmanhomqh.Text = dgvNhomND.CurrentRow.Cells["IdNhomQH"].Value.ToString();
            txtmotanhomnd.Text = dgvNhomND.CurrentRow.Cells["MoTaNND"].Value.ToString();
            cbmanhomqh_TextChanged(sender, e);
            btnsuanhomnd.Enabled = true;
            btnxoanhomqh.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void dgvNhomQH_Click(object sender, EventArgs e)
        {
            if (btnthemnhomqh.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbtennhomqh.Focus();
                return;
            }
            if (nqh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvNhomQH.CurrentRow.IsNewRow == true)
            {
                MessageBox.Show("Hãy chọn dòng có thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ResetValuesnqh();
            txtmanhomqh.Text = dgvNhomQH.CurrentRow.Cells["IdNQH"].Value.ToString();
            cbtennhomqh.Text = dgvNhomQH.CurrentRow.Cells["TenNQH"].Value.ToString();
            txtmotanhomqh.Text = dgvNhomQH.CurrentRow.Cells["MoTa"].Value.ToString();
            string[] tmp = dgvNhomQH.CurrentRow.Cells["DanhmucTC"].Value.ToString().Split('|');
            string[] quyen = dgvNhomQH.CurrentRow.Cells["QuyenDM"].Value.ToString().Split('|');
            for (int i = 0; i < tmp.Length; ++i)
            {
                if (tmp[i].Trim() == "Quản lý nhân viên")
                {
                    chkqlnv.Checked = true;
                    string[] nv;
                    nv = quyen[i].Split(';');
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
                else if (tmp[i].Trim() == "Quản lý khách hàng")
                {
                    chkqlkh.Checked = true;
                    string[] kh;
                    kh = quyen[i].Split(';');
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
                else if (tmp[i].Trim() == "Quản lý nhà cung ứng")
                {
                    chkqlncu.Checked = true;
                    string[] ncu;
                    ncu = quyen[i].Split(';');
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
                else if (tmp[i].Trim() == "Quản lý sản phẩm")
                {
                    chkqlsp.Checked = true;
                    string[] sp;
                    sp = quyen[i].Split(';');
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
                else if (tmp[i].Trim() == "Quản lý hoá đơn")
                {
                    chkqlhd.Checked = true;
                    string[] hd;
                    hd = quyen[i].Split(';');
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
                else if (tmp[i].Trim() == "Thống kê, báo cáo")
                {
                    chktkbc.Checked = true;
                    string[] tk;
                    tk = quyen[i].Split(';');
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
                else if (tmp[i].Trim() == "Quản trị hệ thống (quản lý người dùng)")
                {
                    chkQuantri.Checked = true;
                    string[] qt;
                    qt = quyen[i].Split(';');
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

            btnsuanhomnd.Enabled = true;
            btnxoanhomqh.Enabled = true;
            btnHuy.Enabled = true;

            lblkqtknhomqh.Text = "";
        }

        private void btnxoanhomnd_Click(object sender, EventArgs e)
        {
            string sql;
            if (nnd.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhomnd.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xoá nhóm người dùng sẽ xoá tất cả các người dùng và các thông tin truy cập có liên quan với nhóm người dùng hiện tại. Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbTennhomnd.Text.Trim() == "Nhóm người dùng là nhân viên quản trị")
                {
                    MessageBox.Show("Không được xoá 'nhóm người dùng là nhân viên quản trị hệ thống', nhóm này được bảo vệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<string> idnd = new List<string>();

                sql = "select * from NGUOI_DUNG WHERE IdNND='" + txtManhomnd.Text + "'";
                DataRow dr;
                for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                {
                    dr = Ctrl.GetDataToTable(sql).Rows[i];
                    idnd.Add(dr["IdND"].ToString());
                }

                foreach (string items in idnd)
                {
                    sql = "select IdNV from NGUOI_DUNG WHERE IdND='" + items + "'";
                    string manv = Ctrl.GetFieldValues(sql);

                    sql = "delete TRUY_CAP where IdND = '" + items + "'";
                    Ctrl.RunSqlDel(sql);

                    sql = "delete NGUOI_DUNG where IdND = '" + items + "'";
                    Ctrl.RunSqlDel(sql);

                    sql = "update NHAN_VIEN set Taikhoan ='" + "" + "' where IdNV ='" + manv + "'";
                    Ctrl.RunSQL(sql);
                }

                sql = "DELETE NHOM_NGUOI_DUNG WHERE IdNND='" + txtManhomnd.Text + "'";
                Ctrl.RunSqlDel(sql);
                LoadDataGridViewnnd();
                ResetValuesnnd();
                btnHuy.Enabled = false;
            }

            DANGNHAP.thaotac += "Xoá nhóm người dùng, ";
        }

        private void btnxoanhomqh_Click(object sender, EventArgs e)
        {
            string sql;
            if (nqh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhomqh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xoá nhóm quyền hạn sẽ xoá tất cả các nhóm người dùng, người dùng và các thông tin truy cập có liên quan với nhóm quyền hạn hiện tại. Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cbtennhomqh.Text.Trim() == "Nhóm nhân viên quản trị")
                {
                    MessageBox.Show("Không được xoá nhóm quyền hạn là 'nhóm nhân viên quản trị hệ thống', nhóm này được bảo vệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //lấy danh sách nhóm người dùng có nhóm quyền muốn xoá
                List<string> idnnd = new List<string>();

                sql = "select * from NHOM_NGUOI_DUNG WHERE IdNhomQH='" + txtmanhomqh.Text + "'";
                DataRow dr;
                for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                {
                    dr = Ctrl.GetDataToTable(sql).Rows[i];
                    idnnd.Add(dr["IdNND"].ToString());
                }

                foreach (string items in idnnd)
                {
                    //lấy danh sách người dùng từ nhóm người dùng có nhóm quyền muốn xoá
                    List<string> idnd = new List<string>();

                    sql = "select * from NGUOI_DUNG WHERE IdNND='" + items + "'";
                    DataRow drnd;
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        drnd = Ctrl.GetDataToTable(sql).Rows[i];
                        idnd.Add(drnd["IdND"].ToString());
                    }
                    foreach (string item in idnd)
                    {
                        sql = "select IdNV from NGUOI_DUNG WHERE IdND='" + item + "'";
                        string manv = Ctrl.GetFieldValues(sql);

                        sql = "delete TRUY_CAP where IdND = '" + item + "'";
                        Ctrl.RunSqlDel(sql);

                        sql = "delete NGUOI_DUNG where IdND = '" + item + "'";
                        Ctrl.RunSqlDel(sql);

                        sql = "update NHAN_VIEN set Taikhoan ='" + "" + "' where IdNV ='" + manv + "'";
                        Ctrl.RunSQL(sql);
                    }

                    sql = "delete NHOM_NGUOI_DUNG where IdNND = '" + items + "'";
                    Ctrl.RunSqlDel(sql);
                }

                sql = "DELETE NHOM_QUYEN_HAN WHERE IdNQH='" + txtmanhomqh.Text + "'";
                Ctrl.RunSqlDel(sql);
                LoadDataGridViewnqh();
                ResetValuesnqh();
                btnHuy.Enabled = false;
            }

            sql = "SELECT * from NHOM_QUYEN_HAN";
            Ctrl.FillCombo(sql, cbmanhomqh, "IdNQH", "IdNQH");
            cbmanhomqh.SelectedIndex = -1;

            DANGNHAP.thaotac += "Xoá nhóm quyền hạn, ";

            lblkqtknhomqh.Text = "";
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

        private void cbmanhomqh_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbmanhomqh.Text.Trim() == "")
            {
                txttennhomqh.Text = "";
            }
            else
            {
                // Khi chọn mã nhóm quyền hạn thì tên nhóm quyền hạn hiện ra
                if (cbmanhomqh.Items.Count > 0)
                {
                    for (int i = 0; i < cbmanhomqh.Items.Count; ++i)
                    {
                        if (cbmanhomqh.Text.Trim() == cbmanhomqh.GetItemText(cbmanhomqh.Items[i]))
                        {
                            str = "SELECT TenNQH FROM NHOM_QUYEN_HAN WHERE IdNQH ='" + cbmanhomqh.GetItemText(cbmanhomqh.Items[i]) + "'";
                            txttennhomqh.Text = Ctrl.GetFieldValues(str);
                            str = cbmanhomqh.GetItemText(cbmanhomqh.Items[i]);
                            break;
                        }
                        else
                        {
                            txttennhomqh.Text = "";
                        }
                    }
                }
            }
        }

        private void cbmanhomqh_Leave(object sender, EventArgs e)
        {
            if (cbmanhomqh.Text.Trim() != "")
            {
                bool flag = false;
                for (int i = 0; i < cbmanhomqh.Items.Count; ++i)
                {
                    if (cbmanhomqh.Text.Trim() == cbmanhomqh.GetItemText(cbmanhomqh.Items[i]))
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Mã nhóm quyền hạn này không tồn tại vì chưa được thêm trên bảng nhóm quyền hạn", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbmanhomqh.Focus();
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

        private void NHOMND_NHOMQH_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
