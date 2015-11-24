using System;
using Chess;
using Xunit;

namespace ChessTests
{
    public class StartingANewGame
    {
        private readonly Game _newGame;
        private readonly ChessApp _app;
        private readonly string _latestGameName;

        public StartingANewGame()
        {
            var output = new TestOutput();
            _app = new ChessApp(output);

            _app.ReceiveInput("new game");
            _latestGameName = output.LatestGameName;
            _newGame = _app.GetGame(_latestGameName);
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
            var blackPlayer = _newGame.GetPlayer(PlayerColour.Black);
            Assert.IsType<PlayerOpening>(blackPlayer);

            var whitePlayer = _newGame.GetPlayer(PlayerColour.White);
            Assert.IsType<PlayerOpening>(whitePlayer);
        }

        [Fact]
        public void TwoPlayersCanJoinAnOpeningInANewGame()
        {
            _app.ReceiveInput($"join game {_latestGameName} as black");
            _app.ReceiveInput($"join game {_latestGameName} as white");

            var blackPlayer = _newGame.GetPlayer(PlayerColour.Black);
            Assert.IsType<PlayerBlack>(blackPlayer);

            var whitePlayer = _newGame.GetPlayer(PlayerColour.White);
            Assert.IsType<PlayerWhite>(whitePlayer);
        }
    }
}
