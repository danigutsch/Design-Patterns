using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _maxTemperature;
        private double _minTemperature = 200;
        private double _temperatureSum;
        private int _numReadings;
        private readonly ISubject _weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperatureSum += temperature;
            _numReadings++;

            if (temperature > _maxTemperature)
                _maxTemperature = temperature;

            if (temperature < _minTemperature)
                _minTemperature = temperature;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_temperatureSum / _numReadings) + "/" + _maxTemperature + "/" + _minTemperature);
        }
    }
}
