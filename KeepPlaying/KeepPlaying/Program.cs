using System;
using coiso = KeepPlaying.n1;
using KeepPlaying.n3;

namespace KeepPlaying
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<4;i++)
            {
                if (i == 2)
                    continue;
                Console.WriteLine(i);
            }

            coiso.Class1.printThings("Hello Ana Ramos my beauty cute little thing");
            n2.Class1.printHi();
            Class1.printHello();
        }
    }
}
