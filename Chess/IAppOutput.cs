using System.Collections.Generic;

namespace Chess
{
    public interface IAppOutput
    {
        void OnUnknownCommandError(string unknownCommandName);
        void OnAppStopping();
        void OnNewGameStarted(Game newGame);
    }
}