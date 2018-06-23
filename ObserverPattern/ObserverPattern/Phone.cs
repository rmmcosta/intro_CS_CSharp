using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Phone : IObserver, IDisplay
    {
        WeatherStation _weatherStation;

        public Phone(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Display()
        {
            Console.WriteLine("     [Phone]     \n     Temperature:{0}ºC     ", _weatherStation.Temperature);
        }

        public void Update()
        {
            Display();
        }
    }
}
