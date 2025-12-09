namespace Arduino_VS_practica_3
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            botonComenzar = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 37);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 0;
            label1.Text = "Sensor Lluvia FC-37 o YL-83";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(51, 113);
            label2.Name = "label2";
            label2.Size = new Size(237, 30);
            label2.TabIndex = 1;
            label2.Text = "Sensor Status: No Water";
            // 
            // botonComenzar
            // 
            botonComenzar.BackColor = Color.Red;
            botonComenzar.ForeColor = Color.White;
            botonComenzar.Location = new Point(110, 168);
            botonComenzar.Name = "botonComenzar";
            botonComenzar.Size = new Size(83, 30);
            botonComenzar.TabIndex = 2;
            botonComenzar.Text = "Comenzar";
            botonComenzar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(97, 244);
            button2.Name = "button2";
            button2.Size = new Size(87, 26);
            button2.TabIndex = 3;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.Location = new Point(513, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 215);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(botonComenzar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button botonComenzar;
        private Button button2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
