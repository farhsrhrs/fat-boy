namespace fat_boy
{
    partial class Scan_QR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IDdelivery = new Label();
            Namething = new Label();
            FROM = new Label();
            TO = new Label();
            Status = new Label();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            description = new Label();
            label10 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 16);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Выбор камеры";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(39, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 346);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 407);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(405, 407);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 5;
            button1.Text = "Включить камеру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(685, 407);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 6;
            button2.Text = "Создать QRcode";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 56);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 80);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Thing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 104);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "From";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 128);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 10;
            label6.Text = "To";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 152);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // IDdelivery
            // 
            IDdelivery.AutoSize = true;
            IDdelivery.Location = new Point(463, 56);
            IDdelivery.Name = "IDdelivery";
            IDdelivery.Size = new Size(38, 15);
            IDdelivery.TabIndex = 12;
            IDdelivery.Text = "label8";
            // 
            // Namething
            // 
            Namething.AutoSize = true;
            Namething.Location = new Point(463, 80);
            Namething.Name = "Namething";
            Namething.Size = new Size(38, 15);
            Namething.TabIndex = 13;
            Namething.Text = "label8";
            // 
            // FROM
            // 
            FROM.AutoSize = true;
            FROM.Location = new Point(463, 105);
            FROM.Name = "FROM";
            FROM.Size = new Size(38, 15);
            FROM.TabIndex = 14;
            FROM.Text = "label8";
            // 
            // TO
            // 
            TO.AutoSize = true;
            TO.Location = new Point(463, 128);
            TO.Name = "TO";
            TO.Size = new Size(38, 15);
            TO.TabIndex = 15;
            TO.Text = "label8";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(463, 152);
            Status.Name = "Status";
            Status.Size = new Size(38, 15);
            Status.TabIndex = 16;
            Status.Text = "label8";
            // 
            // button3
            // 
            button3.Location = new Point(414, 250);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 17;
            button3.Text = "Изменить данные";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(487, 279);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 23);
            comboBox2.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 282);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 19;
            label8.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 176);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 20;
            label9.Text = "Description";
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(487, 176);
            description.Name = "description";
            description.Size = new Size(38, 15);
            description.TabIndex = 21;
            description.Text = "label8";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 311);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 22;
            label10.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(487, 311);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 74);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // Scan_QR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label10);
            Controls.Add(description);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(Status);
            Controls.Add(TO);
            Controls.Add(FROM);
            Controls.Add(Namething);
            Controls.Add(IDdelivery);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Scan_QR";
            Text = "Form2";
            FormClosing += Scan_QR_FormClosing;
            Load += Scan_QR_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label IDdelivery;
        private Label Namething;
        private Label FROM;
        private Label TO;
        private Label Status;
        private Button button3;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
        private Label description;
        private Label label10;
        private RichTextBox richTextBox1;
    }
}