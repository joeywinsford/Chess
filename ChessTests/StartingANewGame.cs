using System.Linq;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingANewGame
    {
        [Fact]
        public void NewGameHasAStandard8X8ChessBoard()
        {
            var output = new TestOutput();
            var app = new ChessApp(output);

            app.ReceiveInput("new game");
            var game = output.Games.Last();

            Assert.NotNull(game.Board);
            Assert.Equal(8, game.Board.Width);
            Assert.Equal(8, game.Board.Height);
        }
    }
}
