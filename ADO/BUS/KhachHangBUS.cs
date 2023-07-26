using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        public static DataTable GetAlllKhachHang()
        {
            return KhachHangDAL.gettData();
        }

        public static int GetMaKH(int cmnd)
        {
            return KhachHangDAL.getKH(cmnd);
        }

        public static void InsertKhachHang(KhachHangDTO kh)
        {
            KhachHangDAL.ThemKhachHang(kh);
        }

        public static void UpdateKhachHang(KhachHangDTO kh)
        {
            KhachHangDAL.SuaKhachHang(kh);
        }
      
    }
}
