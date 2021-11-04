﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : Piece
    {
        public Bishop(Player player, int x)
        {
            if (player == Player.Black) {
                Position = new Coordinate(x, 0);
                PlayerColor = Player.Black;
            }
            if (player == Player.White) {
                Position = new Coordinate(x, 7);
                PlayerColor = Player.White;
            }
            id = 'b';
        }

        public override bool IsPossibleMove(int x, int y)
        {
            int initialX = Position.X;
            int initialY = Position.Y;

            return MovementsKit.DiagonalsMove(initialX, initialY, x, y);
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
