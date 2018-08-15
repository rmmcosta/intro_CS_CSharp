using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class Cheese : Product
    {
        public Cheese()
        {
            _productType = "Cheese";
        }
    }
}
