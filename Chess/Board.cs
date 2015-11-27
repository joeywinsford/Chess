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

        public IPiece GetPieceAtLocation(string rank, string file)
        {
            var colour = PlayerColour.Black;
            if (file == "1" || file == "2")
            {
                colour = PlayerColour.White;
            }

            IPiece piece = new Rook(colour);
            if (file == "7" || file == "2")
            {
                piece = new Pawn(colour);
            }
            else if (rank == "B" || rank == "G")
            {
                piece = new Knight(colour);
            }
            else if (rank == "C" || rank == "F")
            {
                piece = new Bishop(colour);
            }
            else if (rank == "D")
            {
                piece = new Queen(colour);
            }
            else if (rank == "E")
            {
                piece = new King(colour);
            }

            
            return piece;
        }
    }
}