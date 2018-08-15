using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ThickCrust : Dough
    {
        public ThickCrust()
        {
            _product = "Thick Crust";
        }
    }
}
