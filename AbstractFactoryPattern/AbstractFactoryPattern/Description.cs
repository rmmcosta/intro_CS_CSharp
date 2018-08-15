using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Description
    {
        public static string getDescription(string name, string type)
        {
            if(name != "" && type != "")
            {
                return $"{name.First().ToString().ToUpper() + name.Substring(1).ToLower()} {type.ToLower()}";
            }
            else
            {
                return "";
            }
        }
    }
}
