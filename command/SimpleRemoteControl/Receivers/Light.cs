namespace SimpleRemoteControl.Receivers
{
    public class Light
    {
#pragma warning disable CA1822 // Mark members as static
        public void On() => Console.WriteLine("Light is on");
        public void Off() => Console.WriteLine("Light is off");
#pragma warning restore CA1822 // Mark members as static
    }
}