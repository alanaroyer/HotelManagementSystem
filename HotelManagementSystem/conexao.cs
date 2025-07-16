using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public class Conexao : IDisposable
    {
        private MySqlConnection connection;

        public Conexao()
        {
            string connectionString = "SERVER= localhost;DATABASE=hoteldb;UID=root;PWD=admin123";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}
