namespace Barista
{
    public static class Program
    {
        public static void Main()
        {
            Tea tea = new();
            Coffee coffee = new();

            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.PrepareRecipe();

            TeaWithHook teaHook = new();
            CoffeeWithHook coffeeHook = new();

            Console.WriteLine("\nMaking tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();
        }
    }
}
