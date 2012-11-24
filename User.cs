using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTTANE
{
    class User
    {
        public User(String newname)
        {
            if (newname.Length == 0)
            {
                name = "Player";
            }
            else
            {
                name = newname;
            }
            resetmoves();

        }

        public int[,] moves = new int[5, 5];

        public String name { get; set; }

        public void resetmoves()
        {
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    moves[i,j] = 0;
                }
            }
        }
    }
}
