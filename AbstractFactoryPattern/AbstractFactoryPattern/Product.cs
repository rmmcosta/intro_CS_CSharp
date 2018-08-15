using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class Product
    {
        protected string _product, _productType;

        public string getProductDescription()
        {
            return Description.getDescription(_product, _productType);
        }
    }
}
