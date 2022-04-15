using PizzaStoreFactoryMethod.Products.Pizzas;

namespace PizzaStoreFactoryMethod.FactoryMethods
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string item)
        {
            return item switch
            {
                "cheese" => new NYStyleCheesePizza(),
                "veggie" => new NYStyleVeggiePizza(),
                "clam" => new NYStyleClamPizza(),
                "pepperoni" => new NYStylePepperoniPizza(),
                _ => null,
            };
        }
    }
}