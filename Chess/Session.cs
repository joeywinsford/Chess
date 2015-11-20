using System.Collections.Generic;

namespace Chess
{
    public class Session
    {
        public List<ISessionCommand> Inputs { get; } = new List<ISessionCommand>();
        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(ISessionCommand sessionCommand)
        {
            Inputs.Add(sessionCommand);
            if (sessionCommand is ExitSessionCommand)
            {
                IsRunning = false;
            }
        }
    }
}