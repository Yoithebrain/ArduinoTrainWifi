using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;
using System.Threading;
using System.IO;

namespace ClientToArduino_ExamProject_ChristianLynge.Model
{

    class Serialport
    {
        string portName = "";
        SerialPort port = null;
        ArduinoProtocol protocol = new ArduinoProtocol();
        Queue msgQueue = new Queue();
        
        public Serialport()
        {
            Thread thread = new Thread(handleIO);
            //thread.IsBackground = true;
            thread.Start();
        }

        private void handleIO()
        {
            while (true)
            {
                if (msgQueue.Count != 0) // if queue has any messages
                {
                    string msg = msgQueue.Dequeue().ToString();
                    if (this.connect())
                    {
                        Console.WriteLine("Sending: \"" + msg + "\", Port open: " + port.IsOpen + ".");
                        port.WriteLine(msg);
                        Console.WriteLine("Message send.");
                        this.listen();
                    }
                }
                else
                {
                    try
                    {
                        if (port.IsOpen)
                        {
                            port.Close();
                            Console.WriteLine("Port closed.");
                        }
                    }
                    catch (Exception){}
                }
            }
        }

        public void sendMessage(string msg, string _port) // adds message to queue
        {
            portName = _port;
            msgQueue.Enqueue(msg);
        }

        private bool connect() // opens port if not already open
        {
            if (port == null || !port.IsOpen)
            {
                try
                {
                    port = new SerialPort(portName);
                    port.BaudRate = 115200;
                    //port.ReadTimeout = 100;
                    port.Encoding = System.Text.Encoding.UTF8;
                }
                catch (IOException)
                {
                    Console.WriteLine("Port not found.");
                    return false;
                }
                
                try
                {
                    port.Open();
                    Console.WriteLine("Port open: " + port + ".");
                    return true;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Couldn't open port: Access denied.");
                }
                catch (IOException)
                {
                    Console.WriteLine("Couldn't open port: Invalid port state.");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Couldn't open port: Already open.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Couldn't open port: Lazy error.");
                }
                return false;
            }
            return true;
        }

        private void listen() // listens for response
        {
            Console.WriteLine("Listening...");
            String msg = "";

            while (true)
            {
                //Console.WriteLine((char)port.ReadChar());
                //Console.WriteLine("helo");
                Console.WriteLine(port.ReadLine());
            }

            /*while (true)
            {
                string msgpart = null;

                try
                {
                    msgpart = Convert.ToString((char)port.ReadChar());
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Serial read failed: port not open.");
                    break;
                }
                catch (TimeoutException e)
                {
                    Console.WriteLine("Serial read failed: timed out.");
                    break;
                }

                if (msgpart != null)
                {
                    if (msgpart == "{")
                        msg = "";
                    msg += msgpart;
                    if (msgpart == "}")
                    {
                        Console.WriteLine("Received from Arduino: \"" + msg + "\".");
                        break;
                    }
                }
            }
            Console.WriteLine("Stopped listening.");*/
        }
    }
}
