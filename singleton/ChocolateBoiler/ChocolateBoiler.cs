namespace ChocolateBoiler
{
    public sealed class ChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private static ChocolateBoiler? _uniqueInstace;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if (_uniqueInstace == null)
                {
                    Console.WriteLine("Creating unique instance of Chocolate Boiler");
                    _uniqueInstace = new ChocolateBoiler();
                }
                Console.WriteLine("Returning instance of Chocolate Boiler");
                return _uniqueInstace;
            }
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }
    }
}
