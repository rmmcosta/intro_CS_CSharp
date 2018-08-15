using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ThinCrust : Dough
    {
        public ThinCrust()
        {
            _product = "Thin Crust";
        }
    }
}
