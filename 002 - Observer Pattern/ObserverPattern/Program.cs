using ObserverPattern.Displays;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            Console.WriteLine("--- Meting 1 ---");
            weatherData.SetMeasurements(28, 65, 30.4f);

            Console.WriteLine("\n--- Meting 2 ---");
            weatherData.SetMeasurements(29, 70, 29.2f);

            Console.WriteLine("\n--- Meting 3 ---");
            weatherData.SetMeasurements(30, 90, 29.2f);

            Console.WriteLine("\n--- ForecastDisplay uitgeschreven ---");
            weatherData.RemoveObserver(forecastDisplay);

            Console.WriteLine("\n--- Meting 4 ---");
            weatherData.SetMeasurements(18, 55, 29.8f);

            Console.ReadLine();
        }
    }
}