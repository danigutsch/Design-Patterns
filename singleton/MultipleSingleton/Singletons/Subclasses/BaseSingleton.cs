namespace MultipleSingleton.Singletons
{
    public class BaseSingleton
    {
#pragma warning disable CA2211 // Non-constant fields should not be visible
        protected static BaseSingleton? UniqueInstance;
#pragma warning restore CA2211 // Non-constant fields should not be visible
        private static readonly object SyncLock = new();

        public static BaseSingleton Instance
        {
            get
            {
                lock (SyncLock)
                {
                    if (Instance is null)
                    {
                        UniqueInstance = new BaseSingleton();
                    }
                }

                return Instance!;
            }
        }

        protected BaseSingleton() { }
    }
}
