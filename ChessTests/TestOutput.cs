using System;
using System.Collections.Generic;
using Chess;

namespace ChessTests
{
    public class TestOutput : IAppOutput
    {
        public List<string> UnknownCommandErrors { get; } = new List<string>();

        public string LatestGameName { get; set; }
        public int NumberOfStopCommands { get; private set; }


        public void OnUnknownCommandError(string unknownCommandName)
        {
            UnknownCommandErrors.Add(unknownCommandName);
        }

        public void OnAppStopping()
        {
            NumberOfStopCommands++;
        }

        public void OnNewGameStarted(Game newGame)
        {
            LatestGameName = newGame.Name;
        }

        public void OnPlayerJoiningGame(IPlayer player, Game game)
        {
            
        }
    }
}