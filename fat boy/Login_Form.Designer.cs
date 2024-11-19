namespace fat_boy
{
    partial class Login_Form
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
            PasswordFielde = new TextBox();
            panel1 = new Panel();
            Sing_In = new Button();
            pictureBox2 = new PictureBox();
            LoginFielde = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PasswordFielde
            // 
            PasswordFielde.Font = new Font("Segoe UI", 26F);
            PasswordFielde.Location = new Point(112, 189);
            PasswordFielde.Name = "PasswordFielde";
            PasswordFielde.PasswordChar = '*';
            PasswordFielde.Size = new Size(278, 54);
            PasswordFielde.TabIndex = 6;
            PasswordFielde.UseSystemPasswordChar = true;
            PasswordFielde.TextChanged += PasswordFielde_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(PasswordFielde);
            panel1.Controls.Add(Sing_In);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(LoginFielde);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 418);
            panel1.TabIndex = 0;
            panel1.Paint += Panel1_Paint;
            // 
            // Sing_In
            // 
            Sing_In.Font = new Font("Segoe UI", 14F);
            Sing_In.Location = new Point(143, 328);
            Sing_In.Name = "Sing_In";
            Sing_In.Size = new Size(158, 50);
            Sing_In.TabIndex = 5;
            Sing_In.Text = "Войти";
            Sing_In.UseVisualStyleBackColor = true;
            Sing_In.Click += Sing_In_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources._3643755_hide_lock_locked_padlock_private_icon;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(42, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // LoginFielde
            // 
            LoginFielde.Font = new Font("Segoe UI", 26F);
            LoginFielde.Location = new Point(112, 100);
            LoginFielde.Name = "LoginFielde";
            LoginFielde.Size = new Size(278, 54);
            LoginFielde.TabIndex = 2;
            LoginFielde.TextChanged += TextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources._10758973_user_icon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(42, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 40F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 61);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += Label1_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 418);
            Controls.Add(panel1);
            Name = "Login_Form";
            Text = "Login_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox LoginFielde;
        private PictureBox pictureBox1;
        
        private PictureBox pictureBox2;
        private Button Sing_In;
        private TextBox PasswordFielde;
    }
}