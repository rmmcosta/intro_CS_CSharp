using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class Pizza
    {
        protected string _name;
        protected Cheese _cheese;
        protected Dough _dough;
        protected Sauce _sauce;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350º");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Place the Pizza in a Box.");
        }

        public void PrintDescription()
        {
            Console.WriteLine("---------------- " + _name + " ----------------");
            Console.WriteLine(_dough.getProductDescription() + (_cheese == null?"":" " + _cheese.getProductDescription()) + " " + _sauce.getProductDescription());
            Console.WriteLine("-----------------" + "-".PadRight(_name.Length-1) + "-----------------");
        }
    }
}
