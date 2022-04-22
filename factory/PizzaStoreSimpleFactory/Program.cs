using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.SimpleFactories;

namespace PizzaStoreSimpleFactory
{
    public static class Program
    {
        public static void Main()
        {
            SimplePizzaFactory factory = new();
            PizzaStore store = new(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);
        }
    }
}