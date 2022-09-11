using System;
namespace WeatherStation
{
    public class ThirdPartyDisplay : IDisplay, IObserver
    {
        private WeatherData _weatherData;
        
        private int _humidity;
        private int _pressure;
        private int _temperature;
        public ThirdPartyDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void Update(){
            var _humidity =  _weatherData.Humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Third Party Display");
            if( _humidity < 50 )
            {
                Console.WriteLine($"Low humidity: { _humidity }");
            }

            if(_humidity>80)
            {
                Console.WriteLine($"High humidity: { _humidity }");
            }
        }
    }

}