using Chess.Players;

namespace Chess.Pieces
{
    public class Queen : IPiece
    {
        public Queen(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}