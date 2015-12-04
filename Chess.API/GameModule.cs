using System;
using Chess.Commands;
using Nancy;

namespace Chess.API
{
    public class GameModule : NancyModule
    {
        public GameModule() : base("game")
        {
            var output = new AppOutput();
            var app = new ChessApp(output);

            Post["new"] = _ =>
            {
                app.ReceiveInput(new CreateGameAppCommand());
                return Response.AsJson(output.NewGame);
            };

            Post["join/{id}/iam/{playerName}/playing/{colour}"] = parameters =>
            {
                string gameId = parameters.id;
                string playerName = parameters.playerName;
                var colour = GetColour(parameters.colour);
                if (colour == null)
                {
                    return HttpStatusCode.BadRequest;
                }
                app.ReceiveInput(new JoinGameAppCommand(gameId, playerName, colour));
                return $"{playerName} joined game {gameId} as {colour}";
            };
        }

        private static PlayerColour? GetColour(string colour)
        {
            if (colour.Equals("black", StringComparison.OrdinalIgnoreCase))
            {
                return PlayerColour.Black;
            }
            if (colour.Equals("white", StringComparison.OrdinalIgnoreCase))
            {
                return PlayerColour.White;
            }
            return null;
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