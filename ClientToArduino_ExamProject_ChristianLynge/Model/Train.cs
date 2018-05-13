using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientToArduino_ExamProject_ChristianLynge.Model
{
    class Train
    {
        private ArduinoProtocol protocol = new ArduinoProtocol();
        private string address = "0";
        private bool dirForward = true;
        private UInt16 speed = 0;
        private bool eStop = false;
        private bool lightsOn = false;
        private bool soundOn = false;
        private bool bellOn = false;
        private bool horn1On = false;
        private bool horn2On = false;

        public void setAddress(string address)
        {
            this.address = address;
        }
        public string toggleDir()
        {
            if (dirForward)
            {
                dirForward = !dirForward;
                return "dir: backward";
            }
            else
            {
                dirForward = !dirForward;
                return "dir: forward";
            }
        }
        public string increaseSpeed()
        {
            if (speed < 14)
            {
                speed++;
            }
            return "" + speed;
        }
        public string decreaseSpeed()
        {
            if (speed > 0)
            {
                speed--;
            }
            return "" + speed;
        }
        public string toggleLights()
        {
            if (lightsOn)
            {
                lightsOn = !lightsOn;
                return "Lights: off";
            }
            else
            {
                lightsOn = !lightsOn;
                return "Lights: on";
            }
        }
        public string toggleEStop()
        {
            if (eStop)
            {
                eStop = !eStop;
                return "STOP!!";
            }
            else
            {
                eStop = !eStop;
                return "Start!!";
            }
        }
        public string toggleSound()
        {
            if (soundOn)
            {
                soundOn = !soundOn;
                return "Sound: off";
            }
            else
            {
                soundOn = !soundOn;
                return "Sound: on";
            }
        }
        public string toggleBell()
        {
            if (bellOn)
            {
                bellOn = !bellOn;
                return "Bell: off";
            }
            else
            {
                bellOn = !bellOn;
                return "Bell: on";
            }
        }
        public string toggleHorn1()
        {
            if (horn1On)
            {
                horn1On = !horn1On;
                return "Horn1: off";
            }
            else
            {
                horn1On = !horn1On;
                return "Horn1: on";
            }
        }
        public string toggleHorn2()
        {
            if (horn2On)
            {
                horn2On = !horn2On;
                return "Horn2: off";
            }
            else
            {
                horn2On = !horn2On;
                return "Horn2: on";
            }
        }

        public string assembleGetSpeed()
        {
            return protocol.getSpeed(getAddress());
        }
        public string assembleSetSpeed()
        {
            Console.WriteLine("Address: " + getAddress());
            return protocol.setSpeed(getAddress(), getSpeed(), getDir());
        }
        public string assembleGetEffect()
        {
            return protocol.customMsg("unfinnished business");
        }
        public string assembleSetEffect()
        {
            return protocol.customMsg("unfinnished business");
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
        private UInt16 getDir()
        {
            return Convert.ToUInt16(dirForward);
        }
        private UInt16 getSpeed()
        {
            if (eStop)
            {
                return 1;
            }
            else if (speed == 0)
            {
                return speed;
            }
            else
            {
                return Convert.ToUInt16(speed + 1);
            }
        }
        private UInt16 getEStop()
        {
            return Convert.ToUInt16(eStop);
        }
        private UInt16 getLights()
        {
            return Convert.ToUInt16(lightsOn);
        }
        private UInt16 getSound()
        {
            return Convert.ToUInt16(soundOn);
        }
        private UInt16 getBell()
        {
            return Convert.ToUInt16(bellOn);
        }
        private UInt16 getGetHorn1()
        {
            return Convert.ToUInt16(horn1On);
        }
        private UInt16 getGetHorn2()
        {
            return Convert.ToUInt16(horn2On);
        }
    }
}
