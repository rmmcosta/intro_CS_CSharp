using System;

namespace SingletonPatternWithMultiThreading
{
    class SingletonChocolateBoiler
    {
        private static SingletonChocolateBoiler _chocolateBoiler;
        private int _chocolateAmount = 0;
        public const int CHOCOLATE_CAPACITY = 1000;
        private bool _isBoiled = false;
        private static object syncRoot = new Object();

        private SingletonChocolateBoiler()
        {

        }

        public static SingletonChocolateBoiler GetTheOnlyAndOneBoiler()
        {
            if (_chocolateBoiler == null)
            {
                lock (syncRoot)
                {
                    if (_chocolateBoiler == null)
                    {
                        _chocolateBoiler = new SingletonChocolateBoiler();
                    }
                }
            }

            return _chocolateBoiler;
        }

        public void Fill(int chocolateAmount)
        {
            if (_chocolateAmount < CHOCOLATE_CAPACITY)
            {
                _chocolateAmount = Math.Min(_chocolateAmount + chocolateAmount, CHOCOLATE_CAPACITY);
                Console.WriteLine("Update:" + _chocolateAmount);
            }
            else
            {
                Console.WriteLine("The boiler is full!");
            }
        }

        public void Boil()
        {
            if (IsFull())
            {
                if (!_isBoiled)
                {
                    Console.WriteLine("Chocolate is Boiled!");
                    _isBoiled = true;
                }
                else
                {
                    Console.WriteLine("Already boiled!");
                }
            }
            else
            {
                Console.WriteLine("The Boiler is not full!");
            }
        }

        public bool IsFull()
        {
            return _chocolateAmount == CHOCOLATE_CAPACITY;
        }
    }
}
