using System;
using System.IO.Ports;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace Arduino_VS_practica_2
{
    public partial class Form1 : Form
    {
        SerialPort puerto = new SerialPort();
        bool conectado = false;
        public Form1()
        {
            InitializeComponent();

            puerto.BaudRate = 9600;
            puerto.PortName = "COM5";
            puerto.DataReceived += Puerto_DataReceived;
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = puerto.ReadLine().Trim();
                string[] partes = data.Split(',');
                if (partes.Length == 2)
                {
                    string temp = partes[0];
                    string hum = partes[1];
                    this.Invoke(new Action(() =>
                    {
                        TemperaturaLabel.Text = "Temperatura: " + temp + "ºC";
                        HumedadLabel.Text = "Humedad: " + hum + "%";

                        listBox1.Items.Add("Temp: " + temp + "ºC  , Hum: " + hum + "%");
                    }));
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                try
                {
                    puerto.Open();
                    conectado = true;
                    botonConectar.Text = "Desconectar";
                }
                catch
                {
                    MessageBox.Show("No se pudo abrir el puerto COM6");
                }
            }
            else
            {
                if (puerto.IsOpen)
                    puerto.Close();

                conectado = false;
                botonConectar.Text = "Conectar";

                TemperaturaLabel.Text = "Temperatura: ";
                HumedadLabel.Text = "Humedad: ";
                listBox1.Items.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (puerto.IsOpen)
                puerto.Close();
            Application.Exit();
        }
    }
}