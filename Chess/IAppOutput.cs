namespace Chess
{
    public interface IAppOutput
    {
        void OnUnknownCommandError(string unknownCommandName);
        void OnAppStopping();
        void OnNewGameStarted(Game newGame);
        void OnPlayerJoiningGame(IPlayer player, Game game);
    }
}