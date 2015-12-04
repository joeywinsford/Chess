namespace Chess.Commands
{
    public class CreateGameAppCommand : IAppCommand
    {
        public void Run(ChessApp app)
        {
            var game = new Game();
            game.AddBoard(new StandardBoard());
            app.RegisterGame(game);
            app.Output.OnNewGameStarted(game);
        }

        public string CommandName => "New Game";
    }
}