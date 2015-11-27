namespace Chess
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