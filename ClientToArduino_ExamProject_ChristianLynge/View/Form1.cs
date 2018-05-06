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
        Model.Serialport sp = new Model.Serialport();
        Model.ArduinoProtocol protocol = new Model.ArduinoProtocol();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void textboxInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string port = comboBox1.SelectedItem.ToString();
            string msg = textboxInput.Text;
            sp.sendMessage(protocol.customMsg(msg), port);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
