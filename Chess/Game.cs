using System;

namespace Chess
{
    public class Game
    {
        public Board Board { get; private set; }

        public void CreateStandardBoard()
        {
            Board = new Board(8, 8);
        }
    }
}