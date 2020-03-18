using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_NV
    {
        public static DataTable hienthinv()
        {
            return DAO_NV.hienthinv();
        }
        public static void themnv(DTO_NV nv)
        {
            DAO_NV.Themnv(nv);
        }
    }
}
