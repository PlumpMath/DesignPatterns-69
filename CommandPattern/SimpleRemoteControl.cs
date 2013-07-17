namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        public ICommand Slot;

        public void SetCommand(ICommand command)
        {
            Slot = command;
        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}