using System.IO.Ports;
using System.Runtime.InteropServices.Marshalling;

namespace Arduino_VS_practica_1
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;

        //SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
        
        Arduino=new System.IO.Ports.SerialPort();
        Arduino = new SerialPort("COM6",9600);// Asegurate de que el puerto COM sea correcto

        Arduino.Open();
            }
        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");// Enviar señal para apagar el LED
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");// Enviar señal para encender el LED
        }
    }
}
