using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using DTO;
using BUS;

namespace _3A
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }

        private List<DataTable> dtblist;
        private int presentindex, listindex;
        private DataTable nv;
        private bool ktcv = false;
        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            Ctrl.connect();
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
            string[] mang = { "Nhân viên quản trị", "Nhân viên bán hàng", "Nhân viên quản lý kho", "Nhân viên kế toán" };
            cbchucvu.Items.AddRange(mang);

            //dtblist = new List<DataTable>();
            //string sql = "select * from NHAN_VIEN";
            //dtblist.Add(Ctrl.GetDataToTable(sql));
            //listindex = 0;
            //DGVNhanVien.DataSource = dtblist[0];
            ////DGVNhanVien.AllowUserToAddRows = false;
            //DGVNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void LoadDataGridView()
        {
            string sql = "SELECT * From NHAN_VIEN";
            nv = Ctrl.GetDataToTable(sql); //lấy dữ liệu
            DGVNhanVien.DataSource = nv;
            DGVNhanVien.AllowUserToAddRows = false;
            DGVNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            chkGioitinh.Checked = false;
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            mskDienthoai.Text = "";
            cbchucvu.Text = "";
            txttaikhoan.Text = "";

            rdbbanhang.Checked = false;
            rdbketoan.Checked = false;
            rdbquantri.Checked = false;
            rdbthukho.Checked = false;

            rdbbanhang.Enabled = true;
            rdbketoan.Enabled = true;
            rdbquantri.Enabled = true;
            rdbthukho.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtTenNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (nv.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xoá nhân viên sẽ xoá tất cả dữ liệu của người dùng và tất cả các thông tin truy cập có liên quan với nhân viên (người dùng) này.Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<string> idnd = new List<string>();
                
                sql = "select * from NGUOI_DUNG where IdNV ='" + DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString() + "'";
                DataRow dr;
                for(int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                {
                    dr = Ctrl.GetDataToTable(sql).Rows[i];
                    idnd.Add(dr["IdND"].ToString());
                }

                foreach(string items in idnd)
                {
                    sql = "DELETE TRUY_CAP WHERE IdND='" + items + "'";
                    Ctrl.RunSqlDel(sql);

                    sql = "DELETE NGUOI_DUNG WHERE IdND='" + items + "'";
                    Ctrl.RunSqlDel(sql);
                }

                sql = "DELETE NHAN_VIEN WHERE IdNV='" + DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString() + "'";
                Ctrl.RunSqlDel(sql);
                LoadDataGridView();

                //sql = "select * from NHAN_VIEN";
                //dtblist.Add(Ctrl.GetDataToTable(sql));
                //listindex = dtblist.Count - 1;
                ResetValues();
                btnBoqua.Enabled = false;
                DANGNHAP.thaotac += "Xoá, ";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (nv.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (cbchucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbchucvu.Focus();
                return;
            }

            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            //mã nhân viên đã thay đổi so với ban đầu do đổi nhóm nhân viên của nv hiện tại
            if (txtMaNhanVien.Text.Substring(0,3) != DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0,3))
            {
                //gọi lại sự kiện cbchucvu_Leave để kiểm tra chức vụ hợp lý không
                cbchucvu_Leave(sender, e);

                if (ktcv == true)
                {
                    sql = "INSERT INTO NHAN_VIEN VALUES ('" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text.Trim() + "','" + dtpNgaySinh.Value.ToShortDateString() + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "','" + mskDienthoai.Text.Trim() + "',N'" + cbchucvu.Text.Trim() + "','" + txttaikhoan.Text.Trim() + "')";
                    Ctrl.RunSQL(sql);

                    //cập nhật lại mã nhân viên trên bảng Người dùng
                    List<string> idnd = new List<string>();

                    sql = "select * from NGUOI_DUNG where IdNV ='" + DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString() + "'";
                    DataRow dr;
                    for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                    {
                        dr = Ctrl.GetDataToTable(sql).Rows[i];
                        idnd.Add(dr["IdND"].ToString());
                    }

                    foreach (string items in idnd)
                    {
                        sql = "UPDATE NGUOI_DUNG SET IdNV='" + txtMaNhanVien.Text.Trim() + "' WHERE IdND='" + items + "'";
                        Ctrl.RunSQL(sql);
                    }


                    sql = "DELETE NHAN_VIEN WHERE IdNV = '" + DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString() + "'";
                    Ctrl.RunSqlDel(sql);

                    LoadDataGridView();
                    sql = "select * from NHAN_VIEN";
                    dtblist.Add(Ctrl.GetDataToTable(sql));
                    listindex = dtblist.Count - 1;

                    ResetValues();
                    btnBoqua.Enabled = false;
                    ktcv = false;
                    DANGNHAP.thaotac += "Sửa, ";
                }
            }
            else
            {
                //gọi lại sự kiện cbchucvu_Leave để kiểm tra chức vụ hợp lý không
                cbchucvu_Leave(sender, e);
                if (ktcv == true)
                {
                    sql = "UPDATE NHAN_VIEN SET TenNV=N'" + txtTenNhanVien.Text.Trim() +
                        "',NgaySinh='" + dtpNgaySinh.Value.ToShortDateString() +
                        "',Gioitinh=N'" + gt + "',DiaChi=N'" + txtDiaChi.Text.Trim() + "', SĐT = '" + mskDienthoai.Text.Trim() + "',ChucVu=N'" + cbchucvu.Text.Trim() + "' WHERE IdNV='" + DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString() + "'";
                    Ctrl.RunSQL(sql);
                    LoadDataGridView();
                    sql = "select * from NHAN_VIEN";
                    dtblist.Add(Ctrl.GetDataToTable(sql));
                    listindex = dtblist.Count - 1;

                    ResetValues();
                    btnBoqua.Enabled = false;
                    ktcv = false;
                    DANGNHAP.thaotac += "Sửa, ";
                }
            }
        }
        //--them nhân viên
        public void Themnv()
        {
            string gt = "";
            if (chkGioitinh.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            DTO_NV nv = new DTO_NV(txtMaNhanVien.Text,txtTenNhanVien.Text,dtpNgaySinh.Text,gt,mskDienthoai.Text, txtDiaChi.Text,cbchucvu.Text,txttaikhoan.Text);
            BUS_NV.themnv(nv);
        }

        //--load danh sach nhân viên
        public void Loadnv()
        {
            DGVNhanVien.DataSource = BUS_NV.hienthinv();
        }

        //--refresh giá trị các control
        public void Refresh_TextBox()
        {
            txtMaNhanVien.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            chkGioitinh.Checked = false;
            mskDienthoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            cbchucvu.Text = string.Empty;
            txttaikhoan.Text = string.Empty;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (cbchucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbchucvu.Focus();
                return;
            }

            //if (chkGioitinh.Checked == true)
            //    gt = "Nam";
            //else
            //    gt = "Nữ";
            sql = "SELECT IdNV FROM NHAN_VIEN WHERE IdNV='" + txtMaNhanVien.Text + "'";
            if (Ctrl.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                txtMaNhanVien.Text = "";
                return;
            }

            //gọi lại sự kiện cbchucvu_Leave để kiểm tra chức vụ hợp lý không
            cbchucvu_Leave(sender, e);

            if (ktcv == true)
            {
                //sql = "INSERT INTO NHAN_VIEN(IdNV, TenNV, NgaySinh, Gioitinh, DiaChi, SĐT, Chucvu) VALUES ('" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text.Trim() + "','" + dtpNgaySinh.Value.ToShortDateString() + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "','" + mskDienthoai.Text.Trim() + "',N'" + cbchucvu.Text.Trim() + "')";
                //Ctrl.RunSQL(sql);
                //LoadDataGridView();

                //sql = "select * from NHAN_VIEN";
                //dtblist.Add(Ctrl.GetDataToTable(sql));
                //listindex = dtblist.Count - 1;

                //ResetValues();
                Themnv();
                Loadnv();
                Refresh_TextBox();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoqua.Enabled = false;
                btnLuu.Enabled = false;
                ktcv = false;

                //thêm dữ liệu cho danh mục quản lý truy cập
                DANGNHAP.thaotac += "Thêm, ";
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (DGVNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text = DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString();
            if (txtMaNhanVien.Text.Substring(0, 3) == "NQT")
            {
                rdbquantri.Checked = true;
                rdbketoan.Checked = false;
                rdbbanhang.Checked = false;
                rdbthukho.Checked = false;
            }
            if (txtMaNhanVien.Text.Substring(0, 3) == "NKT")
            {
                rdbquantri.Checked = false;
                rdbketoan.Checked = true;
                rdbbanhang.Checked = false;
                rdbthukho.Checked = false;
            }
            if (txtMaNhanVien.Text.Substring(0, 3) == "NBH")
            {
                rdbquantri.Checked = false;
                rdbketoan.Checked = false;
                rdbbanhang.Checked = true;
                rdbthukho.Checked = false;
            }
            if (txtMaNhanVien.Text.Substring(0, 3) == "NTK")
            {
                rdbquantri.Checked = false;
                rdbketoan.Checked = false;
                rdbbanhang.Checked = false;
                rdbthukho.Checked = true;
            }

            txtTenNhanVien.Text = DGVNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (DGVNhanVien.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam") chkGioitinh.Checked = true;
            else chkGioitinh.Checked = false;
            txtDiaChi.Text = DGVNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienthoai.Text = DGVNhanVien.CurrentRow.Cells["SĐT"].Value.ToString();
            dtpNgaySinh.Text = DGVNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cbchucvu.Text = DGVNhanVien.CurrentRow.Cells["ChucVu"].Value.ToString();
            txttaikhoan.Text = DGVNhanVien.CurrentRow.Cells["Taikhoan"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = false;

        }

        private void mskDienthoai_Leave(object sender, EventArgs e)
        {
            if (mskDienthoai.Text.Trim() != "")
            {
                double a = 0;
                if (!double.TryParse(mskDienthoai.Text, out a))
                {
                    MessageBox.Show("Giá trị phải là số!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskDienthoai.Focus();
                }
                else
                {
                    if (a < 0)
                    {
                        MessageBox.Show("Giá trị hợp lệ phải >= 0!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskDienthoai.Focus();
                    }
                }
            }
        }

        private void cbchucvu_Leave(object sender, EventArgs e)
        {
            if (cbchucvu.Text.Trim() != "")
            {
                bool flag = false;
                string cv = "";
                for (int i = 0; i < cbchucvu.Items.Count; ++i)
                {
                    if (cbchucvu.Text.Trim() == cbchucvu.GetItemText(cbchucvu.Items[i]))
                    {
                        flag = true;
                        cv = cbchucvu.GetItemText(cbchucvu.Items[i]);
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Chức vụ chỉ bao gồm: 'Nhân viên quản trị', 'Nhân viên bán hàng', 'Nhân viên quản lý kho', 'Nhân viên kế toán'! Chú ý viết hoa ký tự đầu.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbchucvu.Focus();
                }
                else
                {
                    if (txtMaNhanVien.Text.Trim() != "")
                    {
                        if (txtMaNhanVien.Text.Trim().Substring(0, 3) == "NQT")
                        {
                            if(cv!= "Nhân viên quản trị")
                            {
                                MessageBox.Show("Chức vụ phải là 'Nhân viên quản trị'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbchucvu.Focus();
                                ktcv = false;
                            }
                            else
                            {
                                ktcv = true;
                            }
                        }

                        if (txtMaNhanVien.Text.Trim().Substring(0, 3) == "NKT")
                        {
                            if (cv != "Nhân viên kế toán")
                            {
                                MessageBox.Show("Chức vụ phải là 'Nhân viên kế toán'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbchucvu.Focus();
                                ktcv = false;
                                return;
                            }
                            else
                            {
                                ktcv = true;
                            }
                        }

                        if (txtMaNhanVien.Text.Trim().Substring(0, 3) == "NBH")
                        {
                            if (cv != "Nhân viên bán hàng")
                            {
                                MessageBox.Show("Chức vụ phải là 'Nhân viên bán hàng'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbchucvu.Focus();
                                ktcv = false;
                                return;
                            }
                            else
                            {
                                ktcv = true;
                            }
                        }

                        if (txtMaNhanVien.Text.Trim().Substring(0, 3) == "NTK")
                        {
                            if (cv != "Nhân viên quản lý kho")
                            {
                                MessageBox.Show("Chức vụ phải là 'Nhân viên quản lý kho'.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbchucvu.Focus();
                                ktcv = false;
                                return;
                            }
                            else
                            {
                                ktcv = true;
                            }
                        }
                    }
                }
            }
        }

        private void rdbquantri_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdbquantri.Checked == true && btnLuu.Enabled == true) || (rdbquantri.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0,3) != "NQT"))
            {
                //tạo mã ngẫu nhiên
                int gt;
                bool kt = false;
                string sql = "";
                Random rand = new Random();
                sql = "select * from NHAN_VIEN";
                gt = rand.Next(100000000, 999999999);
                string quantri = "NQT" + gt;
                DataRow dr;
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    while (kt == false)
                    {
                        for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                        {
                            dr = Ctrl.GetDataToTable(sql).Rows[i];
                            if (quantri == dr["IdNV"].ToString())
                            {
                                kt = false;
                                gt = rand.Next(100000000, 999999999);
                                quantri = "NQT" + gt;
                                break;
                            }
                            else
                            {
                                kt = true;
                            }
                        }
                    }
                    txtMaNhanVien.Text = quantri;
                }
                else
                {
                    txtMaNhanVien.Text = quantri;
                }
            }
            if (rdbquantri.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) == "NQT")
            {
                txtMaNhanVien.Text = DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString();
            }
        }

        private void rdbketoan_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdbketoan.Checked == true && btnLuu.Enabled == true) || (rdbketoan.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) != "NKT"))
            {
                //tạo mã ngẫu nhiên
                int gt;
                bool kt = false;
                string sql = "";
                Random rand = new Random();
                sql = "select * from NHAN_VIEN";
                gt = rand.Next(100000000, 999999999);
                string ketoan = "NKT" + gt;
                DataRow dr;
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    while (kt == false)
                    {
                        for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                        {
                            dr = Ctrl.GetDataToTable(sql).Rows[i];
                            if (ketoan == dr["IdNV"].ToString())
                            {
                                kt = false;
                                gt = rand.Next(100000000, 999999999);
                                ketoan = "NKT" + gt;
                                break;
                            }
                            else
                            {
                                kt = true;
                            }
                        }
                    }
                    txtMaNhanVien.Text = ketoan;
                }
                else
                {
                    txtMaNhanVien.Text = ketoan;
                }
            }
            if (rdbketoan.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) == "NKT")
            {
                txtMaNhanVien.Text = DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString();
            }
        }

        private void rdbbanhang_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdbbanhang.Checked == true && btnLuu.Enabled == true) || (rdbbanhang.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) != "NBH"))
            {
                //tạo mã ngẫu nhiên
                int gt;
                bool kt = false;
                string sql = "";
                Random rand = new Random();
                sql = "select * from NHAN_VIEN";
                gt = rand.Next(100000000, 999999999);
                string banhang = "NBH" + gt;
                DataRow dr;
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    while (kt == false)
                    {
                        for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                        {
                            dr = Ctrl.GetDataToTable(sql).Rows[i];
                            if (banhang == dr["IdNV"].ToString())
                            {
                                kt = false;
                                gt = rand.Next(100000000, 999999999);
                                banhang = "NBH" + gt;
                                break;
                            }
                            else
                            {
                                kt = true;
                            }
                        }
                    }
                    txtMaNhanVien.Text = banhang;
                }
                else
                {
                    txtMaNhanVien.Text = banhang;
                }
            }
            if (rdbbanhang.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) == "NBH")
            {
                txtMaNhanVien.Text = DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString();
            }
        }

        private void rdbthukho_CheckedChanged(object sender, EventArgs e)
        {
            if ((rdbthukho.Checked == true && btnLuu.Enabled == true) || (rdbthukho.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) != "NTK"))
            {
                //tạo mã ngẫu nhiên
                int gt;
                bool kt = false;
                string sql = "";
                Random rand = new Random();
                sql = "select * from NHAN_VIEN";
                gt = rand.Next(100000000, 999999999);
                string thukho = "NTK" + gt;
                DataRow dr;
                if (Ctrl.GetDataToTable(sql) != null)
                {
                    while (kt == false)
                    {
                        for (int i = 0; i < Ctrl.GetDataToTable(sql).Rows.Count; ++i)
                        {
                            dr = Ctrl.GetDataToTable(sql).Rows[i];
                            if (thukho == dr["IdNV"].ToString())
                            {
                                kt = false;
                                gt = rand.Next(100000000, 999999999);
                                thukho = "NTK" + gt;
                                break;
                            }
                            else
                            {
                                kt = true;
                            }
                        }
                    }
                    txtMaNhanVien.Text = thukho;
                }
                else
                {
                    txtMaNhanVien.Text = thukho;
                }
            }
            if(rdbthukho.Checked == true && btnLuu.Enabled == false && DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString().Substring(0, 3) == "NTK")
            {
                txtMaNhanVien.Text = DGVNhanVien.CurrentRow.Cells["IdNV"].Value.ToString();
            }
        }

        private void NHANVIEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
            //dtblist.Clear();
            Ctrl.disconnect();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            listindex = listindex - 1;
            if (listindex >= 0 && listindex == presentindex)
            {
                DGVNhanVien.DataSource = dtblist[listindex];
                string sql = "delete NHAN_VIEN";
                Ctrl.RunSqlDel(sql);
                DataGridViewRow dgr;
                for(int i = 0; i < DGVNhanVien.RowCount; ++i)
                {
                    dgr = DGVNhanVien.Rows[i];
                    sql = "insert into NHAN_VIEN values('" + dgr.Cells["IdNV"] + "', '" + dgr.Cells["TenNV"] + "', '" + dgr.Cells["NgaySinh"] + "', '" + dgr.Cells["Gioitinh"] + "', '" + dgr.Cells["DiaChi"] + "', '" + dgr.Cells["SĐT"] + "', '" + dgr.Cells["Chucvu"] + "', '" + dgr.Cells["Taikhoan"] + "')";
                    Ctrl.RunSQL(sql);
                }
                presentindex = listindex;
            }
            else if(listindex >= 0 && listindex != presentindex)
            {
                DGVNhanVien.DataSource = dtblist[presentindex];
                string sql = "delete NHAN_VIEN";
                Ctrl.RunSqlDel(sql);
                DataGridViewRow dgr;
                for (int i = 0; i < DGVNhanVien.RowCount; ++i)
                {
                    dgr = DGVNhanVien.Rows[i];
                    sql = "insert into NHAN_VIEN values('" + dgr.Cells["IdNV"] + "', '" + dgr.Cells["TenNV"] + "', '" + dgr.Cells["NgaySinh"] + "', '" + dgr.Cells["Gioitinh"] + "', '" + dgr.Cells["DiaChi"] + "', '" + dgr.Cells["SĐT"] + "', '" + dgr.Cells["Chucvu"] + "', '" + dgr.Cells["Taikhoan"] + "')";
                    Ctrl.RunSQL(sql);
                }
                presentindex = listindex;
            }
        }

        private void btnredo_Click(object sender, EventArgs e)
        {

        }
    }
}
