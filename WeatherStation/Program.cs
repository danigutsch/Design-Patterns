using WeatherStation.Observers;
using WeatherStation.Subjects;

namespace WeatherStation
{
    internal static class Program
    {
        static void Main()
        {
            WeatherData weatherData = new();

            CurrentConditionsDisplay currentConditionsDisplay = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);
            HeatIndexDisplay heatIndexDisplay = new(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4D);
            weatherData.SetMeasurements(82, 70, 29.2D);
            weatherData.SetMeasurements(78, 90, 29.2D);
        }
    }
}