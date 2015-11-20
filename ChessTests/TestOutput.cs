using System.Collections.Generic;
using Chess;

namespace ChessTests
{
    public class TestOutput : IAppOutput
    {
        public List<string> UnknownCommandErrors { get; } = new List<string>();

        public void ReportUnknownCommandError(string unknownCommandName)
        {
            UnknownCommandErrors.Add(unknownCommandName);
        }
    }
}