namespace Arduino_VS_practica_2
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
            HumedadLabel = new Label();
            TemperaturaLabel = new Label();
            botonConectar = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // HumedadLabel
            // 
            HumedadLabel.AutoSize = true;
            HumedadLabel.Location = new Point(101, 365);
            HumedadLabel.Name = "HumedadLabel";
            HumedadLabel.Size = new Size(88, 15);
            HumedadLabel.TabIndex = 2;
            HumedadLabel.Text = "HumedadLabel";
            // 
            // TemperaturaLabel
            // 
            TemperaturaLabel.AutoSize = true;
            TemperaturaLabel.Location = new Point(100, 174);
            TemperaturaLabel.Name = "TemperaturaLabel";
            TemperaturaLabel.Size = new Size(102, 15);
            TemperaturaLabel.TabIndex = 3;
            TemperaturaLabel.Text = "TemperaturaLabel";
            // 
            // botonConectar
            // 
            botonConectar.Location = new Point(82, 401);
            botonConectar.Name = "botonConectar";
            botonConectar.Size = new Size(137, 32);
            botonConectar.TabIndex = 4;
            botonConectar.Text = "Conectar";
            botonConectar.UseVisualStyleBackColor = true;
            botonConectar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(660, 397);
            button2.Name = "button2";
            button2.Size = new Size(117, 41);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(344, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(414, 319);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(botonConectar);
            Controls.Add(TemperaturaLabel);
            Controls.Add(HumedadLabel);
            Name = "Form1";
            Text = "Temperatura y Humedad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label HumedadLabel;
        private Label TemperaturaLabel;
        private Button botonConectar;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listBox1;
    }
}
