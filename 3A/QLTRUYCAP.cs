using System;
using System.Data;
using System.Windows.Forms;

namespace _3A
{
    public partial class QLTRUYCAP : Form
    {
        public QLTRUYCAP()
        {
            InitializeComponent();
        }

        private DataTable tc;

        private void QLTRUYCAP_Load(object sender, EventArgs e)
        {
            string sql = "select * from TRUY_CAP";
            sql = "SELECT * from TRUY_CAP";
            Ctrl.FillCombo(sql, cbTenTK, "TenTK", "TenTK");
            cbTenTK.SelectedIndex = -1;
            LoadDataGridView();
            btnxoa.Enabled = false;
            lblkqtktc.Text = "(*) Tìm kiếm theo 'tên tài khoản'!";
        }

        private void LoadDataGridView()
        {
            string sql = "select * from TRUY_CAP";
            tc = Ctrl.GetDataToTable(sql);
            dgvtruycap.DataSource = tc;
            dgvtruycap.AllowUserToAddRows = false;
            dgvtruycap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            btnxoa.Enabled = false;
            txtmatc.Text = "";
            txtmanguoidung.Text = "";
            cbTenTK.Text = "";
            dtplandoimkcuoi.Value = DateTime.Now;
            dtplanDNcuoi.Value = DateTime.Now;
            dgvdanhmuc_thaotac.Rows.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmatc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TRUY_CAP WHERE IdTC='" + txtmatc.Text + "'";
                Ctrl.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
                btnxoa.Enabled = false;
                DANGNHAP.thaotac += "Xoá, ";
            }

            sql = "SELECT * from TRUY_CAP";
            Ctrl.FillCombo(sql, cbTenTK, "TenTK", "TenTK");
            cbTenTK.SelectedIndex = -1;

            lblkqtktc.Text = "(*) Tìm kiếm theo 'tên tài khoản'!";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DANGNHAP.thaotac += "Tìm kiếm, ";
            string sql;
            if (cbTenTK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = "SELECT * from TRUY_CAP WHERE TenTK= '" + cbTenTK.Text.Trim() + "'";
                tc = Ctrl.GetDataToTable(sql);
                if (tc.Rows.Count == 0)
                    lblkqtktc.Text = "Không có bản ghi nào được tìm thấy!";
                else
                    lblkqtktc.Text = "Có " + tc.Rows.Count + " bản ghi được tìm thấy!";
                dgvtruycap.DataSource = tc;
                ResetValues();
            }
        }

        private void dgvtruycap_Click(object sender, EventArgs e)
        {
            if (tc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvtruycap.CurrentRow.Index == dgvtruycap.NewRowIndex)
            {
                MessageBox.Show("Hãy chọn dòng có thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtmatc.Text = dgvtruycap.CurrentRow.Cells["IdTC"].Value.ToString();
            txtmanguoidung.Text = dgvtruycap.CurrentRow.Cells["IdND"].Value.ToString();
            cbTenTK.Text = dgvtruycap.CurrentRow.Cells["TenTK"].Value.ToString();
            dtplandoimkcuoi.Text = dgvtruycap.CurrentRow.Cells["LanDMKCuoi"].Value.ToString();
            dtplanDNcuoi.Text=dgvtruycap.CurrentRow.Cells["LanDNCuoi"].Value.ToString();
            string[] danmuc = dgvtruycap.CurrentRow.Cells["DanhmucTC"].Value.ToString().Split('|');
            string[] thaotac = dgvtruycap.CurrentRow.Cells["Thaotac"].Value.ToString().Split('|');
            if (danmuc.Length > 0 && thaotac.Length > 0)
            {
                int sldong = 0;
                for (int j = 0; j < danmuc.Length; ++j)
                {
                    if (danmuc[j].Trim().Length > 0)
                    {
                        sldong ++;
                    }
                }
                //Thêm vào bảng số dòng tương ứng với số danh mục mà người dùng đã truy cập
                if(dgvdanhmuc_thaotac.Rows.Count != sldong && sldong > 0)
                {
                    dgvdanhmuc_thaotac.Rows.Clear();
                    dgvdanhmuc_thaotac.Rows.Add(sldong);
                }
                else
                {
                    dgvdanhmuc_thaotac.Rows.Clear();
                }
                int k = 0;
                for (int i = 0; i < dgvdanhmuc_thaotac.Rows.Count; ++i)
                {
                    if (danmuc[i].Trim().Length > 0)
                    {
                        string[] dmct = danmuc[i].Split(';');
                        if (dmct.Length != 0)
                        {
                            dgvdanhmuc_thaotac.Rows[k].Cells["ThoidiemTC"].Value = dmct[0].Trim();
                            dgvdanhmuc_thaotac.Rows[k].Cells["DanhmucTCCT"].Value = dmct[1].Trim();
                            dgvdanhmuc_thaotac.Rows[k].Cells["ThaotacCT"].Value = thaotac[i].Trim();
                            k++;
                        }
                    }
                }
            }
            btnxoa.Enabled = true;
        }

        private void btnxoatatca_Click(object sender, EventArgs e)
        {
            string sql;
            if (tc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá tất cả bản ghi không?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "DELETE TRUY_CAP";
                Ctrl.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
                btnxoa.Enabled = false;
                DANGNHAP.thaotac += "Xoá tất cả, ";
            }
            else
            {
                return;
            }

            sql = "SELECT * from TRUY_CAP";
            Ctrl.FillCombo(sql, cbTenTK, "TenTK", "TenTK");
            cbTenTK.SelectedIndex = -1;

            lblkqtktc.Text = "(*) Tìm kiếm theo 'tên tài khoản'!";
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM TRUY_CAP";
            tc = Ctrl.GetDataToTable(sql);
            dgvtruycap.DataSource = tc;
            lblkqtktc.Text = "(*) Tìm kiếm theo 'tên tài khoản'!";
        }

        private void QLTRUYCAP_FormClosed(object sender, FormClosedEventArgs e)
        {
            DANGNHAP.thaotac += " | ";
        }
    }
}
