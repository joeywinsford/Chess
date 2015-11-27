namespace Chess
{
    public interface IPiece
    {
        PlayerColour Colour { get; }
    }

    public class Rook : IPiece
    {
        public Rook(PlayerColour colour)
        {
            Colour = colour;
        }

        public PlayerColour Colour { get; }
    }
}