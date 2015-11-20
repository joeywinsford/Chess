using System;
using Chess;

namespace ChessCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new ChessApp();
            var interpreter = new AppCommandFactory();

            while (app.IsRunning)
            {
                var command = interpreter.Create(Console.ReadLine());
                app.ReceiveInput(command);
            }
        }
    }
}
