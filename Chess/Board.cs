using System.Linq;

namespace Chess
{
    public class Board
    {
        public Board(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public IPiece GetPieceAtLocation(string file, string rank)
        {
            var emptyRanks = new[] {"3", "4", "5", "6"};
            if (emptyRanks.Contains(rank))
            {
                return null;
            }

            var colour = PlayerColour.Black;
            if (rank == "1" || rank == "2")
            {
                colour = PlayerColour.White;
            }

            IPiece piece = new Rook(colour);
            if (rank == "7" || rank == "2")
            {
                piece = new Pawn(colour);
            }
            else if (file == "B" || file == "G")
            {
                piece = new Knight(colour);
            }
            else if (file == "C" || file == "F")
            {
                piece = new Bishop(colour);
            }
            else if (file == "D")
            {
                piece = new Queen(colour);
            }
            else if (file == "E")
            {
                piece = new King(colour);
            }

            
            return piece;
        }
    }
}