using System;
namespace WeatherStation
{
    public class CurrentConditionsDisplay : IDisplay, IObserver
    {
        private WeatherData _weatherData;
        
        private int _humidity;
        private int _pressure;
        private int _temperature;
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void Update(){
            var _humidity =  _weatherData.Humidity;
            var _pressure =  _weatherData.Pressure;
            var _temperature =  _weatherData.Temperature;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Current conditions");
            Console.WriteLine($"Humidity: { _humidity }");
            Console.WriteLine($"Pressure: { _pressure }");
            Console.WriteLine($"Temperature: { _temperature }");
            Console.WriteLine("------------------------------");
        }
    }

}