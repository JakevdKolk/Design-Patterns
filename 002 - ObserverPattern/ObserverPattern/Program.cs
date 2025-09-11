using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();


            AbstractDisplay currentCondition = new CurrentConditionDisplay(weatherData);
            AbstractDisplay forecast = new ForecastDisplay(weatherData);
            AbstractDisplay stats = new StatisticsDisplay(weatherData);


            weatherData.RegisterObserver(currentCondition);
            weatherData.RegisterObserver(forecast);
            weatherData.RegisterObserver(stats);

            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);
            weatherData.RemoveObserver(forecast);
            weatherData.SetMeasurements(30, 90, 29.2f);




            
            
        }
    }
}