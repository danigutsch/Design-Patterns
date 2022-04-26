using DuckSimulator.Observables;

namespace DuckSimulator.Observers
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck) => Console.WriteLine($"Quackologist: {duck} just quacked.");
    }
}
