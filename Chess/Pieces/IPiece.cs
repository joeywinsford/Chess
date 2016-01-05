using Chess.Players;

namespace Chess.Pieces
{
    public interface IPiece
    {
        PlayerColour Colour { get; }
    }
}