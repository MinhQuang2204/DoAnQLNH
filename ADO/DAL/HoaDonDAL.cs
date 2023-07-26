using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HoaDonDAL
    {
        public static void ThemHoaDon(HoaDonDTO hd)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_AddHoaDon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHD", SqlDbType.NChar,50);
            command.Parameters.Add("@MaKH", SqlDbType.Int);
            command.Parameters.Add("@MaNV", SqlDbType.Int);
            command.Parameters.Add("@NgayIn", SqlDbType.DateTime);
            command.Parameters["@MaHD"].Value = hd.mahd;
            command.Parameters["@MaKH"].Value = hd.makh;
            command.Parameters["@MaNV"].Value = hd.manv;
            command.Parameters["@NgayIn"].Value = hd.ngayin;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
