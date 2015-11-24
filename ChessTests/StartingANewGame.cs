using System;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingANewGame
    {
        private readonly Game _newGame;
        private readonly ChessApp _app;

        public StartingANewGame()
        {
            var output = new TestOutput();
            _app = new ChessApp(output);

            _app.ReceiveInput("new game");
            _newGame = _app.GetGame(output.LatestGameName);
        }

        [Fact]
        public void NewGameHasAn8X8ChessBoard()
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

        [Fact]
        public void PlayerCanJoinAnOpeningInANewGameAsBlack()
        {
            _app.ReceiveInput("join game game1 as black");

            var player1 = _newGame.GetPlayer(PlayerColour.Black);
            Assert.IsType<PlayerBlack>(player1);
        }
    }
}
