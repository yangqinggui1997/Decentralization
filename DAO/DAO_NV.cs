using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_NV
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\PhanQuyen\3A\3A.mdf;Integrated Security=True;Connect Timeout=30");

        public static DataTable hienthinv()
        {
            SqlCommand cmd = new SqlCommand("sp_hienthikhachhang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;

        }

        public static void Themnv( DTO_NV nv)
        {
            SqlCommand cmd = new SqlCommand("sp_themkhachhang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@ngaysinh", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 500);
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@taikhoan", SqlDbType.VarChar, 200);


            //Gan gia tri
            cmd.Parameters["@manv"].Value = nv.Manv;
            cmd.Parameters["@ten"].Value = nv.Ten;
            cmd.Parameters["@ngaysinh"].Value = nv.Ngaysinh;
            cmd.Parameters["@gioitinh"].Value = nv.Gioitinh;
            cmd.Parameters["@diachi"].Value = nv.Diachi;
            cmd.Parameters["@sdt"].Value = nv.Sdt;
            cmd.Parameters["@chucvu"].Value = nv.Chucvu;
            cmd.Parameters["@taikhoan"].Value = nv.Taikhoan;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
