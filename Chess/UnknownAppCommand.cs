namespace Chess
{
    public class UnknownAppCommand : IAppCommand
    {
        private readonly string _input;

        public UnknownAppCommand(string input)
        {
            this._input = input;
        }

        public void Run(ChessApp app)
        {
            app.Output.ReportUnknownCommandError(_input);
        }
    }
}