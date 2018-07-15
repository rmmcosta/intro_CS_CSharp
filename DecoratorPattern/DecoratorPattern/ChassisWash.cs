using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ChassisWash : ServiceExtra
    {
        double _specialTaxPercent;
        //the chassis wash has a special tax percent applied to the price 
        public ChassisWash(Service service, double price=2, double taxPercent = 30) : base(service, price)
        {
            _specialTaxPercent = taxPercent;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + base._extraPrice*_specialTaxPercent/100;
        }
    }
}
