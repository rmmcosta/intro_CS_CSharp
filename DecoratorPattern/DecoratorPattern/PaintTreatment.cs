using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Decorator
    class PaintTreatment : ServiceExtra
    {
        public PaintTreatment(Service service) : base(service)
        {

        }
    }
}
