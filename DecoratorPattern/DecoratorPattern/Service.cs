using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Component
    abstract class Service
    {
        public abstract double CalculateCost();
        public abstract void PrintCost();
    }
}
