using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class NhanVienBUS
    {
        public static DataTable GetAllNhanVien()
        {
            return NhanVienDAL.getData();
        }

        public static void InsertNhanVien(NhanVienDTO nv)
        {
            NhanVienDAL.ThemNhanVien(nv);
        }

        public static void UpdateNhanVien(NhanVienDTO nv)
        {
            NhanVienDAL.SuaNhanVien(nv);
        }
        
        public static void DeleteNhanVien(int nvql)
        {
            NhanVienDAL.XoaNhanVien(nvql);
        }
    }
}
