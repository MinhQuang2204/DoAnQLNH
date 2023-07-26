using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class GiaoDichDAL
    {
        public static void ThemGiaoDich(GiaoDichDTO gd)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_AddGiaoDich", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHD", SqlDbType.NChar,50);
            command.Parameters.Add("@NgayTH", SqlDbType.DateTime);
            command.Parameters.Add("@NgayKT", SqlDbType.DateTime);
            command.Parameters.Add("@MaGD", SqlDbType.NChar,50);
            command.Parameters["@MaHD"].Value = gd.mahd;
            command.Parameters["@NgayTH"].Value = gd.ngayth;
            command.Parameters["@NgayKT"].Value = gd.ngaykt;
            command.Parameters["@MaGD"].Value = gd.magd;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
