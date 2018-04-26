using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    abstract class AbstractHome
    {
        protected int NumBedrooms=0;
        protected string Owner="";
        protected Room[] Rooms;
        protected readonly string ADDRESS;
        public AbstractHome(string Address)
        {
            ADDRESS = Address;
        }
        public abstract void DefineBedrooms(params Room[] r);
        public abstract void Advertise();
    }
}
