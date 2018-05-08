﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;

namespace ClientToArduino_ExamProject_ChristianLynge.Model
{

    class Serialport
    {
        SerialPort _myserialPort = null;
        
        
        public void connect(String _port)
        {
            var port = new SerialPort(_port);
            if (!port.IsOpen)
            {
                //Need to have this refactored, the big issue is not having any object that can keep the port open for longer
                //periods of time rather than one or two statements
                Console.Write("Port is " + port);
                port.BaudRate = 9600;
                port.Open();
                port.WriteLine("Hello;");
                Console.WriteLine("Port is now open and ready to send stuff");
                Console.Write(""+port.ReadLine());
                port.Close();
            }
            else
            {
                Console.WriteLine("port is already in use");
            }
        }
        
    }
}
