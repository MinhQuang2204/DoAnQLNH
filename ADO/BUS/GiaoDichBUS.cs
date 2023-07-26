using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class GiaoDichBUS
    {
        public static void InsertGiaoDich(GiaoDichDTO gd)
        {
            GiaoDichDAL.ThemGiaoDich(gd);
        }
    }
}
