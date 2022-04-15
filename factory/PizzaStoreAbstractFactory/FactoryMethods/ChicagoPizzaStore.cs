using PizzaStoreAbstractFactory.AbstractFactories;
using PizzaStoreAbstractFactory.Products.Pizzas;

namespace PizzaStoreAbstractFactory.FactoryMethods
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string item)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            return item switch
            {
                "cheese" => new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" },
                "veggie" => new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" },
                "clam" => new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" },
                "pepperoni" => new PepperoniPizza(ingredientFactory) { Name = "Chicago Style Pepperoni Pizza" },
                _ => null,
            };
        }
    }
}