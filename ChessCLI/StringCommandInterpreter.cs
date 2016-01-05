using System;
using Chess;
using Chess.Commands;
using Chess.Players;

namespace ChessCLI
{
    public class StringCommandInterpreter
    {
        private const string Stop = "stop";

        public IAppCommand GetCommand(string input)
        {
            if (input.Equals(Stop, StringComparison.OrdinalIgnoreCase))
            {
                return new StopAppCommand();
            }
            if (input.Equals("new game", StringComparison.OrdinalIgnoreCase))
            {
                return new CreateGameAppCommand();
            }
            if (input.StartsWith("join game "))
            {
                if (input.EndsWith("black"))
                {
                    return new JoinGameAppCommand("game1", "blackplayer",  PlayerColour.Black);
                }
                if (input.EndsWith("white"))
                {
                    return new JoinGameAppCommand("game1", "whiteplayer", PlayerColour.White);
                }
            }
            return null;
        }
    }
}