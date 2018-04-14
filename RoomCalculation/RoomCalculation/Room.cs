using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculation
{
    public class Room
    {
        private int length,
                    width,
                    height;

        public Room(int l, int w, int h)
        {
            this.length = l;
            this.width = w;
            this.height = h;
        }

        public int getArea()
        {
            return length * width;
        }

        public int getVolume()
        {
            return (length * width * height);
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Create new Room...");
                Console.WriteLine("Enter the length:");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Room r1 = new Room(length, width, width);
                System.Console.WriteLine("Area:" + r1.getArea());
                System.Console.WriteLine("Volume:" + r1.getVolume());

            }
        }
    }

}
