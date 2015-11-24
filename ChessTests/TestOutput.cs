using System.Collections.Generic;
using Chess;

namespace ChessTests
{
    public class TestOutput : IAppOutput
    {
        public List<string> UnknownCommandErrors { get; } = new List<string>();
        public List<Game> Games { get; } = new List<Game>();

        public void ReportUnknownCommandError(string unknownCommandName)
        {
            UnknownCommandErrors.Add(unknownCommandName);
        }
    }
}