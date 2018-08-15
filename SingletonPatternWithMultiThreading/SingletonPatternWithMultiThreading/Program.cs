using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPatternWithMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(StartBoil);
            t1.Start();
            Thread t2 = new Thread(StartBoil);
            t2.Start();
            Thread t3 = new Thread(StartBoil);
            t3.Start();
            Thread t4 = new Thread(StartBoil);
            t4.Start();
            Thread t5 = new Thread(StartBoil);
            t5.Start();

        }

        private static void StartBoil()
        {
            SingletonChocolateBoiler boiler = SingletonChocolateBoiler.GetTheOnlyAndOneBoiler();
            if (!boiler.IsFull())
            {
                for(int i = 0; i < SingletonChocolateBoiler.CHOCOLATE_CAPACITY; i++)
                {
                    boiler.Fill(1);
                }
            }
            boiler.Boil();
        }
    }
}
