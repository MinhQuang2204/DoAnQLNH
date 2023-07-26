using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class KhachHangDAL
    {
        public static DataTable gettData()
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_GetAllKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static int getKH(int cmnd)
        {
            try
            {
                SqlConnection Conn = ConnectionData2.KetNoi2();
                SqlCommand command = new SqlCommand("sp_GetMaKHByCMND", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cmnd", SqlDbType.Int);
                command.Parameters["@cmnd"].Value = cmnd;
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                return Int32.Parse(command.ExecuteScalar().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
                return 0;
            }
        }

        public static void ThemKhachHang(KhachHangDTO kh)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_AddThemKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.Int);
            command.Parameters.Add("@HoKH", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenLot", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters["@MaKH"].Value = kh.MaKH1;
            command.Parameters["@HoKH"].Value = kh.HoKH1;
            command.Parameters["@TenLot"].Value = kh.TenLot1;
            command.Parameters["@TenKH"].Value = kh.TenKH1;
            command.Parameters["@DiaChi"].Value = kh.DiaChi1;
            command.Parameters["@CMNDa"].Value = kh.CMND1;
            command.Parameters["@SDT"].Value = kh.SDT1;         
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void SuaKhachHang(KhachHangDTO nv)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_UpdateSuaKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.Int);
            command.Parameters.Add("@HoKH", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenLot", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@SDT", SqlDbType.Int);         
            command.Parameters["@MaKH"].Value = nv.MaKH1;
            command.Parameters["@HoKH"].Value = nv.HoKH1;
            command.Parameters["@TenLot"].Value = nv.TenLot1;
            command.Parameters["@TenKH"].Value = nv.TenKH1;
            command.Parameters["@DiaChi"].Value = nv.DiaChi1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@SDT"].Value = nv.SDT1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void XoaKhachHang(KhachHangDTO nv)
        {
            SqlConnection Conn = ConnectionData2.KetNoi2();
            SqlCommand command = new SqlCommand("sp_DelXoaKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.Int);
            command.Parameters["@MaKH"].Value = nv.MaKH1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }



    }
}
