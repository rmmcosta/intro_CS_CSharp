using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
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
            Console.WriteLine("Preparation Ended.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking the Pizza...");
            Console.WriteLine("Baked.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the Pizza...");
            Console.WriteLine("Cutted.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the Pizza...");
            Console.WriteLine("Boxed.");
        }
    }
}
