using DuckSimulator.Decorators;
using DuckSimulator.Ducks;
using DuckSimulator.Geese;

namespace DuckSimulator.Factories
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck() => new QuackCounter(new MallardDuck());
        public override IQuackable CreateRedheadDuck() => new QuackCounter(new RedheadDuck());
        public override IQuackable CreateDuckCall() => new QuackCounter(new DuckCall());
        public override IQuackable CreateRubberDuck() => new QuackCounter(new RubberDuck());
        public override IQuackable CreateAdaptedGoose() => new QuackCounter(new GooseAdapter(new Goose()));
    }
}
