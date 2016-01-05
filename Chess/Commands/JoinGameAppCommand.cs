using Chess.Players;

namespace Chess.Commands
{
    public class JoinGameAppCommand : IAppCommand
    {
        private readonly string _gameName;
        private readonly string _playerName;
        private readonly PlayerColour _playerColour;

        public JoinGameAppCommand(string gameName, string playerName, PlayerColour playerColour)
        {
            _gameName = gameName;
            _playerName = playerName;
            _playerColour = playerColour;
        }

        public void Run(ChessApp app)
        {
            var game = app.GetGame(_gameName);

            var player = CreatePlayer(_playerName, _playerColour);
            var result = game.Join(_playerColour, player);

            if (!result.WasSuccess)
            {
                app.Output.OnColourTakenCannotJoinGameError(_playerColour, game);
            }
            else
            {
                app.Output.OnPlayerJoiningGame(player, game);
            }
        }

        private static IPlayer CreatePlayer(string playerName, PlayerColour playerColour)
        {
            if (playerColour == PlayerColour.Black)
            {
                return new PlayerBlack(playerName) ;
            }
            return new PlayerWhite(playerName);
        }
    }

    public class JoinGameResult
    {
        public JoinGameResult(bool wasSuccess)
        {
            WasSuccess = wasSuccess;
        }

        public bool WasSuccess { get; }
    }
}