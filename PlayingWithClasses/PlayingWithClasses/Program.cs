using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithClasses
{

    class Animal
    {
        protected string name;

        public Animal(string s)
        {
            this.name = s;
        }

        public static Animal add(Animal a1, Animal a2)
        {
            return new Animal(a1.name + " + " + a2.name);
        }

        public override string ToString()
        {
            return "Animal:" + this.name;
        }
    }

    class Dog : Animal
    {
        public Dog(string s) : base(s)
        {
        }

        public override string ToString()
        {
            return "Dog:" + this.name;
        }
    }

    class Cat : Animal
    {
        public Cat(string s) : base(s)
        {
            this.name = "Miau_" + s;
        }
    }

    class P1
    {
        public P1()
        {
            Console.WriteLine("Hi P1");
        }
        public static string operator +(P1 p1, P1 p2) => "You wish!";
    }

    class S1 : P1
    {
        public S1() => Console.WriteLine("S1 it's you?");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Bear");
            Console.WriteLine(a1);
            Animal a2 = new Animal("Polar Bear");
            Console.WriteLine(a2);
            Console.WriteLine(Animal.add(a1, a2));

            Animal a3 = new Dog("Freddy");
            Console.WriteLine(a3);

            Cat c1 = new Cat("Tareco");
            Console.WriteLine(c1);
            Console.WriteLine(Animal.add(a3, c1));

            P1 myP1 = new P1();
            S1 myS1 = new S1();

            string s1 = myP1 + myS1;

            Console.WriteLine(s1);
        }
    }
}
