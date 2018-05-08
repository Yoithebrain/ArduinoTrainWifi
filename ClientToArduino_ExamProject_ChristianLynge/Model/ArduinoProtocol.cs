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
            return "{getspeed " + trainAddr + "}";
        }

        public string setSpeed(UInt16 trainAddr, UInt16 speed, UInt16 forward)
        {
            return "{setspeed " + trainAddr + " " + speed + " " + forward + "}";
        }

        public string getTrainEffect(UInt16 trainAddr, UInt16 registerNo)
        {
            return "{geteffect " + trainAddr + " " + registerNo + "}";
        }

        public string setTrainEffect(UInt16 trainAddr, UInt16 registerNo, UInt16 state)
        {
            return "{seteffect " + trainAddr + " " + registerNo + " " + state + "}";
        }
        #endregion

        #region Accessory stuff
        public string getAcc(UInt16 accAddr)
        {
            return "{getacc " + accAddr + "}";
        }

        public string setAcc(UInt16 accAddr, bool forward)
        {
            return "{setacc " + accAddr + Convert.ToInt16(forward) + "}";
        }
        #endregion
    }
}
