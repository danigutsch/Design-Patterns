using PizzaStoreFactoryMethod.Products.Pizzas;

namespace PizzaStoreFactoryMethod.FactoryMethods
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string item)
        {
            return item switch
            {
                "cheese" => new ChicagoStyleCheesePizza(),
                "veggie" => new ChicagoStyleVeggiePizza(),
                "clam" => new ChicagoStyleClamPizza(),
                "pepperoni" => new ChicagoStylePepperoniPizza(),
                _ => null,
            };
        }
    }
}