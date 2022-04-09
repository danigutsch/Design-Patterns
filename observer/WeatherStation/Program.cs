using WeatherStation.Observers;
using WeatherStation.Subjects;

namespace WeatherStation
{
    internal static class Program
    {
        static void Main()
        {
            WeatherData weatherData = new();

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            CurrentConditionsDisplay currentConditionsDisplay = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);
            HeatIndexDisplay heatIndexDisplay = new(weatherData);
#pragma warning restore IDE0059 // Unnecessary assignment of a value

            weatherData.SetMeasurements(80, 65, 30.4D);
            weatherData.SetMeasurements(82, 70, 29.2D);
            weatherData.SetMeasurements(78, 90, 29.2D);
        }
    }
}