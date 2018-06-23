using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation ipma = new WeatherStation();
            Phone samsung = new Phone(ipma);
            Television lg = new Television(ipma);
            ipma.Add(samsung);
            ipma.Add(lg);
            ipma.NewTemperature(24.5);
            ipma.NewTemperature(25);
        }
    }
}
