namespace MultipleSingleton.Singletons
{
    public sealed class DclSingleton
    {
        private static volatile DclSingleton? _uniqueInstance;
        private static readonly object SyncLock = new();

        public static DclSingleton Instance
        {
            get
            {
                if (_uniqueInstance is null)
                {
                    lock (SyncLock)
                    {
                        if (_uniqueInstance is null)
                        {
                            _uniqueInstance = new DclSingleton();
                        }
                    }
                }
                return _uniqueInstance;
            }
        }

        private DclSingleton() { }
    }
}
