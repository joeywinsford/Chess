using System.Collections.Generic;

namespace Chess
{
    public class ChessApp
    {
        public ChessApp(IAppOutput output)
        {
            Output = output;
        }

        public IAppOutput Output { get; set; }

        public List<IAppCommand> CommandHistory { get; } = new List<IAppCommand>();
        public bool IsRunning { get; private set; } = true;

        public void ReceiveInput(IAppCommand command)
        {
            CommandHistory.Add(command);
            command.Run(this);
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }

    public interface IAppOutput
    {
        void ReportUnknownCommandError(string unknownCommandName);
    }
}