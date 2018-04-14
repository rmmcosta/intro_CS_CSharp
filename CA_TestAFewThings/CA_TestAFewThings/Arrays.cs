using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TestAFewThings
{
    class Arrays
    {
        string[] stdArray3 = new string[3];

        public Arrays(string one, string two, string three)
        {
            try
            {
                stdArray3[0] = one;
                stdArray3[1] = two;
                stdArray3[2] = three;
                stdArray3[3] = three;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Indice fora do range permitido.");
            }
        
        }

        public void showValues3()
        {
            foreach(string s in stdArray3)
            {
                Console.WriteLine(s);
            }
                
        }

        public static void showValues(params string[] list)
        {
            for (int i=0; i<list.Length;i++)
            {
                Console.WriteLine("{0}:{1}\t",i,list[i]);
            }
        }

        public static void printArray(string[] arr)
        {
            foreach (string s in arr)
                Console.WriteLine(s);
        }

        internal static void printArray(IEnumerable<string> enumerable)
        {
            foreach (string s in enumerable)
                Console.WriteLine(s);
        }

        public enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
    }
}
