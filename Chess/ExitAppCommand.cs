namespace Chess
{
    public class ExitAppCommand : IAppCommand
    {
        public void Run(ChessApp app)
        {
            app.Stop();
        }
    }
}