using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_RoomCalculation
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
    }
}
