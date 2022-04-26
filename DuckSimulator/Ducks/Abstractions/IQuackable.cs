using DuckSimulator.Observables;

namespace DuckSimulator.Ducks
{
    public interface IQuackable : IQuackObservable
    {
        public void Quack();
    }
}
