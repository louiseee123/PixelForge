namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            maskedpassword = new MaskedTextBox();
            createacc = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            login = new Button();
            textuser = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedpassword);
            panel1.Controls.Add(createacc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(login);
            panel1.Controls.Add(textuser);
            panel1.ForeColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(294, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 426);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(131, 107);
            label4.Name = "label4";
            label4.Size = new Size(247, 37);
            label4.TabIndex = 6;
            label4.Text = "Welcome Back";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(145, 350);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 5;
            label3.Text = "Don't have an account?";
            // 
            // maskedpassword
            // 
            maskedpassword.BackColor = SystemColors.ScrollBar;
            maskedpassword.Cursor = Cursors.IBeam;
            maskedpassword.Location = new Point(136, 257);
            maskedpassword.Name = "maskedpassword";
            maskedpassword.PasswordChar = '*';
            maskedpassword.Size = new Size(235, 23);
            maskedpassword.TabIndex = 4;
            // 
            // createacc
            // 
            createacc.AutoSize = true;
            createacc.Cursor = Cursors.Hand;
            createacc.Location = new Point(273, 350);
            createacc.Name = "createacc";
            createacc.Size = new Size(73, 15);
            createacc.TabIndex = 3;
            createacc.TabStop = true;
            createacc.Text = "Sign up here";
            createacc.LinkClicked += createacc_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(221, 239);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(221, 191);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // login
            // 
            login.BackColor = SystemColors.Control;
            login.Cursor = Cursors.Hand;
            login.ForeColor = Color.Black;
            login.Location = new Point(208, 303);
            login.Name = "login";
            login.Size = new Size(88, 31);
            login.TabIndex = 1;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // textuser
            // 
            textuser.BackColor = SystemColors.ScrollBar;
            textuser.Cursor = Cursors.IBeam;
            textuser.Location = new Point(136, 209);
            textuser.Name = "textuser";
            textuser.Size = new Size(235, 23);
            textuser.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 426);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(117, 330);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(175, 330);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(63, 330);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(34, 218);
            label5.Name = "label5";
            label5.Size = new Size(205, 15);
            label5.TabIndex = 10;
            label5.Text = "The best Gaming Shop in town.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(47, 180);
            label8.Name = "label8";
            label8.Size = new Size(183, 37);
            label8.TabIndex = 9;
            label8.Text = "PixelForge";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(63, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button login;
        private TextBox textuser;
        private LinkLabel createacc;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedpassword;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
