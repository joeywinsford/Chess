using System.Collections.Generic;
using Chess.Commands;

namespace Chess
{
    public class Game
    {
        private readonly Dictionary<PlayerColour, IPlayer> _players = new Dictionary<PlayerColour, IPlayer>();

        public Game(string name, IBoard board)
        {
            Name = name;
            Board = board;
        }

        public string Name { get; private set; }

        public IBoard Board { get; private set; }

        public IPlayer GetPlayer(PlayerColour playerColour)
        {
            if (!_players.ContainsKey(playerColour))
            {
                return new PlayerOpening();
            }
            return _players[playerColour];
        }

        public JoinGameResult Join(PlayerColour playerColour, IPlayer player)
        {
            if (_players.ContainsKey(playerColour))
            {
                return new JoinGameResult(wasSuccess:false);
            }

            _players.Add(playerColour, player);
            return new JoinGameResult(wasSuccess:true);
        }
    }

    
}