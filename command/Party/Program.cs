using Party.Commands;
using Party.Invokers;
using Party.Receivers;

namespace Party
{
    public static class Program
    {
        public static void Main()
        {
            var remoteControl = new RemoteControl();

            Light light = new("Living Room");
            TV tv = new("Living Room");
            Stereo stereo = new("Living Room");
            Hottub hottub = new();

            LightOnCommand lightOn = new(light);
            StereoOnCommand stereoOn = new(stereo);
            TVOnCommand tvOn = new(tv);
            HottubOnCommand hottubOn = new(hottub);
            LightOffCommand lightOff = new(light);
            StereoOffCommand stereoOff = new(stereo);
            TVOffCommand tvOff = new(tv);
            HottubOffCommand hottubOff = new(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new(partyOn);
            MacroCommand partyOffMacro = new(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Off---");
            remoteControl.OffButtonWasPushed(0);
        }
    }
}