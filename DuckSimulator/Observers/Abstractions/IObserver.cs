using DuckSimulator.Observables;

namespace DuckSimulator.Observers
{
    public interface IObserver
    {
        public void Update(IQuackObservable duck);
    }
}
