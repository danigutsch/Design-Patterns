namespace SimpleRemoteControl.Receivers
{
    public class GarageDoor
    {
#pragma warning disable CA1822 // Mark members as static
        public void Up() => Console.WriteLine("Garage Door is Open");
        public void Down() => Console.WriteLine("Garage Door is Closed");
        public void Stop() => Console.WriteLine("Garage Door is Stopped");
        public void LightOn() => Console.WriteLine("Garage light is on");
        public void LightOff() => Console.WriteLine("Garage light is off");
#pragma warning restore CA1822 // Mark members as static
    }
}