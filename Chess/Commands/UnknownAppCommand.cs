namespace Chess.Commands
{
    public class UnknownAppCommand : IAppCommand
    {
        public UnknownAppCommand(string input)
        {
            CommandName = input;
        }

        public void Run(ChessApp app)
        {
            app.Output.OnUnknownCommandError(CommandName);
        }

        public string CommandName { get; }
    }
}