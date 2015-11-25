using System;
using Chess;

namespace ChessCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new ChessApp(new CommandLineOutput());
            var interpreter = new StringCommandInterpreter();

            while (app.IsRunning)
            {
                var input = Console.ReadLine();
                var command = interpreter.GetCommand(input);
                if (command != null)
                {
                    app.ReceiveInput(command);
                }
                else
                {
                    Console.WriteLine("Unknown command '{0}'.", input);
                }
            }
        }
    }
}
