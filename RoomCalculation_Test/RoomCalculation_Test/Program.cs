using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculation_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CL_RoomCalculation.Room c1 = new CL_RoomCalculation.Room(1,2,3);
            Console.WriteLine(c1.getArea());
            Console.ReadLine();
        }
    }
}
