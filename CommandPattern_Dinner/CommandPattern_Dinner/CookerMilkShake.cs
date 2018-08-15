using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    class CookerMilkShake : ReceiverCookerShake
    {
        public override void MilkShake()
        {
            Console.WriteLine("Oh milk that shake!");
        }
    }
}
