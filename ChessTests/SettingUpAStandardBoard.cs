using System;
using System.Collections.Generic;
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
        [MemberData("GetStandardPieceLayout")]
        public void BoardHasStandardDeploymentOfPieces(File file, Rank rank, Type pieceType, PlayerColour pieceColour)
        {
            var piece = _newGame.GetBoard().GetPieceAtLocation(rank, file);
            Assert.NotNull(piece);
            Assert.IsType(pieceType, piece);
            Assert.Equal(pieceColour, piece.Colour);
        }

        [Theory]
        [MemberData("GetEmptyLocations")]
        public void MiddleOfBoardIsEmpty(File file, Rank rank)
        {
            var piece = _newGame.GetBoard().GetPieceAtLocation(rank, file);
            Assert.Null(piece);
        }

        public static IEnumerable<object[]> GetStandardPieceLayout()
        {
            yield return new object[] { File.A, Rank.Eight, typeof(Rook), PlayerColour.Black };
            yield return new object[] { File.B, Rank.Eight, typeof(Knight), PlayerColour.Black };
            yield return new object[] { File.C, Rank.Eight, typeof(Bishop), PlayerColour.Black };
            yield return new object[] { File.D, Rank.Eight, typeof(Queen), PlayerColour.Black };
            yield return new object[] { File.E, Rank.Eight, typeof(King), PlayerColour.Black };
            yield return new object[] { File.F, Rank.Eight, typeof(Bishop), PlayerColour.Black };
            yield return new object[] { File.G, Rank.Eight, typeof(Knight), PlayerColour.Black };
            yield return new object[] { File.H, Rank.Eight, typeof(Rook), PlayerColour.Black };
            yield return new object[] { File.A, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.B, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.C, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.D, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.E, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.F, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.G, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.H, Rank.Seven, typeof(Pawn), PlayerColour.Black };
            yield return new object[] { File.A, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.B, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.C, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.D, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.E, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.F, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.G, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.H, Rank.Two, typeof(Pawn), PlayerColour.White };
            yield return new object[] { File.A, Rank.One, typeof(Rook), PlayerColour.White };
            yield return new object[] { File.B, Rank.One, typeof(Knight), PlayerColour.White };
            yield return new object[] { File.C, Rank.One, typeof(Bishop), PlayerColour.White };
            yield return new object[] { File.D, Rank.One, typeof(Queen), PlayerColour.White };
            yield return new object[] { File.E, Rank.One, typeof(King), PlayerColour.White };
            yield return new object[] { File.F, Rank.One, typeof(Bishop), PlayerColour.White };
            yield return new object[] { File.G, Rank.One, typeof(Knight), PlayerColour.White };
            yield return new object[] { File.H, Rank.One, typeof(Rook), PlayerColour.White };
        }

        public static IEnumerable<object[]> GetEmptyLocations()
        {
            var emptyRanks = new[] { Rank.Three, Rank.Four, Rank.Five, Rank.Six };
            var files = new[] { File.A, File.B, File.C, File.D, File.E, File.F, File.G, File.H, };
            foreach (var rank in emptyRanks)
            {
                foreach (var file in files)
                {
                    yield return new object[] { file, rank };
                }
            }
        }
    }
}
