using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Chess
{
    public interface IBoard
    {
        IPiece GetPieceAtLocation(Rank rank, File file);
    }

    public class StandardBoard : IBoard
    {
        private readonly List<IBoardEvent> _events = new List<IBoardEvent>();

        public StandardBoard()
        {
            SetUp();
        }

        private void SetUp()
        {
            foreach (var rank in Ranks)
            {
                foreach (var file in Files)
                {
                    SpawnPiece(rank, file, InitialPieceAtLocation(rank, file));
                }
            }
        }

        private static IEnumerable<File> Files => Enumerable.Range(1, 8).Select(f => (File) f);

        private static IEnumerable<Rank> Ranks => Enumerable.Range(1, 8).Select(r => (Rank) r);

        private void SpawnPiece(Rank rank, File file, IPiece piece)
        {
            _events.Add(new SpawnPiece(piece, new Location(rank, file)));
        }

        public IPiece GetPieceAtLocation(Rank rank, File file)
        {
            var maybePiece = _events.OfType<SpawnPiece>().LastOrDefault(e => e.Location.Rank == rank && e.Location.File == file);
            return maybePiece?.Piece;
        }

        private static IPiece InitialPieceAtLocation(Rank rank, File file)
        {
            var emptyRanks = new[] { Rank.Three, Rank.Four, Rank.Five, Rank.Six};
            if (emptyRanks.Contains(rank))
            {
                return null;
            }

            var colour = PlayerColour.Black;
            if (rank == Rank.One || rank == Rank.Two)
            {
                colour = PlayerColour.White;
            }

            IPiece piece = new Rook(colour);
            if (rank == Rank.Seven || rank == Rank.Two)
            {
                piece = new Pawn(colour);
            }
            else if (file == File.B || file == File.G)
            {
                piece = new Knight(colour);
            }
            else if (file == File.C || file == File.F)
            {
                piece = new Bishop(colour);
            }
            else if (file == File.D)
            {
                piece = new Queen(colour);
            }
            else if (file == File.E)
            {
                piece = new King(colour);
            }
            
            return piece;
        }
    }

    public interface IBoardEvent
    {
        IPiece Piece { get; set; }
        Location Location { get; set; }
    }

    public class SpawnPiece : IBoardEvent
    {
        public IPiece Piece { get; set; }
        public Location Location { get; set; }

        public SpawnPiece(IPiece piece, Location location)
        {
            Piece = piece;
            Location = location;
        }
    }
}