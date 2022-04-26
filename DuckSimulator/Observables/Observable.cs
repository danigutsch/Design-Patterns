using DuckSimulator.Observers;

namespace DuckSimulator.Observables
{
    public class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers = new();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck) => _duck = duck;

        public void RegisterObserver(IObserver observer) => _observers.Add(observer);

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}
