using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fat_boy
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;username=root;password=root;database=warehouse");

        public void OpenConnction()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnction()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection() { 
            return connection;
        }
    }
}
