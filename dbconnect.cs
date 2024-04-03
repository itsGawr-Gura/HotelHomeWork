using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace HotelCard
{
    internal class dbconnect
    {
        
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=hotelcard");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                
            }
        }
        
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
