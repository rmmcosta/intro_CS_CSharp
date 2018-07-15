using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class Pizza
    {
        protected string[] _ingredients;

        public virtual void PrintDescription()
        {
            Console.WriteLine("This pizza has:" + string.Join(",", _ingredients));
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing the Pizza...");
            Console.WriteLine("Grab the Dough");
            Console.WriteLine("Join the ingredients:");
            foreach(string ingredient in _ingredients)
            {
                Console.WriteLine("-" + ingredient);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking the Pizza for 30min at 180ºC...");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the Pizza in slices...");
        }

        public void Box()
        {
            Console.WriteLine("Putting the Pizza in a Customized Box...");
        }
    }
}
