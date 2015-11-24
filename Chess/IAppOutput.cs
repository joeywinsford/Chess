using System.Collections.Generic;

namespace Chess
{
    public interface IAppOutput
    {
        void ReportUnknownCommandError(string unknownCommandName);
        void ReportNewGame(Game newGame);
    }
}