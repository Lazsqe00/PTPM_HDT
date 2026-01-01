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
        public static string connection = @"Data Source=LAPTOP-2D858Q81;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
