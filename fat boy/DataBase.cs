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
        static string DBConnect = "server=localhost;username=root;password=root;database=warehouse";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myconnection;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                myconnection = new MySqlConnection(DBConnect);
                myconnection.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnection;
                msDataAdapter = new MySqlDataAdapter();
                return true;

            }
            catch
            {
                MessageBox.Show("Ошибка");
                return false;
            }
            
        }



        //MySqlConnection connection = new MySqlConnection("server=localhost;username=root;password=root;database=warehouse");


        public void CloseDB()
        {
            myconnection.Close();
        }
        public MySqlConnection GetConnection() { 
            return myconnection;
        }
    }
}
