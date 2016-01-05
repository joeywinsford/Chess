using System.Collections.Generic;
using Chess;
using Chess.Players;

namespace ChessTests
{
    public class TestOutput : IAppOutput
    {
        public List<string> UnknownCommandErrors { get; } = new List<string>();

        public string LatestGameName { get; set; }
        public int NumberOfStopCommands { get; private set; }
        public int NumberOfColourTakenCannotJoinGameErrors { get; private set; }


        public void OnAppStopping()
        {
            NumberOfStopCommands++;
        }

        public void OnNewGameStarted(Game newGame)
        {
            LatestGameName = newGame.Id;
        }

        public void OnPlayerJoiningGame(IPlayer player, Game game)
        {
            
        }

        public void OnColourTakenCannotJoinGameError(PlayerColour playerColour, Game game)
        {
            NumberOfColourTakenCannotJoinGameErrors++;
        }
    }
}