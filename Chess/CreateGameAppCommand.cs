using System;

namespace Chess
{
    public class CreateGameAppCommand : IAppCommand
    {
        public void Run(ChessApp app)
        {
            var game = new Game();
            game.CreateStandardBoard();

            app.Output.OnNewGameStarted(game);
        }

        public string CommandName => "New Game";
    }
}