using System;
using System.Collections.Generic;
using Chess;

namespace ChessCLI
{
    public class CommandLineOutput : IAppOutput
    {
        public void OnAppStopping()
        {
            Console.WriteLine("TTFN...");
        }

        public void OnNewGameStarted(Game newGame)
        {
            Games.Add(newGame);
            Console.WriteLine("New game: {0}", newGame.Id);
        }

        public void OnPlayerJoiningGame(IPlayer player, Game game)
        {
            Console.WriteLine("Player {0} joined {1}.", player.Name, game.Id);
        }

        public void OnColourTakenCannotJoinGameError(PlayerColour playerColour, Game game)
        {
            throw new NotImplementedException();
        }

        public List<Game> Games { get; } = new List<Game>();
    }
}