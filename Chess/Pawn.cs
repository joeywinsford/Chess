namespace Chess
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