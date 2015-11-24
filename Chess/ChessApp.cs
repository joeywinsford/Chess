using System;
using System.Collections.Generic;

namespace Chess
{
    public class ChessApp
    {
        private readonly AppCommandFactory _commandFactory = new AppCommandFactory();

        public ChessApp(IAppOutput output)
        {
            Output = output;
        }

        public IAppOutput Output { get; set; }

        public List<IAppCommand> CommandHistory { get; } = new List<IAppCommand>();
        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(string input)
        {
            var command = _commandFactory.GetCommand(input);

            CommandHistory.Add(command);
            command.Run(this);
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}