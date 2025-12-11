using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Proyecto_HMI_tem_y_H_y_led
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1;
        bool leerSensores = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1 = new SerialPort();
            serialPort1.DataReceived +=
                serialPort1_DataReceived;
            string[] puertos = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(puertos);

            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("115200");
            comboBox2.SelectedIndex = 0;

            label9.Text = "----ºC";
            label10.Text = "----%";

            if (serialPort1.IsOpen) serialPort1.Close();
        }
        private void EnviarComando(string letra)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(letra);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate =
                        int.Parse(comboBox2.Text);
                    serialPort1.Open();

                    button1.Text = "Desconectar";
                    button1.BackColor = Color.LightGreen;
                }
                else
                {
                    serialPort1.Close();
                    button1.Text = "Conectar";
                    button1.BackColor = DefaultBackColor;
                    leerSensores = false;
                }
            }
            catch
            {
                button1.Text = "Conectar";
                button1.BackColor = DefaultBackColor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(puertos);
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnviarComando("R");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnviarComando("G");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnviarComando("B");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnviarComando("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                leerSensores = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            leerSensores = false;
            label9.Text = "----ºC";
            label10.Text = "----%";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            Application.Exit();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (leerSensores)
            {
                try
                {
                    string datosRecibidos = serialPort1.ReadLine();
                    this.Invoke(new MethodInvoker(delegate
                   {
                       string[] partes = datosRecibidos.Split(',');
                       if (partes.Length >= 2)
                       {
                           label9.Text = partes[0].Trim() + "ºC";
                           label10.Text = partes[1].Trim() + "%";
                       }
                   }));
                }
                catch
                {

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}