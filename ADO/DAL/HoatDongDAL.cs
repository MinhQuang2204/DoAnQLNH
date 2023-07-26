using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class HoatDongDAL
    {
        public static void ThemChuyenTien(HoatDongDTO dl)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_AddChuyenTien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaGD", SqlDbType.NChar,50);
            command.Parameters.Add("@SoTien", SqlDbType.Int);
            command.Parameters.Add("@NgayChuyen", SqlDbType.DateTime);
            command.Parameters["@MaGD"].Value = dl.magd;
            command.Parameters["@SoTien"].Value = dl.st;
            command.Parameters["@NgayChuyen"].Value = dl.ngay;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void ThemRutTien(HoatDongDTO dl)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_AddRutTien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaGD", SqlDbType.NChar,50);
            command.Parameters.Add("@SoTien", SqlDbType.Int);
            command.Parameters.Add("@NgayRut", SqlDbType.DateTime);
            command.Parameters["@MaGD"].Value = dl.magd;
            command.Parameters["@SoTien"].Value = dl.st;
            command.Parameters["@NgayRut"].Value = dl.ngay;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
