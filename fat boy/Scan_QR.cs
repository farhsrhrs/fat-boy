using AForge.Video.DirectShow;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using ZXing.Windows.Compatibility;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fat_boy
{
    public partial class Scan_QR : Form
    {

        public Scan_QR()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        private void Scan_QR_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FilterInfoCollection)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                textBox1.Invoke(new MethodInvoker(async delegate ()
                    {
                        textBox1.Text = result.ToString();
                        IDdelivery.Text = result.ToString();
                        //Namething.Text;
                        ViwerInfo(result.ToString());


                    }));


            }
            pictureBox1.Image = bitmap;
        }

        private void Scan_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                    VideoCaptureDevice.Stop();
            }
        }
        public void ViwerInfo(string iddelivery)
        {


           


            try
            {
                DataBase.msCommand.CommandText = "SELECT `name` FROM `delivery`,`thing` WHERE `iddelivery` = '" + iddelivery + "'"+ "AND delivery.idthing = thing.idthing";
                Object idthing_rs = DataBase.msCommand.ExecuteScalar();
                Namething.Text = idthing_rs.ToString();

                DataBase.msCommand.CommandText = "SELECT `place` FROM `delivery`,`place` WHERE `iddelivery` = '" + iddelivery + "'"+ "AND delivery.idform=place.idplace";//form from ошибка в БД
                Object idform_rs = DataBase.msCommand.ExecuteScalar();
                FROM.Text = idform_rs.ToString();

                DataBase.msCommand.CommandText = "SELECT `place` FROM `delivery`,`place` WHERE `iddelivery` = '" + iddelivery + "'" + "AND delivery.idto=place.idplace";
                Object idto_rs = DataBase.msCommand.ExecuteScalar();
                TO.Text = idto_rs.ToString();

                DataBase.msCommand.CommandText = "SELECT `name` FROM `delivery`,`status` WHERE `iddelivery` = '" + iddelivery + "'" + "AND delivery.status=status.idstatus";
                Object status_rs = DataBase.msCommand.ExecuteScalar();
                Status.Text = status_rs.ToString();


            }
            catch
            {
                //Role = null;
                MessageBox.Show("Ошибка данных");
                







            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generator_QR generator_QR = new Generator_QR();
            generator_QR.Show();
        }

    } 
}
