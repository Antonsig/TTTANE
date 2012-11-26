using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TTTANE;

namespace TTTANEtest
{
    public static class GameLogicExtensions
    {
        public static void PlayMoves(this GameLogic game, params string[] moves)
        {
            foreach (var move in moves)
            {
                var player = move.Substring(0, 1);
                var placeChecked = move.Substring(1);
                game.setPlayerInput(Convert.ToInt32(placeChecked), player);
            }
        }
    }
}
