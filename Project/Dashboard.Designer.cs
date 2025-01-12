namespace Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            button2 = new Button();
            managebut = new Button();
            name = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            prodtext = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            transacbut = new Button();
            paytext = new TextBox();
            price = new Label();
            label3 = new Label();
            panel4 = new Panel();
            list = new Label();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(managebut);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(649, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 437);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(130, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // managebut
            // 
            managebut.Cursor = Cursors.Hand;
            managebut.FlatStyle = FlatStyle.System;
            managebut.Location = new Point(17, 240);
            managebut.Name = "managebut";
            managebut.Size = new Size(75, 23);
            managebut.TabIndex = 5;
            managebut.Text = "Manage";
            managebut.UseVisualStyleBackColor = true;
            managebut.Click += managebut_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = Color.DodgerBlue;
            name.Location = new Point(61, 197);
            name.Name = "name";
            name.Size = new Size(112, 22);
            name.TabIndex = 3;
            name.Text = "fname here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(74, 194);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 173);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 3;
            label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(17, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 154);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(230, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // prodtext
            // 
            prodtext.Cursor = Cursors.IBeam;
            prodtext.Location = new Point(14, 37);
            prodtext.Name = "prodtext";
            prodtext.Size = new Size(210, 23);
            prodtext.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(prodtext);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 72);
            panel2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 13);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 16;
            label4.Text = "Enter Product Barcode";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(transacbut);
            panel3.Controls.Add(paytext);
            panel3.Location = new Point(232, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 65);
            panel3.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 5);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 16;
            label6.Text = "Enter Payment Amount";
            // 
            // transacbut
            // 
            transacbut.Cursor = Cursors.Hand;
            transacbut.FlatStyle = FlatStyle.System;
            transacbut.Location = new Point(290, 25);
            transacbut.Name = "transacbut";
            transacbut.Size = new Size(75, 23);
            transacbut.TabIndex = 4;
            transacbut.Text = "Start";
            transacbut.UseVisualStyleBackColor = true;
            transacbut.Click += transacbut_Click;
            // 
            // paytext
            // 
            paytext.Cursor = Cursors.IBeam;
            paytext.Location = new Point(45, 26);
            paytext.Name = "paytext";
            paytext.Size = new Size(210, 23);
            paytext.TabIndex = 11;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(119, 20);
            price.Name = "price";
            price.Size = new Size(40, 21);
            price.TabIndex = 0;
            price.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(list);
            panel4.Location = new Point(12, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(631, 288);
            panel4.TabIndex = 20;
            // 
            // list
            // 
            list.AutoSize = true;
            list.Location = new Point(14, 14);
            list.Name = "list";
            list.Size = new Size(0, 15);
            list.TabIndex = 0;
            list.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(17, 307);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(170, 307);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(95, 307);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 20);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 3;
            label5.Text = "Total :";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(price);
            panel5.Location = new Point(12, 384);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 65);
            panel5.TabIndex = 21;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            CausesValidation = false;
            ClientSize = new Size(884, 461);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label name;
        private Button button1;
        private TextBox prodtext;
        private Panel panel2;
        private Label label4;
        private Button managebut;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label list;
        private Label price;
        private Button transacbut;
        private TextBox paytext;
        private Label label6;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel5;
    }
}