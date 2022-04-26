using DuckSimulator.Geese;

namespace DuckSimulator.Factories
{
    public class GooseFactory : AbstractGooseFactory
    {
        public override IHonkable CreateGoose() => new Goose();
    }
}
