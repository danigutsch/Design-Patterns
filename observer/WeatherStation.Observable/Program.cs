using WeatherStation.Observable.Observers;
using WeatherStation.Observable.Subjects;

namespace WeatherStation.Observable
{
    public static class Program
    {
        public static void Main()
        {
            WeatherData weatherData = new();

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            CurrentConditionsDisplay currentConditionsDisplay = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);
            HeatIndexDisplay heatIndexDisplay = new(weatherData);
#pragma warning restore IDE0059 // Unnecessary assignment of a value

            weatherData.SetMeasurements(80, 65, 30.4d);
            weatherData.SetMeasurements(82, 70, 29.2d);
            weatherData.SetMeasurements(78, 90, 29.2d);
        }
    }
}