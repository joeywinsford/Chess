using Chess.Players;

namespace Chess
{
    public interface IAppOutput
    {
        void OnAppStopping();
        void OnNewGameStarted(Game newGame);
        void OnPlayerJoiningGame(IPlayer player, Game game);
        void OnColourTakenCannotJoinGameError(PlayerColour playerColour, Game game);
    }
}