namespace Chess.Commands
{
    public class StopAppCommand : IAppCommand
    {
        public void Run(ChessApp app)
        {
            app.Stop();
            app.Output.OnAppStopping();
        }

        public string CommandName => "Stop App";
    }
}