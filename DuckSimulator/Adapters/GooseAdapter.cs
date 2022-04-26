using DuckSimulator.Ducks;
using DuckSimulator.Geese;
using DuckSimulator.Observables;
using DuckSimulator.Observers;

namespace DuckSimulator
{
    public class GooseAdapter : IQuackable
    {
        private readonly IHonkable _goose;
        private readonly Observable _observable;

        public GooseAdapter(IHonkable goose)
        {
            _goose = goose;
            _observable = new(this);
        }

        public void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer) => _observable.RegisterObserver(observer);

        public void NotifyObservers() => _observable.NotifyObservers();

        public override string ToString() => "Goose pretending to be a Duck";
    }
}
