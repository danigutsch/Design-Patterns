using DuckSimulator.Ducks;
using DuckSimulator.Observers;

namespace DuckSimulator.Composites
{
    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackers = new();

        public void Add(IQuackable quacker) => _quackers.Add(quacker);

        public void Quack()
        {
            foreach (IQuackable quacker in _quackers)
            {
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (IQuackable duck in _quackers)
            {
                duck.RegisterObserver(observer);
            }
        }

        public void NotifyObservers() { }

        public override string ToString() => "Flock of Ducks";
    }
}
