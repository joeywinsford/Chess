using Chess.Players;

namespace Chess.Pieces
{
    public class Bishop : IPiece
    {
        public Bishop(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}