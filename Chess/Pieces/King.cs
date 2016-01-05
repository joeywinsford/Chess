using Chess.Players;

namespace Chess.Pieces
{
    public class King : IPiece
    {
        public King(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}