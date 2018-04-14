using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static int arraySize = 0;
        const string fillMessage = "Please enter the number of elements to sort:",
                     feedbackMessage = "You want to sort {0} numbers",
                     wrongIntMessage = "That's not a number",
                     enterNumber = "Enter number:",
                     feedbackEntered = "You entered the number: {0}";   

        static void fillArray(ref int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
            {
                getConsoleInt(enterNumber, ref arr[i], feedbackEntered);
            }

        }

        static void printArray(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append((i == 0 ? "" : ", ") + arr[i]);
            }
            Console.WriteLine("\nArray = {{{0}}}",sb);
        }

        static void getConsoleInt(string startMessage, ref int assignVar, string feedback)
        {
            Console.WriteLine(startMessage);
            if(int.TryParse(Console.ReadLine(), out assignVar))
            {
                Console.WriteLine(feedback, assignVar);
            } else
            {
                Console.WriteLine(wrongIntMessage);
            }
            
        }

        static void arrSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {

                    int temp = arr[j];
                    if (arr[j + 1] < arr[j])
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            getConsoleInt(fillMessage, ref arraySize, feedbackMessage);
            int[] myArr = new int[arraySize];
            fillArray(ref myArr);
            printArray(myArr);
            /*Array.Sort(myArr);
            printArray(myArr);
            Array.Reverse(myArr);
            printArray(myArr);
            */
            arrSort(ref myArr);
            printArray(myArr);
        }
    }
}
