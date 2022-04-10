using StarbuzzCoffee.Components;
using StarbuzzCoffee.Decorators;

namespace StarbuzzCoffee
{
    internal static class Program
    {
        static void Main()
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.Description + " $" + beverage1.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());
        }
    }
}