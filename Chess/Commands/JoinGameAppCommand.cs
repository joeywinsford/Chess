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

            var player = CreatePlayer(_playerColour);
            game.Join(_playerColour, player);

            app.Output.OnPlayerJoiningGame(player, game);
        }

        private static IPlayer CreatePlayer(PlayerColour playerColour)
        {
            if (playerColour == PlayerColour.Black)
            {
                return new PlayerBlack();
            }
            return new PlayerWhite();
        }

        public string CommandName => "Join Game";
    }
}