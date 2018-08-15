using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Dinner
{
    class CommandBurger : ICommand
    {
        ReceiverCookerBurger _cookerBurger;

        public CommandBurger(ReceiverCookerBurger cookerBurger)
        {
            _cookerBurger = cookerBurger;
        }

        public void Execute()
        {
            _cookerBurger.MakeBurger();
        }
    }
}
