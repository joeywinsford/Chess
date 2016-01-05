using Chess.Players;

namespace Chess.Pieces
{
    public class Knight : IPiece
    {
        public Knight(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}