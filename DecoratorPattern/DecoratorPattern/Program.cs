using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarWash santanaCarWash = new CarWash();
            Console.WriteLine("The price for wash the car at Santana shop is:");
            santanaCarWash.PrintCost();
            Console.WriteLine("What about with Paint treatment?");
            PaintTreatment santanaPaintTreament = new PaintTreatment(santanaCarWash);
            santanaPaintTreament.PrintCost();
            CarWash serzedeloCarWash = new CarWash(4.5);
            Console.WriteLine("The price for wash the car at Serzedelo shop is:");
            serzedeloCarWash.PrintCost();
            Console.WriteLine("What about with Paint treatment?");
            PaintTreatment serzedeloPaintTreament = new PaintTreatment(serzedeloCarWash);
            serzedeloPaintTreament.PrintCost();
            Console.WriteLine("Do you also wash the chassis?");
            ChassisWash serzedeloChassisWash = new ChassisWash(serzedeloCarWash);
            Console.WriteLine("yes. Without the Paint treatment is:");
            serzedeloChassisWash.PrintCost();
            ChassisWash serzedeloChassisWashAndPaint = new ChassisWash(serzedeloPaintTreament);
            Console.WriteLine("And with the Paint treatment is:");
            serzedeloChassisWashAndPaint.PrintCost();
        }
    }
}
