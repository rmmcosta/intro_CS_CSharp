#define MYTEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreProcessorDirectives
{
    class Program
    {
       /// <summary>
       /// this is a xml comment
       /// </summary>
       /// <param name="args"></param>
        static void Main(string[] args)
        {
#if MYTEST
            Console.WriteLine("Doing my test...");
#endif
            ClassDefine cd = new ClassDefine();
            cd.PrintM("Ana");
            ClassUndefine cu = new ClassUndefine();
            cd.PrintM("Ricardo");
        }
    }
}
