﻿using System;
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
        
        public Form1()
        {
            Model.clientUDP myCon = new Model.clientUDP();
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void textboxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
