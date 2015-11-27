namespace Chess
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