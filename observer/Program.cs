using WeatherStation;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var subject = new WeatherData();

var displayForecast = new ForecastDisplay(subject);
var displayCurrentConditions = new CurrentConditionsDisplay(subject);
var displayStatistics = new StatisticsDisplay(subject);
var displayThirdParty = new ThirdPartyDisplay(subject);
subject.RegisterObserver(displayForecast);
subject.RegisterObserver(displayCurrentConditions);
subject.RegisterObserver(displayStatistics);
subject.RegisterObserver(displayThirdParty);


subject.Humidity= 100;
subject.Temperature = 200;
subject.Pressure = 20;


subject.Humidity= 20;
subject.Temperature = 34;
subject.Pressure = 56;

subject.Humidity= 26;
subject.Temperature = 44;
subject.Pressure = 57;