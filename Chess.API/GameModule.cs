using Chess.Commands;
using Nancy;

namespace Chess.API
{
    public class GameModule : NancyModule
    {
        public GameModule() : base("game")
        {
            Post["new"] = parameters =>
            {
                var output = new AppOutput();
                var app = new ChessApp(output);
                app.ReceiveInput(new CreateGameAppCommand());
                return Response.AsJson(output.NewGame);
            };
        }
    }

    public class AppOutput : IAppOutput
    {
        public void OnAppStopping()
        {
            
        }

        public void OnNewGameStarted(Game newGame)
        {
            NewGame = newGame;
        }

        public Game NewGame { get; private set; }

        public void OnPlayerJoiningGame(IPlayer player, Game game)
        {
            
        }

        public void OnColourTakenCannotJoinGameError(PlayerColour playerColour, Game game)
        {
            
        }
    }
}