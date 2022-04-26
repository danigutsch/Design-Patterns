using DuckSimulator.Observables;
using DuckSimulator.Observers;

namespace DuckSimulator.Ducks
{
    public class RubberDuck : IQuackable
    {
        private readonly Observable _observable;

        public RubberDuck() => _observable = new Observable(this);

        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);

        public void NotifyObservers() => _observable.NotifyObservers();

        public override string ToString() => "Rubber Duck";
    }
}
