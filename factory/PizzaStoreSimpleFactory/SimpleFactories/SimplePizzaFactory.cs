using PizzaStoreSimpleFactory.Pizzas;

namespace PizzaStoreSimpleFactory.SimpleFactories
{
    public class SimplePizzaFactory
    {
#pragma warning disable CA1822 // Mark members as static
        public Pizza CreatePizza(string type) => type switch
        {
            "cheese" => new CheesePizza(),
            "veggie" => new VeggiePizza(),
            "clam" => new ClamPizza(),
            "pepperoni" => new PepperoniPizza(),
            _ => new CheesePizza(),
        };
#pragma warning restore CA1822 // Mark members as static
    }
}
