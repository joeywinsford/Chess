using Chess.Players;

namespace Chess.Pieces
{
    public class Rook : IPiece
    {
        public Rook(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}