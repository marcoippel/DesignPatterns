using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Business

{
    internal class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _currentWeather;
        private double _temperature;
        private int _humidity;

        public string CurrentWeather
        {
            get { return _currentWeather; }
            set
            {
                _currentWeather = value;
                Notify("Weather", value);
            }
        }

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Notify("Temperature", $"{value}°C");
            }
        }

        public int Humidity
        {
            get { return _humidity; }
            set
            {
                _humidity = value;
                Notify("Humidity", $"{value}%");
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string propertyName, string value)
        {
            foreach (var observer in _observers)
            {
                observer.Update(propertyName, value);
            }
        }
    }
}
