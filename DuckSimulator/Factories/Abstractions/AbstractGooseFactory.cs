using DuckSimulator.Geese;

namespace DuckSimulator.Factories
{
    public abstract class AbstractGooseFactory
    {
        public abstract IHonkable CreateGoose();
    }
}
