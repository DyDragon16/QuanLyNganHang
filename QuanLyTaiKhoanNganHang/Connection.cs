using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoanNganHang
{
    class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-046ARUTC\SQLEXPRESS01;Initial Catalog=QuanLyTaiKhoanNganHang;Integrated Security=True";

        public static Connection connection = null;

        public static Connection getInstance()
        {
            if (connection == null)
            {
                connection = new Connection();
            }
            return connection;
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
