using System;
using System.CodeDom;
using Chess;
using Chess.Commands;
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

            _app.ReceiveInput(new CreateGameAppCommand());
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
            _app.ReceiveInput(new JoinGameAppCommand(_latestGameName, "denise", PlayerColour.Black));
            _app.ReceiveInput(new JoinGameAppCommand(_latestGameName, "derek", PlayerColour.White));

            var blackPlayer = _newGame.GetPlayer(PlayerColour.Black);
            Assert.IsType<PlayerBlack>(blackPlayer);

            var whitePlayer = _newGame.GetPlayer(PlayerColour.White);
            Assert.IsType<PlayerWhite>(whitePlayer);
        }

        [Theory]
        [InlineData("A", "8", typeof(Rook))]
        [InlineData("A", "7", typeof(Knight))]
        [InlineData("A", "6", typeof(Bishop))]
        [InlineData("A", "5", typeof(Queen))]
        [InlineData("A", "4", typeof(King))]
        [InlineData("A", "3", typeof(Bishop))]
        [InlineData("A", "2", typeof(Knight))]
        [InlineData("A", "1", typeof(Rook))]
        [InlineData("B", "8", typeof(Pawn))]
        [InlineData("B", "7", typeof(Pawn))]
        [InlineData("B", "6", typeof(Pawn))]
        [InlineData("B", "5", typeof(Pawn))]
        [InlineData("B", "4", typeof(Pawn))]
        [InlineData("B", "3", typeof(Pawn))]
        [InlineData("B", "2", typeof(Pawn))]
        [InlineData("B", "1", typeof(Pawn))]
        public void BoardHasStandardBlackPiecesOnFileAAndB(string file, string rank, Type pieceType)
        {
            var piece = _newGame.Board.GetPieceAtLocation(file, rank);
            Assert.NotNull(piece);
            Assert.IsType(pieceType, piece);
        }
    }
}
