using System;
using System.Collections.Generic;
using System.Linq;
namespace WeatherStation
{
    public class StatisticsDisplay : IDisplay, IObserver
    {
        private WeatherData _weatherData;
        
        private List<int> _humidity;
        private List<int> _pressure;
        private List<int> _temperature;
        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _humidity = new();
            _pressure = new();
            _temperature = new();
        }

        public void Update(){
            _humidity.Add(_weatherData?.Humidity??0);
            _pressure.Add(_weatherData?.Pressure??0);
            _temperature.Add(_weatherData?.Temperature??0);
            Display();
        }
        public void Display()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Statistics Party Display");

            Console.WriteLine($"Humidity Average: {_humidity.Average()}");
            Console.WriteLine($"Pressure Average: {_pressure.Average()}");
            Console.WriteLine($"Temperature Average: {_temperature.Average()}");
            Console.WriteLine("------------------------------");
            
        }
    }

}