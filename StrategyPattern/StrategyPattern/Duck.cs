using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Duck
    {
        IFly _flyBehaviour; ISwim _swimBehaviour; IWalk _walkBehaviour;
        public Duck(IFly flyBehaviour, ISwim swimBehaviour, IWalk walkBehaviour)
        {
            _flyBehaviour = flyBehaviour;
            _swimBehaviour = swimBehaviour;
            _walkBehaviour = walkBehaviour;
        }

        public void Fly()
        {
            Console.WriteLine("Do you Fly?");
            _flyBehaviour.Fly();
            Console.WriteLine();
        }

        public void Walk()
        {
            Console.WriteLine("What about Walking?");
            _walkBehaviour.Walk();
            Console.WriteLine();
        }

        public void Swim()
        {
            Console.WriteLine("Please tell me that you know how to swim!");
            _swimBehaviour.Swim();
            Console.WriteLine();
        }
    }
}
