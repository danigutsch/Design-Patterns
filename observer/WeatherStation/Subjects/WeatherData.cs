using WeatherStation.Observers;

namespace WeatherStation.Subjects
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver>? _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers?.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers?.Remove(o);
        }

        public void NotifyObservers()
        {
            if (_observers is null) return;
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
