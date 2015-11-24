﻿using System;
using System.Collections.Generic;
using Chess;

namespace ChessCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new ChessApp(new CommandLineOutput());

            while (app.IsRunning)
            {
                app.ReceiveInput(Console.ReadLine());
            }
        }
    }

    public class CommandLineOutput : IAppOutput
    {
        public void OnUnknownCommandError(string unknownCommandName)
        {
            Console.WriteLine("Sorry I don't understand '{0}'.", unknownCommandName);
        }

        public void OnAppStopping()
        {
            Console.WriteLine("TTFN...");
        }

        public void OnNewGameStarted(Game newGame)
        {
            Games.Add(newGame);
            Console.WriteLine("New game: {0}", newGame.Name);
        }

        public void OnPlayerJoiningGame(IPlayer player, Game game)
        {
            Console.WriteLine("Player {0} joined {1}.", player.GetType(), game.Name);
        }

        public List<Game> Games { get; } = new List<Game>();
    }
}
