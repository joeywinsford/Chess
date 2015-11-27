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
        [MemberData("GetStandardBoardLayout")]
        public void BoardHasStandardDeploymentOfPieces(string file, string rank, Type pieceType, PlayerColour pieceColour)
        {
            var piece = _newGame.Board.GetPieceAtLocation(file, rank);
            Assert.NotNull(piece);
            Assert.IsType(pieceType, piece);
            Assert.Equal(pieceColour, piece.Colour);
        }

        public static IEnumerable<object[]> GetStandardBoardLayout()
        {
            yield return new object[] { "A", "8", typeof(Rook), PlayerColour.Black };
            yield return new object[] { "B", "8", typeof(Knight), PlayerColour.Black };
            yield return new object[] { "C", "8", typeof(Bishop), PlayerColour.Black };
            yield return new object[] { "D", "8", typeof(Queen), PlayerColour.Black };
            yield return new object[] { "E", "8", typeof(King), PlayerColour.Black };
            yield return new object[] { "F", "8", typeof(Bishop), PlayerColour.Black };
            yield return new object[] { "G", "8", typeof(Knight), PlayerColour.Black };
            yield return new object[] { "H", "8", typeof(Rook), PlayerColour.Black };
            yield return new object[] { "A", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "B", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "C", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "D", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "E", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "F", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "G", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "H", "7", typeof(Pawn), PlayerColour.Black };
            yield return new object[] { "A", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "B", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "C", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "D", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "E", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "F", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "G", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "H", "2", typeof(Pawn), PlayerColour.White };
            yield return new object[] { "A", "1", typeof(Rook), PlayerColour.White };
            yield return new object[] { "B", "1", typeof(Knight), PlayerColour.White };
            yield return new object[] { "C", "1", typeof(Bishop), PlayerColour.White };
            yield return new object[] { "D", "1", typeof(Queen), PlayerColour.White };
            yield return new object[] { "E", "1", typeof(King), PlayerColour.White };
            yield return new object[] { "F", "1", typeof(Bishop), PlayerColour.White };
            yield return new object[] { "G", "1", typeof(Knight), PlayerColour.White };
            yield return new object[] { "H", "1", typeof(Rook), PlayerColour.White };
        }
    }
}
