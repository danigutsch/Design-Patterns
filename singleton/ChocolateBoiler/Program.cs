namespace ChocolateBoiler
{
    public static class Program
    {
        public static void Main()
        {
            ChocolateBoiler boiler = ChocolateBoiler.Instance;
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            // will return the existing instance
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            ChocolateBoiler boiler2 = ChocolateBoiler.Instance;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }
    }
}