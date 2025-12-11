namespace Proyecto_HMI_tem_y_H_y_led
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button8 = new Button();
            button7 = new Button();
            label3 = new Label();
            panel4 = new Panel();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(25, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 53);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 21);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 0;
            label4.Text = "Leonardo E. Santos";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(244, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 53);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(504, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(159, 13);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 0;
            label1.Text = "Proyecto Panel de Control";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Desktop;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(583, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 212);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(96, 115);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 6;
            label10.Text = "----";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(102, 66);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 5;
            label9.Text = "----";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(25, 114);
            label8.Name = "label8";
            label8.Size = new Size(72, 17);
            label8.TabIndex = 4;
            label8.Text = "Humedad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(15, 64);
            label7.Name = "label7";
            label7.Size = new Size(94, 17);
            label7.TabIndex = 3;
            label7.Text = "Temperatura: ";
            // 
            // button8
            // 
            button8.Location = new Point(102, 174);
            button8.Name = "button8";
            button8.Size = new Size(88, 23);
            button8.TabIndex = 2;
            button8.Text = "Desconectar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(16, 174);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 1;
            button7.Text = "Conectar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(3, 15);
            label3.Name = "label3";
            label3.Size = new Size(199, 21);
            label3.TabIndex = 0;
            label3.Text = "Temperatura y Humedad";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(25, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(213, 212);
            panel4.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(19, 176);
            button2.Name = "button2";
            button2.Size = new Size(110, 26);
            button2.TabIndex = 5;
            button2.Text = "Actualizar puerto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 147);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(19, 107);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(19, 77);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 1;
            label6.Text = "Tasa de Baudios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(19, 21);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 0;
            label5.Text = "Puerto de Comunicacion";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Desktop;
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(244, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 212);
            panel5.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(253, 77);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(33, 66);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(101, 77);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(168, 76);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(233, 136);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 4;
            button6.Text = "Apagar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(159, 136);
            button5.Name = "button5";
            button5.Size = new Size(68, 23);
            button5.TabIndex = 3;
            button5.Text = "luz roja";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(96, 136);
            button4.Name = "button4";
            button4.Size = new Size(57, 23);
            button4.TabIndex = 2;
            button4.Text = "luz Azul";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 136);
            button3.Name = "button3";
            button3.Size = new Size(67, 23);
            button3.TabIndex = 1;
            button3.Text = "Luz verde";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(104, 21);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 0;
            label2.Text = "Control Digital";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label1;
        private Button button8;
        private Button button7;
        private Label label3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
