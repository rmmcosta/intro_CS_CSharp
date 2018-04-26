using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Classes.Common;

namespace Abstract_Classes
{
    class Room
    {
        protected colors color;
        protected string name;
        public Room(string name, colors c)
        {
            this.name = name;
            this.color = c;
        }
        public static void Describe(Room r)
        {
            Console.WriteLine("{0} a nice {1} Bedroom",r.name,r.color);
        }
    }
}
