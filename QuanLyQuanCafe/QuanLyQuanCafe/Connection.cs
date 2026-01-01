using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace QuanLyQuanCafe
{
    internal class Connection
    {
        public static string connection = @"";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
