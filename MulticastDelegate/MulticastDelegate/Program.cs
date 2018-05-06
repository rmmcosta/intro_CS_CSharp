using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        delegate void SFunction(string n);
        static void Main(string[] args)
        {
            SFunction myDF;
            myDF = PrintBD;
            myDF += PrintAge;
            PrintInfo(myDF, "1985-10-10");
            myDF -= PrintBD;
            PrintInfo(myDF, "1985-10-10");
            SFunction anaDF = null;
            PrintInfo(anaDF, "1983-04-15");
        }

        static void PrintBD(string birthDay)
        {
            Console.WriteLine("birthDay: {0}", birthDay);
        }

        static void PrintAge(string birthDay)
        {
            int age = (DateTime.Now - DateTime.Parse(birthDay)).Days / 365;
            Console.WriteLine("Age: {0}", age);
        }

        static void PrintInfo(SFunction sf, string bdt)
        {
            Console.WriteLine("----------------- Doc -----------------");
            if (sf != null)
                sf(bdt);
            Console.WriteLine("----------------- End -----------------");

        }
    }
}
