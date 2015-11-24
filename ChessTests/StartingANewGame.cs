using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingANewGame
    {
        private readonly Game _newGame;

        public StartingANewGame()
        {
            var output = new TestOutput();
            var app = new ChessApp(output);

            app.ReceiveInput("new game");
            _newGame = app.GetGame(output.LatestGameId);
        }

        [Fact]
        public void NewGameHasAStandard8X8ChessBoard()
        {
            Assert.NotNull(_newGame.Board);
            Assert.Equal(8, _newGame.Board.Width);
            Assert.Equal(8, _newGame.Board.Height);
        }

        [Fact]
        public void NewGameHasTwoOpeningsForPlayers()
        {
            var player1 = _newGame.GetPlayer(PlayerColour.Black);
            Assert.IsType<PlayerOpening>(player1);

            var player2 = _newGame.GetPlayer(PlayerColour.White);
            Assert.IsType<PlayerOpening>(player2);
        }
    }
}
