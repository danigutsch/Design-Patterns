using DuckSimulator.Ducks;
using DuckSimulator.Geese;

namespace DuckSimulator.Factories
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateDuckCall() => new MallardDuck();
        public override IQuackable CreateMallardDuck() => new RedheadDuck();
        public override IQuackable CreateRedheadDuck() => new DuckCall();
        public override IQuackable CreateRubberDuck() => new RubberDuck();
        public override IQuackable CreateAdaptedGoose() => new GooseAdapter(new Goose());
    }
}
