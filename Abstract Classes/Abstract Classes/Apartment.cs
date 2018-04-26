using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Classes.Room;

namespace Abstract_Classes
{
    class Apartment : AbstractHome
    {
        public Apartment(string Address) : base(Address)
        {
        }

        public override void DefineBedrooms(params Room[] r)
        {
            base.NumBedrooms = r.Length;
            Rooms = r;
        }

        public override void Advertise()
        {
            string adv = string.Format("We are talking about an Apartment located in {1} with {0} " +
                "Bedrooms:", this.NumBedrooms, this.ADDRESS);
            Console.WriteLine(adv);
            Array.ForEach(Rooms, Describe);
        }
    }
}
