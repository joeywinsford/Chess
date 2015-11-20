using System;
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
    }
}
