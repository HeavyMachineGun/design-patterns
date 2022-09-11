
using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private int _temperature;
        public int Temperature 
        {
             get => _temperature; 
             set 
             {
                _temperature = value;
                NotifyObserver();
            }
        }
        private int _humidity;
        public int Humidity 
        {
             get => _humidity; 
             set 
             {
                _humidity = value;
                NotifyObserver();
            }
        }
        private int _pressure;
        public int Pressure 
        {
             get => _pressure; 
             set 
             {
                _pressure = value;
                NotifyObserver();
            }
        }

        private List<IObserver> _observers;
        public WeatherData()
        {
            _observers = new();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach(var observer in _observers){
                observer.Update();
            }
        }
    }
}