namespace Barista
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments => GetUserInput().StartsWith("Y", StringComparison.OrdinalIgnoreCase);

        private static string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            string? answer = Console.ReadLine();

            return answer ?? "no";
        }
    }
}