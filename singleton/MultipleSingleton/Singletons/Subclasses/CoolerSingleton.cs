namespace MultipleSingleton.Singletons.Subclasses
{
#pragma warning disable RCS1225 // Make class sealed.
    public class CoolerSingleton : BaseSingleton
#pragma warning restore RCS1225 // Make class sealed.
    {
#pragma warning disable CA2211 // Non-constant fields should not be visible
        protected new static BaseSingleton? UniqueInstance;
#pragma warning restore CA2211 // Non-constant fields should not be visible

        private CoolerSingleton() { }
    }
}
