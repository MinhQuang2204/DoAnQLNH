using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    class ConnectionData
    {
        public static SqlConnection KetNoi()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyNganHang;Integrated Security=True");
            return Con;
        }

    }
}
