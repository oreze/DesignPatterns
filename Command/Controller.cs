using System;
using System.Collections.Generic;

namespace ConsoleApp1.Command
{
    public class Controller: Command
    {
        private Queue<Command> _currentCommands { get; }
        private Stack<Command> _previousCommands { get; }

        public Controller()
        {
            _currentCommands = new Queue<Command>();
            _previousCommands = new Stack<Command>();
        }

        public void AddCommand(Command command)
        {
            _currentCommands.Enqueue(command);
        }

        public void Execute()
        {
            Console.WriteLine("Execute next command...");
            var currentCommand = _currentCommands.Dequeue();
            currentCommand.Execute();
            _previousCommands.Push(currentCommand);
        }

        public void Undo()
        {
            if (_previousCommands.Count > 0)
            {
                Console.WriteLine("Undo previous command...");
                _previousCommands.Pop().Undo();
            }
            else
            {
                Console.WriteLine("Cannot undo previous because stack is empty.");
            }
        }
    }
}