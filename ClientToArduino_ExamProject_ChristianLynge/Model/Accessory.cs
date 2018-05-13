using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientToArduino_ExamProject_ChristianLynge.Model
{
    class Accessory
    {
        private ArduinoProtocol protocol = new ArduinoProtocol();
        private string address = "";
        private bool isOn = false;

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void switchState()
        {
            isOn = !isOn;
        }

        public string assembleAccMsg ()
        {
            return protocol.setAcc(getAddress(), isOn);
        }

        private UInt16 getAddress()
        {
            try
            {
                return Convert.ToUInt16(address);
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}
