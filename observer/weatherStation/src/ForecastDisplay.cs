using System;
namespace WeatherStation
{
    public class ForecastDisplay : IDisplay, IObserver
    {
        private WeatherData _weatherData;
        
        private int _humidity;
        private int _temperature;
        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void Update(){
            var _humidity =  _weatherData.Humidity;
            var _temperature =  _weatherData.Temperature;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Current conditions");
            Console.WriteLine($"Heat: { ComputeHeat() }");
            Console.WriteLine("------------------------------");
        }
        private float ComputeHeat()
        {
            var t = _temperature;
            var rh = _humidity;

            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
            (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
            (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
            (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *  
            (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
            (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +     
            0.000000000843296 * (t * t * rh * rh * rh)) -
            (0.0000000000481975 * (t * t * t * rh * rh * rh)));

            return index;
        }
    }

}