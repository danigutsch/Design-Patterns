using RemoteControl.Commands;
using RemoteControl.Receivers;

namespace RemoteControl
{
    public static class Program
    {
        public static void Main()
        {
            var remoteControl = new Invokers.RemoteControl();

            Light livingRoomLight = new("Living Room");
            Light kitchenLight = new("Kitchen");
            CeilingFan ceilingFan = new("Living Room");
            GarageDoor garageDoor = new("");
            Stereo stereo = new("Living Room");

            LightOnCommand livingRoomLightOn = new(livingRoomLight);
            LightOffCommand livingRoomLightOff = new(livingRoomLight);
            LightOnCommand kitchenLightOn = new(kitchenLight);
            LightOffCommand kitchenLightOff = new(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new(garageDoor);
            GarageDoorDownCommand garageDoorDown = new(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new(stereo);
            StereoOffCommand stereoOff = new(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(4, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
        }
    }
}