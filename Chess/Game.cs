using System;
using System.Collections.Generic;

namespace Chess
{
    public class Game
    {
        private Dictionary<PlayerColour, IPlayer> _players = new Dictionary<PlayerColour, IPlayer>();

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
            if (!_players.ContainsKey(playerColour))
            {
                return new PlayerOpening();
            }
            return _players[playerColour];
        }

        public void Join(PlayerColour playerColour, IPlayer player)
        {
            _players.Add(playerColour, player);
        }
    }
}