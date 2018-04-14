using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Series
{
    public class Class1
    {
        [System.Flags]
        public enum Series
        {
            residence, anatomia, got, wire
        }

        public void MethodA()
        {
            Console.WriteLine("Here in MethodA");
        }
    }
}
