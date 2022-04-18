using RemoteControlWithUndo.Commands;
using RemoteControlWithUndo.Receivers;

namespace RemoteControlWithUndo
{
    public static class Program
    {
        public static void Main()
        {
            var remoteControl = new Invokers.RemoteControlWithUndo();

            Light livingRoomLight = new("Living Room");

            LightOnCommand livingRoomLightOn = new(livingRoomLight);
            LightOffCommand livingRoomLightOff = new(livingRoomLight);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            CeilingFan ceilingFan = new("Living Room");

            CeilingFanMediumCommand ceilingFanMedium = new(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
        }
    }
}