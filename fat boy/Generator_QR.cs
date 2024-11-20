using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace fat_boy
{
    public partial class Generator_QR : Form
    {
        public Generator_QR()
        {
            InitializeComponent();
        }

        private void GeneratorButton_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300,Margin =0,PureBarcode =false};
            writer.Renderer = new BitmapRenderer();
            writer.Options = encodingOptions;
            writer.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = writer.Write(QRInput.Text);
            pictureBox1.Image = bitmap;
        }
    }
}
