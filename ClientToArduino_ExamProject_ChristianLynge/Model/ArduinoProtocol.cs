using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientToArduino_ExamProject_ChristianLynge.Model
{
    class ArduinoProtocol
    {
        public string customMsg( string msg)
        {
            return "{" + msg + "}";
        }

        #region Train stuff
        public string getSpeed(UInt16 trainAddr)
        {
            return "{1 " + trainAddr + "}";
        }

        public string setSpeed(UInt16 trainAddr, UInt16 speed, UInt16 forward)
        {
            return "{2 " + trainAddr + " " + speed + " " + forward + "}";
        }

        public string getTrainEffect(UInt16 trainAddr, UInt16 registerNo)
        {
            return "{3 " + trainAddr + " " + registerNo + "}";
        }

        public string setTrainEffect(UInt16 trainAddr, UInt16 registers)
        {
            return "{4 " + trainAddr + " " + registers + "}";
        }
        #endregion

        #region Accessory stuff
        public string getAcc(UInt16 accAddr)
        {
            return "{5 " + accAddr + "}";
        }

        public string setAcc(UInt16 accAddr, bool state)
        {
            return "{6 " + accAddr + " " + Convert.ToInt16(state) + "}";
        }
        #endregion
    }
}
