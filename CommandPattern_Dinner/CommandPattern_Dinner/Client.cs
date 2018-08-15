using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    class Client
    {
        static void Main(string[] args)
        {
            //Creates the waitress
            InvokerWaitress waitress = new InvokerWaitress();

            //creates the generic burguer cooker
            ReceiverCookerBurger cookerBurger = new CookerCheeseBurger();

            //creates the generic shake cooker
            ReceiverCookerShake cookerShake = new CookerMilkShake();

            CommandBurger burger = new CommandBurger(cookerBurger);
            waitress.AddCommand(burger);
            CommandShake shake = new CommandShake(cookerShake);
            waitress.AddCommand(shake);
            Thread t = new Thread(new ThreadStart(waitress.Order));
            t.Start();
            t.Join(); //Call Join(), to wait until Thread ends.
            cookerBurger = new CookerBurger();
            burger = new CommandBurger(cookerBurger);
            waitress.AddCommand(burger);
            Thread t1 = new Thread(new ThreadStart(waitress.Order));
            t1.Start();
        }
    }
}
