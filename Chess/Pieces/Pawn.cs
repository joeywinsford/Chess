using Chess.Players;

namespace Chess.Pieces
{
    public class Pawn : IPiece
    {
        public Pawn(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}