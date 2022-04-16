namespace MultipleSingleton.Singletons
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? _uniqueInstance;
        private static readonly object SyncLock = new();

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (SyncLock)
                {
                    if (_uniqueInstance is null)
                    {
                        _uniqueInstance = new ThreadSafeSingleton();
                    }
                }

                return _uniqueInstance;
            }
        }

        private ThreadSafeSingleton() { }
    }
}
