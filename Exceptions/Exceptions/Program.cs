using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[3];
            char[] chArr = { 'A', 'N', 'A' };
            try
            {
                Console.WriteLine(myArr[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("The Program continues...");
            try
            {
                int x = 5, y = 0;
                Console.WriteLine("{0}", x / y);
            }
            catch (DivideByZeroException e0)
            {
                Console.WriteLine("You can't divide by zero!");
                Console.WriteLine(e0.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            try
            {
                Console.WriteLine(chArr[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The final block allways runs!");
            }
            try
            {
                try
                {
                    Console.WriteLine(chArr[10]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw new MyException();
                }
            } catch(MyException me)
            {
                Console.WriteLine(me.Message);
            }
        }
    }
}
