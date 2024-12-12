namespace Project
{
    partial class transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaction));
            label5 = new Label();
            cash = new TextBox();
            panel1 = new Panel();
            calculatebutton = new Button();
            pictureBox1 = new PictureBox();
            total = new Label();
            change = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 112);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 4;
            label5.Text = "Total :";
            // 
            // cash
            // 
            cash.Location = new Point(93, 173);
            cash.Name = "cash";
            cash.Size = new Size(91, 23);
            cash.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(calculatebutton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(total);
            panel1.Controls.Add(change);
            panel1.Controls.Add(cash);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 337);
            panel1.TabIndex = 6;
            // 
            // calculatebutton
            // 
            calculatebutton.Location = new Point(190, 173);
            calculatebutton.Name = "calculatebutton";
            calculatebutton.Size = new Size(55, 23);
            calculatebutton.TabIndex = 8;
            calculatebutton.Text = "Done";
            calculatebutton.UseVisualStyleBackColor = true;
            calculatebutton.Click += calculatebutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(82, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 75);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(150, 117);
            total.Name = "total";
            total.Size = new Size(34, 15);
            total.TabIndex = 6;
            total.Text = "00.00";
            // 
            // change
            // 
            change.AutoSize = true;
            change.Location = new Point(150, 260);
            change.Name = "change";
            change.Size = new Size(34, 15);
            change.TabIndex = 6;
            change.Text = "00.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 254);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 4;
            label2.Text = "Change :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 175);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 4;
            label1.Text = "Cash : ";
            // 
            // transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(panel1);
            Name = "transaction";
            Text = "transaction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private TextBox cash;
        private Panel panel1;
        private Label change;
        private Label label2;
        private Label label1;
        private Label total;
        private PictureBox pictureBox1;
        private Button calculatebutton;
    }
}