using StarbuzzCoffee.Components;

namespace StarbuzzCoffee.Decorators
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Steamed Milk";

        public override double Cost() => _beverage.Cost() + .10;
    }
}
