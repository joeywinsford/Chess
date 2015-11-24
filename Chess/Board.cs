namespace Chess
{
    public class Board
    {
        public Board(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }
    }
}