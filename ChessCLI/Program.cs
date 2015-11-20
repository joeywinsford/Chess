using System;
using Chess;

namespace ChessCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new ChessApp(new CommandLineOutput());
            var interpreter = new AppCommandFactory();

            while (app.IsRunning)
            {
                var command = interpreter.Create(Console.ReadLine());
                app.ReceiveInput(command);
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
