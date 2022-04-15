using PizzaStoreAbstractFactory.AbstractFactories;
using PizzaStoreAbstractFactory.Products.Pizzas;

namespace PizzaStoreAbstractFactory.FactoryMethods
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string item)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            return item switch
            {
                "cheese" => new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" },
                "veggie" => new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" },
                "clam" => new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" },
                "pepperoni" => new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" },
                _ => null,
            };
        }
    }
}