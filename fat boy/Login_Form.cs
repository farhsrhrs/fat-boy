using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fat_boy
{
    public partial class Login_Form : Form
    {
        static public string Role, User;



        public Login_Form()
        {
            InitializeComponent();
            PasswordFielde.UseSystemPasswordChar = true;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        static public void GetInfo(string login, string password)
        {
            try
            {
                DataBase.msCommand.CommandText = "SELECT * FROM `users` WHERE `login` = '" + login + "' AND `pass` = '" + password + "'";
                Object result = DataBase.msCommand.ExecuteScalar();
                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                }
            }
            catch
            {
                Role = null;
                MessageBox.Show("Ошибка данных");
            }


        }


        private void Sing_In_Click(object sender, EventArgs e)
        {
            DataBase.ConnectionDB();
            string _login_user = LoginFielde.Text;
            string _password_user = PasswordFielde.Text;

            DataBase DataSignIn = new DataBase();
            DataTable DataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", DataSignIn.GetConnection());  //@uL
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _login_user;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = _password_user;
            adapter.SelectCommand = command;

            adapter.Fill(DataTable);
            if (DataTable.Rows.Count > 0)
            {

                this.Hide();
                Scan_QR scan_QR = new Scan_QR();
                scan_QR.Show();
                MessageBox.Show("Yes");
            }
            else {
                MessageBox.Show("No");
            }

            //private void PasswordFielde_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
}
