namespace MultipleSingleton.Singletons
{
    public sealed class ClassicSingleton
    {
        private static ClassicSingleton? _uniqueInstance;

        public static ClassicSingleton Instance => _uniqueInstance ??= new ClassicSingleton();

        private ClassicSingleton() { }
    }
}
