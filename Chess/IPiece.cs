namespace Chess
{
    public interface IPiece
    {
        PlayerColour Colour { get; }
    }

    public class Rook : IPiece
    {
        public PlayerColour Colour { get; }
    }
}