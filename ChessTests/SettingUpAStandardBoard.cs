using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess;
using Chess.Commands;
using Xunit;

namespace ChessTests
{
    public class SettingUpAStandardBoard
    {
        private readonly Game _newGame;

        public SettingUpAStandardBoard()
        {
            var output = new TestOutput();
            var app = new ChessApp(output);

            app.ReceiveInput(new CreateGameAppCommand());
            _newGame = app.GetGame(output.LatestGameName);
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
        public void BoardHasSpecialBlackPiecesOnFileA(string file, string rank, Type pieceType)
        {
            var piece = _newGame.Board.GetPieceAtLocation(file, rank);
            Assert.NotNull(piece);
            Assert.IsType(pieceType, piece);
            Assert.Equal(PlayerColour.Black, piece.Colour);
        }

        [Theory]
        [InlineData("8")]
        [InlineData("7")]
        [InlineData("6")]
        [InlineData("5")]
        [InlineData("4")]
        [InlineData("3")]
        [InlineData("2")]
        [InlineData("1")]
        public void BoardHasBlackPawnsOnFileB(string rank)
        {
            var piece = _newGame.Board.GetPieceAtLocation("B", rank);
            Assert.IsType<Pawn>(piece);
            Assert.Equal(PlayerColour.Black, piece.Colour);
        }
    }
}
