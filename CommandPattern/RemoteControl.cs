using System;
using System.Text;
using System.Collections.Generic;
using System.Dynamic;

namespace CommandPattern
{
    class RemoteControl
    {
        private IDictionary<string, ICommand> _onCommands;
        private IDictionary<string, ICommand> _offCommands;

        public RemoteControl()
        {
            _onCommands = new Dictionary<string, ICommand>();
            _offCommands = new Dictionary<string, ICommand>();
        }

        public void AddCommand(string label, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[label] = onCommand;
            _offCommands[label] = offCommand;
        }

        public void RemoveCommand(string label)
        {
            _onCommands.Remove(label);
            _offCommands.Remove(label);
        }

        public void TurnOn(string label)
        {
            _onCommands[label].Execute();
        }

        public void TurnOff(string label)
        {
            _offCommands[label].Execute();
        }

        public override string ToString()
        {
            var buffer = new StringBuilder();
            buffer.Append("\n------ Remote Control Configuration -------\n");
            foreach (var onCommand in _onCommands)
            {
                buffer.Append("[Button " + onCommand.Key + "] " + onCommand.Value.GetType());
                buffer.Append("\t" + _offCommands[onCommand.Key].GetType() + "\n");
            }
            return buffer.ToString();
        }
    }
}