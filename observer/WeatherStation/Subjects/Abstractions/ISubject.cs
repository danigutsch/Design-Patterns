﻿using WeatherStation.Observers;

namespace WeatherStation.Subjects
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}
