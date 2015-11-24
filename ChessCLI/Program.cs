using System;
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
        public void ReportUnknownCommandError(string unknownCommandName)
        {
            Console.WriteLine("Sorry I don't understand '{0}'.", unknownCommandName);
        }

        public void ReportNewGame(Game newGame)
        {
            Games.Add(newGame);
            Console.WriteLine("New game started!");
        }

        public List<Game> Games { get; } = new List<Game>();
    }
}
