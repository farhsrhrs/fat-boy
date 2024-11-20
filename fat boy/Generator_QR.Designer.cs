namespace fat_boy
{
    partial class Generator_QR
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
            pictureBox1 = new PictureBox();
            QRInput = new TextBox();
            GeneratorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // QRInput
            // 
            QRInput.Location = new Point(12, 329);
            QRInput.Name = "QRInput";
            QRInput.Size = new Size(300, 23);
            QRInput.TabIndex = 1;
            // 
            // GeneratorButton
            // 
            GeneratorButton.Location = new Point(337, 329);
            GeneratorButton.Name = "GeneratorButton";
            GeneratorButton.Size = new Size(75, 23);
            GeneratorButton.TabIndex = 2;
            GeneratorButton.Text = "Создать";
            GeneratorButton.UseVisualStyleBackColor = true;
            GeneratorButton.Click += GeneratorButton_Click;
            // 
            // Generator_QR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GeneratorButton);
            Controls.Add(QRInput);
            Controls.Add(pictureBox1);
            Name = "Generator_QR";
            Text = "Generator_QR";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox QRInput;
        private Button GeneratorButton;
    }
}