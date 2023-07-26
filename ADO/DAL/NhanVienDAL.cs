using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        public static DataTable getData()
        {
            SqlConnection Con = ConnectionData.KetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllNhanVien", Con);
            command.CommandType = CommandType.StoredProcedure;
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();
            return dt;
        }

        public static void ThemNhanVien(NhanVienDTO nv)
        {
            SqlConnection Con = ConnectionData.KetNoi();
            SqlCommand command = new SqlCommand("sp_AddThemNhanVien", Con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.Int);
            command.Parameters.Add("@HoNV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenLot", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenNV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Luong", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Phong", SqlDbType.Int);
            command.Parameters["@MaNV"].Value = nv.MaNV1;
            command.Parameters["@HoNV"].Value = nv.HoNV1;   
            command.Parameters["@TenLot"].Value = nv.TenLot1;
            command.Parameters["@TenNV"].Value = nv.TenNV1;
            command.Parameters["@DiaChi"].Value = nv.DiaChi1;
            command.Parameters["@SDT"].Value = nv.SDT1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@ChucVu"].Value = nv.ChucVu1;
            command.Parameters["@Luong"].Value = nv.Luong1;
            command.Parameters["@Phong"].Value = nv.Phong1;
            Con.Open();
            command.ExecuteNonQuery();
            Con.Close();
        }

        public static void SuaNhanVien(NhanVienDTO nv)
        {
            SqlConnection Con = ConnectionData.KetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateSuaNhanVien", Con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.Int);
            command.Parameters.Add("@HoNV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenLot", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenNV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Luong", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Phong", SqlDbType.Int);
            command.Parameters["@MaNV"].Value = nv.MaNV1;
            command.Parameters["@HoNV"].Value = nv.HoNV1;
            command.Parameters["@TenLot"].Value = nv.TenLot1;
            command.Parameters["@TenNV"].Value = nv.TenNV1;
            command.Parameters["@DiaChi"].Value = nv.DiaChi1;
            command.Parameters["@SDT"].Value = nv.SDT1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@ChucVu"].Value = nv.ChucVu1;
            command.Parameters["@Luong"].Value = nv.Luong1;
            command.Parameters["@Phong"].Value = nv.Phong1;
            
            Con.Open();
            command.ExecuteNonQuery();
            Con.Close();
        }

        public static void XoaNhanVien(int manv)
        {
            SqlConnection Con = ConnectionData.KetNoi();
            SqlCommand command = new SqlCommand("sp_DelXoaNhanVien", Con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNV", SqlDbType.Int);
            command.Parameters["@MaNV"].Value = manv;

            Con.Open();
            command.ExecuteNonQuery();
            Con.Close();
        }      
    }
}
