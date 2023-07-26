using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class HoatDongBUS
    {
        public static void InsertChuyenTien(HoatDongDTO dl)
        {
            HoatDongDAL.ThemChuyenTien(dl);
        }
        public static void InsertRutTien(HoatDongDTO dl)
        {
            HoatDongDAL.ThemRutTien(dl);
        }
    }
}
