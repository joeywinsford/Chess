using System;

namespace Chess
{
    public class Game
    {
        private IPlayer _player;

        public Game(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public Board Board { get; private set; }

        public void CreateStandardBoard()
        {
            Board = new Board(8, 8);
        }

        public IPlayer GetPlayer(PlayerColour playerColour)
        {
            if (_player == null)
            {
                return new PlayerOpening();
            }
            return _player;
        }

        public void Join(IPlayer player)
        {
            _player = player;
        }
    }
}