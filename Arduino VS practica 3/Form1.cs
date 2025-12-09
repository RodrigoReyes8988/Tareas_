using System;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;

namespace Arduino_VS_practica_3
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isBlinking;
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();

            serialPort = new SerialPort("COM5", 9600);

            // Evento para leer datos del sensor
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Evento del botón comenzar
            botonComenzar.Click += botonComenzar_Click;

            // Timer del parpadeo
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;

            // Archivo de sonido CORRECTO (modifica si tu ruta es distinta)
            soundPlayer = new SoundPlayer(@"C:\Users\gogca\Downloads\liquid_water\liquid_water.wav");
        }

        // Cerrar puerto al cerrar la app
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        // MÉTODO FALTANTE ? este causaba el error
        private void botonComenzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                    serialPort.Open();

                isBlinking = false;
                pictureBox1.BackColor = System.Drawing.Color.Gray;
          
            }
            catch (Exception ex)
            {
            }
        }

        // Cuando llega un dato del sensor
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine().Trim();

            this.Invoke(new Action(() =>
            {
                label1.Text = "Sensor Status: " + (data == "0" ? "Water Detected" : "No Water");

                if (data == "0")
                {
                    if (!isBlinking)
                    {
                        soundPlayer.PlayLooping();
                        timer1.Start();
                        pictureBox1.BackColor = System.Drawing.Color.Yellow;
                        isBlinking = true;
                    }
                }
                else
                {
                    if (isBlinking)
                    {
                        soundPlayer.Stop();
                        timer1.Stop();
                        pictureBox1.BackColor = System.Drawing.Color.Gray;
                        isBlinking = false;
                    }
                }
            }));
        }

        // Parpadeo del indicador
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor =
                (pictureBox1.BackColor == System.Drawing.Color.Gray)
                ? System.Drawing.Color.Yellow
                : System.Drawing.Color.Gray;
        }

        // Botón salir
        private void Salir_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();

            Application.Exit();
        }
    }
}
