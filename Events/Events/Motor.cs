using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Motor
    {
        public delegate void DFunc();
        int _maxPower, _actualPower = 0;
        public event DFunc EH = null;
        public Motor(int mp)
        {
            _maxPower = mp;
        }
        public void MorePower(int inc)
        {
            if (_actualPower + inc > _maxPower)
            {
                _actualPower = _maxPower;
                EH += MaxPowerReached;
                EH += Running;
                EH();
            }
            else
            {
                _actualPower += inc;
                Running();
            }
        }
        public void LessPower(int dec)
        {
            if (_actualPower - dec < 0)
            {
                _actualPower = 0;
                EH = MotorStoped;
                EH();
            }
            else
            {
                _actualPower -= dec;
                Running();
            }
        }
        public void MaxPowerReached()
        {
            Console.WriteLine("The Max Power of {0} was reached!", _maxPower);
        }
        public void MotorStoped()
        {
            Console.WriteLine("The Motor is Stoped!");
        }
        public void Running()
        {
            decimal runPercent = decimal.Divide(_actualPower, _maxPower) * 100;
            if (runPercent == 0)
                Console.WriteLine("Not Running!");
            else
                Console.WriteLine("Running at {0}%", runPercent);
        }

    }
}
