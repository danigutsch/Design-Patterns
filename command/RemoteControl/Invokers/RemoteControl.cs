using RemoteControl.Commands;
using System.Text;

namespace RemoteControl.Invokers
{
    public class RemoteControl
    {
        readonly ICommand[] _onCommands;
        readonly ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control -------\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot ").Append(i).Append("] ").Append(_onCommands[i].GetType().Name).Append("    ").Append(_offCommands[i].GetType().Name).Append('\n');
            }

            return stringBuilder.ToString();
        }
    }
}
