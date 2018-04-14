using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CL_Series;

namespace CL_SeriesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assem = Assembly.ReflectionOnlyLoadFrom("CL_Series.dll");
            Type[] typs = assem.GetTypes();
            foreach(Type t in typs)
            {
                Console.WriteLine(t);
            }
            Type typ = assem.GetType("CL_Series.Class1+Series");
            FieldInfo[] fields = typ.GetFields();

            foreach (var field in fields)
            {
                if (field.Name.Equals("value__")) continue;

                Console.WriteLine("{0,-9} {1}", field.Name + ":",
                                                field.GetRawConstantValue());
            }
        }
    }
}
