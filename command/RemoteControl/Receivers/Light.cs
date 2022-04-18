namespace RemoteControl.Receivers
{
    public class Light
    {
        private readonly string _location;

        public Light(string Location)
        {
            _location = Location;
        }

        public void On() => Console.WriteLine(_location + " light is on");

        public void Off() => Console.WriteLine(_location + "light is off");
    }
}