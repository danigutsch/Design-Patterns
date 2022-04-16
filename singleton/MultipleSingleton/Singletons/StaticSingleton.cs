namespace MultipleSingleton.Singletons
{
    public sealed class StaticSingleton
    {
        public static StaticSingleton Instance { get; } = new StaticSingleton();

        private StaticSingleton() { }
    }
}
