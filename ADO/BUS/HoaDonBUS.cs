using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        public static void InsertHoaDon(HoaDonDTO hd)
        {
            HoaDonDAL.ThemHoaDon(hd);
        }
    }
}
