﻿namespace Chess.Players
{
    public class PlayerBlack : IPlayer
    {
        public PlayerBlack(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}