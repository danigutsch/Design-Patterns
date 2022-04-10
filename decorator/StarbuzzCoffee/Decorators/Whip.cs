using StarbuzzCoffee.Components;

namespace StarbuzzCoffee.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Whip";

        public override double Cost() => _beverage.Cost() + .10;
    }
}
