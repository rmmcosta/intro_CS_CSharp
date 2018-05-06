using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor honda = new Motor(100);
            honda.EH += PrintNoSense;
            honda.MorePower(10);
            honda.MorePower(85);
            honda.MorePower(10);
            honda.EH -= PrintNoSense;
            honda.MorePower(10);
            honda.LessPower(30);
            honda.LessPower(30);
            honda.LessPower(30);
            honda.LessPower(30);
        }
        static void PrintNoSense()
        {
            Console.WriteLine("Oh YEAH! :)");
        }
    }
}
