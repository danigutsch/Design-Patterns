using MiniDuckSimulator.Behaviors;
using MiniDuckSimulator.Ducks;

namespace MiniDuckSimulator
{
    public static class Program
    {
        public static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}