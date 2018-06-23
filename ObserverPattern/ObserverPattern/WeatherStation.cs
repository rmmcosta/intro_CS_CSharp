using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherStation : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        public double Temperature { get; private set; }

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }
        
        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update();
            }
        }

        public void NewTemperature(double temperature)
        {
            Temperature = temperature;
            Notify();
        }
    }
}
