using System;

namespace Chess
{
    public class CreateGameAppCommand : IAppCommand
    {
        public void Run(ChessApp app)
        {
            app.CreateGame();
        }

        public string CommandName => "New Game";
    }
}