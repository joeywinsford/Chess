using System;
using Chess;

namespace ChessCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var session = new Session();

            while (session.IsRunning)
            {
                var input = new Input(Console.ReadLine());
                session.ReceiveInput(input);
            }
        }
    }
}
