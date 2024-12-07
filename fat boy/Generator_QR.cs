using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fat_boy
{
    public partial class Generator_QR : Form
    {
        public Generator_QR()
        {

            InitializeComponent();
            SelectInfo("place", "place", "idplace", comboBox1); //from
            SelectInfo("place", "place", "idplace", comboBox2); //to
            SelectInfo("name", "thing", "idthing", comboBox3); //thing
            SelectInfo("name", "status", "idstatus", comboBox4); //status
        }
        public void SelectInfo(string selectInfo, string table, string idattribute, ComboBox comboBox)
        {
            bool idfull = true;
            int count = 0;
            try
            {
                while (idfull)
                {
                    count++;
                    string hg;
                    hg = "SELECT `" + selectInfo + "` FROM `" + table + "` WHERE `" + idattribute + "` = '" + count + "'";
                    DataBase.msCommand.CommandText = hg; //form from ошибка в БД place place idplace
                    Object idform_rs = DataBase.msCommand.ExecuteScalar();
                    if (idform_rs != null)
                    {
                        string a = idform_rs.ToString();

                        comboBox.Items.Add(a);
                    }
                    else
                    {
                        idfull = false;
                    }
                }
            }
            catch
            {
                idfull = false;
            }
        }
        //comboBox1.GetItemText(comboBox1.SelectedText);
        public int LastID()
        {
            int p = 0;
            int count = 1;
            try
            {
                while (true)
                {
                    string hg;
                    hg = "SELECT `iddelivery` FROM `delivery` WHERE `iddelivery` = '" + count + "'";
                    DataBase.msCommand.CommandText = hg; //form from ошибка в БД place place idplace
                    Object idform_rs = DataBase.msCommand.ExecuteScalar();
                    count++;
                    if (idform_rs != null)
                    {
                        string a = idform_rs.ToString();
                        p = Int32.Parse(a);
                    }
                    else
                    {
                        return p;
                        break;
                    }

                }
            }
            catch
            {
                return p;
                MessageBox.Show("Ошибка с внесение данных");
            }
        }
        public void InsertData(int iddelivery, string idform, string idto, string status, string idthing,string description)
        {

            string hg;
            if (iddelivery != 0  && idform !="0" && idto != "0" && status != "0" && idthing != "0") { 
            hg = "INSERT INTO `delivery` (iddelivery, idform, idto, status, idthing,description) VALUES ('" + iddelivery + "', '" + idform + "', '" + idto + "', '" + status + "','" + idthing + "','" + description + "')";
            DataBase.msCommand.CommandText = hg;
            Object idform_rs = DataBase.msCommand.ExecuteScalar();
            MessageBox.Show("Товар успешно внесён");
            }
            else
            {
                MessageBox.Show("Не все данные указаны");
            }
            
        }

        public string NameToId(string selectInfo, string table, string idattribute, string name)
        {
            string hg;
            hg = "SELECT `" + selectInfo + "` FROM `" + table + "` WHERE `" + idattribute + "` = '" + name + "'";
            DataBase.msCommand.CommandText = hg; //form from ошибка в БД place place idplace
            Object idform_rs = DataBase.msCommand.ExecuteScalar();
            if (idform_rs != null) {
                return idform_rs.ToString();
            }
            else
            {
                return "0";
            }
            
        }

        private void GeneratorButton_Click(object sender, EventArgs e)
        {
            string From, To, Thing, Status , Description;
            string idFrom, idTo, idThing, idStatus;
            int IdDelivery = LastID() + 1;
            From = comboBox1.Text;
            To = comboBox2.Text;
            Thing = comboBox3.Text;
            Status = comboBox4.Text;
            Description =richTextBox1.Text;
            idFrom = NameToId("idplace", "place", "place", From);
            idTo = NameToId("idplace", "place", "place", To);
            idThing = NameToId("idthing", "thing", "name", Thing);
            idStatus = NameToId("idstatus", "status", "name", Status);
            InsertData(IdDelivery, idFrom, idTo, idThing, idStatus , Description);


            BarcodeWriter writer = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            writer.Renderer = new BitmapRenderer();
            writer.Options = encodingOptions;
            writer.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = writer.Write(IdDelivery.ToString());
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scan_QR scan_QR = new Scan_QR();
            scan_QR.Show();
        }
    }
}








