using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ClientToArduino_ExamProject_ChristianLynge.Model
{
   
    class clientUDP
    {
        private Socket clientSocket = null;
        private Boolean run = false;
        IPAddress ipadress = IPAddress.Parse("127.0.0.1");
        IPEndPoint arduinoRemote = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
       public void ConnectClient()
        {
             
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                clientSocket.Connect(arduinoRemote);
                run = true;
                
            }
            catch (Exception e)
            {
                run = false;
                Console.WriteLine("Something went wrong with the connection: " + e);
                //return null;
            }
        }

       public void sendData(string s)
        {
            byte[] bytesrecv;
            String textToSend = s;
            byte[] msg = Encoding.ASCII.GetBytes(s);
            int bytesSent = clientSocket.Send(msg);
            int bytesRec = clientSocket.Receive(bytesrecv = new byte[1024]);
            String bytetoString = System.Text.Encoding.ASCII.GetString(bytesrecv);
            Console.WriteLine("msg from server: " +bytetoString);

        }
    }
}
