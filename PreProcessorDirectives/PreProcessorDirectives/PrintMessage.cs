using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreProcessorDirectives
{
    class PrintMessage
    {
        /* this is
         * a multiline
         * comment
         * */
        public static void PrintM(string m)
        {
#if DEBUG
            Console.WriteLine("DEBUGGING MODE!");
#endif
            Console.WriteLine(m);
        }
    }
}
