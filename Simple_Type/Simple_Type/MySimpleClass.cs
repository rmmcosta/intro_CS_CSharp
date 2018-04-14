// Code for building SimpleType.dll.
using System;
using System.Reflection;
using System.Globalization;
using Simple_Type;

namespace Simple_Type
{
    public class MySimpleClass
    {
        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }

        public void MyMethod(string str, int i)
        {
            Console.WriteLine("MyMethod parameters: {0}, {1}", str, i);
        }

        public void MyMethod(string str, int i, int j)
        {
            Console.WriteLine("MyMethod parameters: {0}, {1}, {2}",
                str, i, j);
        }
    }
}
