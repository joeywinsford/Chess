namespace Chess
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