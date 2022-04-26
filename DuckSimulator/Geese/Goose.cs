namespace DuckSimulator.Geese
{
    public class Goose : IHonkable
    {
        public void Honk() => Console.WriteLine("Honk");

        public override string ToString() => "Goose";
    }
}
