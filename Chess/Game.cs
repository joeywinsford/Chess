using System;
using System.Collections.Generic;
using Chess.Commands;
using Chess.Players;

namespace Chess
{
    public class Game
    {
        private IBoard _board;

        public Dictionary<PlayerColour, IPlayer> Players { get; } = new Dictionary<PlayerColour, IPlayer>();

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public IBoard GetBoard()
        {
            return _board;
        }

        public IPlayer GetPlayer(PlayerColour playerColour)
        {
            if (!Players.ContainsKey(playerColour))
            {
                return new PlayerOpening();
            }
            return Players[playerColour];
        }

        public JoinGameResult Join(PlayerColour playerColour, IPlayer player)
        {
            if (Players.ContainsKey(playerColour))
            {
                return new JoinGameResult(wasSuccess:false);
            }

            Players.Add(playerColour, player);
            return new JoinGameResult(wasSuccess:true);
        }

        public void AddBoard(IBoard board)
        {
            _board = board;
        }
    }

    
}