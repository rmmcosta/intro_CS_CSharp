using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Decorator
    abstract class ServiceExtra : Service
    {
        protected Service _service;
        protected double _extraPrice;

        public override double CalculateCost()
        {
            return _extraPrice + _service.CalculateCost();
        }

        public ServiceExtra(Service service, double price = 1)
        {
            _service = service;
            _extraPrice = price;
        }

        public override void PrintCost()
        {
            string e = Encoding.Default.GetString(new byte[] { 128 });
            Console.OutputEncoding = Encoding.Default;
            Console.WriteLine(CalculateCost() + "€");
        }
    }
}
