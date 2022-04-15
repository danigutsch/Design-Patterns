using PizzaStoreAbstractFactory.Products.Ingredients;

namespace PizzaStoreAbstractFactory.AbstractFactories
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public IVeggies[] CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClams CreateClam();
    }
}
