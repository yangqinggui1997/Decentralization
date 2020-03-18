using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace _3A
{
    public class Ctrl
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\PhanQuyen\3A\3A.mdf;Integrated Security=True;Connect Timeout=30");

        public static void connect()
        {
            con.Open();
        }
        public static void disconnect()
        {
            con.Close();
            con.Dispose();
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = con; //Kết nối cơ sở dữ liệu
            MyData.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
            List<string> datatmp = new List<string>();
            for (int i = 0; i < cbo.Items.Count; ++i)
            {
                datatmp.Add(cbo.GetItemText(cbo.Items[i]));
            }
            cbo.DataSource = null;
            while (KiemtraTrung(datatmp) == true)
            {
                LocDuLieuTrung(datatmp);
            }
            for (int i = 0; i < datatmp.Count; ++i)
            {
                cbo.Items.Add(datatmp.ElementAt(i));
            }
        }

        public static void LocDuLieuTrung(List<string> list)
        {
            int flag;
            for (int j = 0; j < list.Count; ++j)
            {
                for (int i = j + 1; i < list.Count; ++i)
                {
                    flag = 0;
                    if (list.ElementAt(i) == list.ElementAt(j))
                    {
                        flag = 1;
                    }
                    if (flag == 1)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }

        public static bool KiemtraTrung(List<string> list)
        {
            bool flag = false;
            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = i + 1; j < list.Count; ++j)
                {
                    if (list.ElementAt(i) == list.ElementAt(j))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        public static bool CheckExistingForm(string name)
        {
            bool check = false;
            MAIN m = new MAIN();
            foreach (Form frm in m.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static void ActiveChildForm(string name)
        {
            MAIN m = new MAIN();
            foreach (Form frm in m.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        public static int CheckTenTK(TextBox txt)
        {
            int check = 0;
            if (txt.Text.Length < 6)
            {
                check = 1;
            }
            else
            {
                bool tmp = false, tmp1 = false, tmp2 = false;
                char[] wl = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] wu = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i = 0; i < txt.TextLength; ++i)
                {
                    for (int j = 0; j < wl.Length; ++j)
                    {
                        if (txt.Text.ToCharArray()[i] == wl[j])
                        {
                            tmp = true;
                            goto label;
                        }
                        else
                        {
                            tmp = false;
                        }
                    }
                    for (int k = 0; k < wu.Length; ++k)
                    {
                        if (txt.Text.ToCharArray()[i] == wu[k])
                        {
                            tmp1 = true;
                            goto label;
                        }
                        else
                        {
                            tmp1 = false;
                        }
                    }
                    for (int l = 0; l < numbers.Length; ++l)
                    {
                        if (txt.Text.ToCharArray()[i] == numbers[l])
                        {
                            tmp2 = true;
                            break;
                        }
                        else
                        {
                            tmp2 = false;
                        }
                    }
                    label:
                    if (tmp == false && tmp1 == false && tmp2 == false)
                    {
                        check = 2;
                    }
                }
            }
            return check;
        }
        public static int CheckMK(TextBox txt)
        {
            int check = 0;
            if (txt.Text.Length < 6)
            {
                check = 1;
            }
            else
            {
                char[] wl = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] wu = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                bool tmp = false, tmp1 = false, tmp2 = false, tmp3 = false, tmp4 = false, tmp5 = false, tmp6 = false, tmp7 = false;
                for (int i = 0; i < txt.TextLength; ++i)
                {
                    for (int j = 0; j < wl.Length; ++j)
                    {
                        if (txt.Text.ToCharArray()[i] == wl[j])
                        {
                            tmp = true;
                            tmp4 = true;
                            break;
                        }
                        else
                        {
                            tmp = false;
                        }
                    }
                    if (tmp == false)
                    {
                        tmp3 = true;
                        for (int k = 0; k < wu.Length; ++k)
                        {
                            if (txt.Text.ToCharArray()[i] == wu[k])
                            {
                                tmp1 = true;
                                tmp5 = true;
                                break;
                            }
                            else
                            {
                                tmp1 = false;
                            }
                        }
                        if (tmp1 == false)
                        {
                            for (int k = 0; k < numbers.Length; ++k)
                            {
                                if (txt.Text.ToCharArray()[i] == numbers[k])
                                {
                                    tmp2 = true;
                                    tmp6 = true;
                                    break;
                                }
                                else
                                {
                                    tmp2 = false;
                                }
                            }
                            if (tmp2 == false)
                            {
                                tmp7 = true;
                            }
                        }
                    }

                }
                if ((tmp == true && tmp3 == false) || (tmp1 == true && tmp4 == false && tmp6 == false && tmp7 == false) || (tmp2 == true && tmp4 == false && tmp5 == false && tmp7 == false))
                {
                    check = 2;
                }
                if ((tmp4 == true && tmp5 == true) || (tmp4 == true && tmp6 == true) || (tmp5 == true && tmp6 == true))
                {
                    check = 3;
                }
                if ((tmp7 == true && tmp4 == true) || (tmp7 == true && tmp5 == true) || (tmp7 == true && tmp6 == true) || (tmp7 == true && tmp4 == true && tmp5 == true) || (tmp7 == true && tmp4 == true && tmp6 == true) || (tmp7 == true && tmp5 == true && tmp6 == true) || (tmp7 == true && tmp4 == true && tmp5 == true && tmp6 == true) || (tmp4 == true && tmp5 == true && tmp6 == true))
                {
                    check = 4;
                }
            }
            return check;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

    }
}
