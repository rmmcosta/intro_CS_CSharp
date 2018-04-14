using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStructs
{
    class WithReadonly
    {
        readonly string _name;

        private static int _num;

        public string JustGet { get; }
        public string GetSet { get; set; }

        private int _someNum;

        public WithReadonly(string s)
        {
            this._name = s;
            JustGet = "Always the same!";
            _num++;
        }

        public string name => _name;

        public static int num => _num;

        public int someNum
        {
            get { return _someNum; }
            set { _someNum = value; }
        }

        /*public void set(string s)
        {
            this.name = s;
        }*/



    }

    class Program
    {
        const string THETHING = "macarone";

        static void changeThings(ref int n)
        {
            n *= n;
        }

        static void printThings(params string[] names)
        {
            StringBuilder sb = new StringBuilder();
            sb.Capacity = names.Length * 15;
            foreach(string s in names)
            {
                sb.Append(s).Append(" ");
            }
            Console.WriteLine(sb);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(THETHING);

            WithReadonly w1 = new WithReadonly("coisnhp");
            Console.WriteLine(WithReadonly.num);
            Console.WriteLine(w1.name);

            WithReadonly w2 = new WithReadonly("io");
            Console.WriteLine(WithReadonly.num);

            int n=5;
            Console.WriteLine(n);
            changeThings(n: ref n);
            Console.WriteLine(n);

            printThings("Ana", "Ricardo");
            printThings("Ana", "Ricardo", "Rui", "Maria");

            w1.someNum = 55;
            Console.WriteLine(w1.someNum);

            w1.GetSet = "yes";
            //w1.JustGet = "no";
            Console.WriteLine(w1.JustGet);
            Console.WriteLine(w2.JustGet);
        }
    }
}
