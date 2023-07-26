using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    class ConnectionData2
    {   
        public static SqlConnection KetNoi2()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyNganHang;Integrated Security=True");
            return Conn;
        }
    }
}
