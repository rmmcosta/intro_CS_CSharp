using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Tomato : Sauce
    {
        public Tomato()
        {
            _product = "Tomato";
        }
    }
}
