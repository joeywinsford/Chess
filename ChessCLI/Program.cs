using System;
using Chess;

namespace ChessCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var session = new Session();
            var interpreter = new StringInputInterpreter();

            while (session.IsRunning)
            {
                var command = interpreter.Resolve(Console.ReadLine());
                session.ReceiveInput(command);
            }
        }
    }
}
