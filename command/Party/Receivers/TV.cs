namespace Party.Receivers
{
    public class TV
    {
        private readonly string _location;
#pragma warning disable IDE0052 // Remove unread private members
        private int _channel;
#pragma warning restore IDE0052 // Remove unread private members

        public TV(string location)
        {
            _location = location;
        }

        public void On() => Console.WriteLine(_location + " TV is on");

        public void Off() => Console.WriteLine(_location + " TV is off");

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine(_location + " TV channel is set for DVD");
        }
    }
}