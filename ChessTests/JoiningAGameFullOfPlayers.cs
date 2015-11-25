using Chess;
using Chess.Commands;
using Xunit;

namespace ChessTests
{
    public class JoiningAGameFullOfPlayers
    {
        private readonly TestOutput _output;
        private readonly IPlayer _existingBlackPlayer;
        private readonly IPlayer _existingWhitePlayer;

        public JoiningAGameFullOfPlayers()
        {
            _output = new TestOutput();
            var app = new ChessApp(_output);

            app.ReceiveInput(new CreateGameAppCommand());
            var latestGameName = _output.LatestGameName;
            var newGame = app.GetGame(latestGameName);

            app.ReceiveInput(new JoinGameAppCommand(latestGameName, "denise", PlayerColour.Black));
            app.ReceiveInput(new JoinGameAppCommand(latestGameName, "derek", PlayerColour.White));

            _existingBlackPlayer = newGame.GetPlayer(PlayerColour.Black);
            _existingWhitePlayer = newGame.GetPlayer(PlayerColour.White);

            app.ReceiveInput(new JoinGameAppCommand(latestGameName, "gary", PlayerColour.Black));
        }

        [Fact]
        public void PlayerIsNotifiedIfTheyTryToJoinAGameAsAColourAlreadyTaken()
        {
            Assert.Equal(1, _output.NumberOfColourTakenCannotJoinGameErrors);
        }

        [Fact]
        public void ExistingPlayersAreUnchanged()
        {
            Assert.Equal("denise", _existingBlackPlayer.Name);
            Assert.Equal("derek", _existingWhitePlayer.Name);
        }
    }
}