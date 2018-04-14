using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEnums
{
    enum temperatures
    {
        cold = 10,
        warm = 20,
        hot = 30
    }
    class Program
    {


        static int calc(int amount) => amount * 10;

        static int x; //there is no need for initialize static variables. .net assign them automatic.
        int y;

        static void Main(string[] args)
        {
            Type t = typeof(temperatures);
            foreach (string temp in Enum.GetNames(t))
                Console.WriteLine(temp);
            foreach (temperatures temp in Enum.GetValues(t))
                Console.WriteLine("{0}:{1}ºC",temp,(int)temp);

            Boolean b = true;
            bool b1 = false;
            b = false;
            b = false & true;
            String asnumber = "1985";
            int ainumber = 0;
            float f = 34.56f;
            double d = 65.7;

            int i = (int)f;

            string[] mA = new string[2];

            Console.WriteLine(d);

            Console.WriteLine(f);

            Console.WriteLine(i);

            ainumber = int.Parse(asnumber)+10;

            Console.WriteLine(ainumber);

            var implicitvar = 0;
            Console.WriteLine(implicitvar);
            implicitvar = 'v';
            Console.WriteLine(implicitvar);

            Console.WriteLine(calc(33));

            Console.WriteLine("x:{0}", x);
            Program coiso = new Program();
            Console.WriteLine("y:{0}", coiso.y);

            foreach (string s in mA)
            {
                string s1 = s + 'a';
                Console.WriteLine(s1);
            }

            bool b10 = 1 == 4;

            string nullstring = null;

            Console.WriteLine(nullstring ?? "The other one is null");
            nullstring = "coiso";
            Console.WriteLine(nullstring ?? "The other one is null");

        }
    }
}
