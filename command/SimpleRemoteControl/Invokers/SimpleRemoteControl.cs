using SimpleRemoteControl.Commands;

namespace SimpleRemoteControl.Invokers
{
    public class SimpleRemoteControl
    {
        public ICommand? _slot;

        public void SetCommand(ICommand command) => _slot = command;

        public void ButtonWasPressed() => _slot?.Execute();
    }
}
