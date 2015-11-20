namespace Chess
{
    public class UnknownAppCommand : IAppCommand
    {
        public UnknownAppCommand(string input)
        {
            CommandName = input;
        }

        public void Run(ChessApp app)
        {
            app.Output.ReportUnknownCommandError(CommandName);
        }

        public string CommandName { get; }
    }
}