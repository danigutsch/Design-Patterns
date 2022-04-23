namespace DuckSort
{
    public static class Program
    {
        public static void Main()
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);
        }

        public static void Display(IEnumerable<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}