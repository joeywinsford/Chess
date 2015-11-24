using System;

namespace Chess.Commands
{
    public class JoinGameAppCommand : IAppCommand
    {
        private readonly string _gameName;
        private readonly PlayerColour _playerColour;

        public JoinGameAppCommand(string gameName, PlayerColour playerColour)
        {
            _gameName = gameName;
            _playerColour = playerColour;
        }

        public void Run(ChessApp app)
        {
            var game = app.GetGame(_gameName);
            var player = new PlayerBlack();
            game.Join(player);

            app.Output.OnPlayerJoiningGame(player, game);
        }

        public string CommandName => "Join Game";
    }
}