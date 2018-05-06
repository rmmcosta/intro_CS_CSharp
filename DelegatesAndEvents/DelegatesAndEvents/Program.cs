using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //delegate must be used in the class context
    delegate void Print();
    class Program
    {
        static void Main(string[] args)
        {
            Write(PrintX, PrintY,0);
            Write(PrintX, PrintY, 1);
        }

        static void Write(Print p1, Print p2, int i)
        {
            if (i == 0)
                p1();
            else
                p2();
        }

        static void PrintX()
        {
            Console.WriteLine("X");
        }

        static void PrintY()
        {
            Console.WriteLine("Y");
        }
    }
}
