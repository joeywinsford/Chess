using System.Collections.Generic;

namespace Chess
{
    public class Session
    {
        public List<ISessionCommand> CommandHistory { get; } = new List<ISessionCommand>();
        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(ISessionCommand command)
        {
            CommandHistory.Add(command);
            command.Run(this);
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}