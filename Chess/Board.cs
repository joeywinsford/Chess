using System;
using System.Collections.Generic;
using System.Data.Common;

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

        public IPiece GetPieceAtLocation(string file, string rank)
        {
            if (file == "B")
            {
                return new Pawn();
            }
            if (rank == "7" || rank == "2")
            {
                return new Knight();
            }
            if (rank == "6" || rank == "3")
            {
                return new Bishop();
            }
            if (rank == "5")
            {
                return new Queen();
            }
            if (rank == "4")
            {
                return new King();
            }
            return new Rook();
        }
    }
}