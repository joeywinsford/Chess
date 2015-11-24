using System;

namespace Chess
{
    public class Game
    {
        public Board Board { get; private set; }
        public Guid Id { get; private set; } = Guid.NewGuid();

        public void CreateStandardBoard()
        {
            Board = new Board(8, 8);
        }

        public IPlayer GetPlayer(PlayerColour playerColour)
        {
            return new PlayerOpening();
        }
    }
}