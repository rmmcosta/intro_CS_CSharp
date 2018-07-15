using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Component
    class CarWash : Service
    {
        private double _basePrice;

        public CarWash(double basePrice = 5)
        {
            _basePrice = basePrice;
        }

        public override double CalculateCost()
        {
            return _basePrice;
        }

        public override void PrintCost()
        {
            string e = Encoding.Default.GetString(new byte[] { 128 });
            Console.OutputEncoding = Encoding.Default;
            Console.WriteLine(CalculateCost() + "€");
        }
    }
}
