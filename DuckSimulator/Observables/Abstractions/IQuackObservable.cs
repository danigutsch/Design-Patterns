using DuckSimulator.Observers;

namespace DuckSimulator.Observables
{
    public interface IQuackObservable
    {
        public void RegisterObserver(IObserver observer);
        public void NotifyObservers();
    }
}
