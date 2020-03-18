
namespace DTO
{
    public class DTO_NV
    {
        private string manv;
        private string ten;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        private string diachi;
        private string chucvu;
        private string taikhoan;

        public string Manv { get => manv; set => manv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }

        public  DTO_NV(string manv,string ten,string ngaysinh, string gioitinh, string sdt,string diachi, string chucvu, string taikhoan)
        {
            Manv = manv;
            Ten = ten;
            Ngaysinh = ngaysinh;
            Gioitinh = gioitinh;
            Sdt = sdt;
            Diachi = diachi;
            Chucvu = chucvu;
            Taikhoan = taikhoan;
        }
    }
}
