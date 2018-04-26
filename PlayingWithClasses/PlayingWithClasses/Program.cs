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
        protected string text = "";
        public P1()
        {
            Console.WriteLine("Hi P1");
        }
        public static string operator +(P1 p1, P1 p2) => "You wish!";
        public virtual void DefineText(string s)
        {
            text = s + " in p1";
        }
        public void PrintText()
        {
            Console.WriteLine(text);
        }
        
    }

    class S1 : P1
    {
        public S1() => Console.WriteLine("S1 it's you?");
        public override void DefineText(string s)
        {
            base.DefineText(s + " in s1");
        }
    }

    class D1:P1
    {
        new string text;
        public void DefineText()
        {
            base.DefineText("Default text");
        }

        new public void DefineText(string s)
        {
            text = s;
        }

        new public void PrintText()
        {
            Console.WriteLine(text);
        }
    }

    class PortugueseLeague
    {
        private string[] team = {"Benfica", "Porto", "Sporting" };
        public string this[int i]
        {
            get
            {
                // return the value specified by index
                return team[i];
            }

            // The set accessor.
            set
            {
                // set the value specified by index
            }
        }
    }

    class AString
    {
        public string theString;

        public AString(string s) => theString = s;

        public char this[int i]
        {
            get => theString[i];

            set
            {
                char[] tempArr = theString.ToCharArray();
                tempArr[i] = value;
                theString = new string(tempArr);
            }
        }
    }

    class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Point p1, Point p2) => (p1.x == p2.x & p1.y == p2.y);
        public static bool operator !=(Point p1, Point p2) => (p1.x != p2.x | p1.y != p2.y);
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

            PortugueseLeague pl = new PortugueseLeague();

            Console.WriteLine(pl[0]);

            AString oneString = new AString("S.L. Benfica");

            Console.WriteLine(oneString[5]);

            oneString[5] = 'F';

            Console.WriteLine(oneString.theString);

            char[] arrS = { 'A', 'N', 'A','R'};

            Console.WriteLine(new string(arrS,1,3));

            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 3);
            Point p3 = new Point(2, 3);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);
            Console.WriteLine("implicit cast vs explicit cast");
            P1 pcenas = new S1();
            //S1 scenas = (S1)myP1;//return an error
            S1 scenas = myP1 as S1;//the same as the above but returns no error since the object is assigned to null
            Console.WriteLine(scenas);
            Console.WriteLine(myS1);
            if(scenas is P1)
            {
                Console.WriteLine("scenas is p1");
            } else
            {
                Console.WriteLine("scenas is not p1");
            }
            if (pcenas is S1)
            {
                Console.WriteLine("pcenas is S1");
            }
            else
            {
                Console.WriteLine("pcenas is not S1");
            }
            if(s1 is string)
            {
                Console.WriteLine("s1 is a string");
            }

            SetTexts(myP1,"myp1");
            SetTexts(myS1,"mys1");

            D1 myD1 = new D1();
            myD1.DefineText();
            myD1.PrintText();
            myD1.DefineText("XPTO");
            myD1.PrintText();
        }

        static void SetTexts(P1 p1, string s)
        {
            p1.DefineText(s);
            p1.PrintText();
        }
    }
}
