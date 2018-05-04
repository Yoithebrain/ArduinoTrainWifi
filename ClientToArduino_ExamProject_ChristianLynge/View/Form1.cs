using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace ClientToArduino_ExamProject_ChristianLynge
{
    public partial class Form1 : Form
    {
        Model.Serialport _serialport = new Model.Serialport();
        //Model.clientUDP client = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //SerialPort serialPort = new SerialPort("COM1", 115200);
            //serialPort1 = serialPort;
            //serialPort1.Open();
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void textboxInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            //client.sendData(textboxInput.Text);
            Console.WriteLine("Connecting...");
            string port = comboBox1.SelectedItem.ToString();
            _serialport.connect(port);

            //String data = 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
