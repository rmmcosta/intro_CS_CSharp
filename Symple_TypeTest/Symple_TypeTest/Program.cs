using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Simple_Type;

namespace Symple_TypeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Use the file name to load the assembly into the current
            // application domain.
            Type myType1 = typeof(MySimpleClass);
            Console.WriteLine(myType1);
            Assembly a = Assembly.Load("Simple_Type");
            // Get the type to use.
            Console.WriteLine(a);
            Type myType = a.GetType("MySimpleClass");
            Console.WriteLine(myType);
            // Get the method to call.
            MethodInfo myMethod = myType.GetMethod("MyMethod");
            // Create an instance.
            object obj = Activator.CreateInstance(myType);
            // Execute the method.
            myMethod.Invoke(obj, null);*/

            Assembly assem = Assembly.Load("Simple_Type");
            Type[] myTypes = assem.GetTypes();
            foreach(Type t in myTypes)
            {
                Console.WriteLine(t);
            }
            Type myType = assem.GetType("Simple_Type.MySimpleClass");
            Console.WriteLine(myType);
            MethodInfo[] myMethods = myType.GetMethods();
            foreach (MethodInfo m in myMethods)
            {
                Console.WriteLine(m);
            }
            //MethodInfo myMethod = myType.GetMethod("MyMethod");
            MethodInfo myMethod = myMethods[0];
            // Create an instance.
            object obj = Activator.CreateInstance(myType);
            // Execute the method.
            myMethod.Invoke(obj, null);
        }
    }
}
