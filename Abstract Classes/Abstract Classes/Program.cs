using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Classes.Common;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractHome ah = new AbstractHome(); can not instantiate an abstract class
            Apartment ap = new Apartment("Paço da Rainha");
            ap.DefineBedrooms(new Room("Primogénito",colors.Blue),new Room("SweetRoom",colors.Brown));
            ap.Advertise();
        }
    }
}
