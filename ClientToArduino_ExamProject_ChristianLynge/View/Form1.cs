using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ClientToArduino_ExamProject_ChristianLynge
{
    public partial class Form1 : Form
    {
        Model.clientUDP client = null;
        public Form1()
        {
            
            
            InitializeComponent();
            if (client == null)
            {
                client = new Model.clientUDP();
                client.ConnectClient();
            }
            else
            {
                Console.WriteLine("Client already loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (client == null)
            //{
              //  client = new Model.clientUDP();
               // client.ConnectClient();
            //} else
            //{
            //    Console.WriteLine("Client already loaded");
           // }
        }

        private void textboxInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            client.sendData(textboxInput.Text);
        }
    }
}
