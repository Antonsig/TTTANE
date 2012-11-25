using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTTANE
{
    class User
    {
        #region Klasabreytur
        public int[,] moves = new int[4, 4];

        public String name { get; set; }
        //two dimentional array with score value of each move
        public int[,] boardvalue = { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } };
        #endregion

        #region Class Methods
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

            resetMoves();
        }
             

        //saves moves when the input has been fixed from user
        //allowed inputs are {0,1,2} to both parameters
        //triggers calculatearray function
        public void saveMove(int a, int b)
        {
            moves[a, b] = boardvalue[a, b];
            calculateArray();
        }

        //returns true if a row in moves has the sum of 15
        //otherwise false
        public bool isWinner()
        {
            bool winnerfound = false;

            //for testing
            StringBuilder st = new StringBuilder();

            for(int i=0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    //for testing
                    st.Append(moves[i,j]);
                    st.Append(",");
                    if (moves[i, j] == 15)
                    { 
                        winnerfound = true;                   
                    }
                }
            }

            //for testing
            Console.WriteLine(st);

            return winnerfound;
        }

        //resets moves array to zero.
        public void resetMoves()
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    moves[i,j] = 0;
                }
            }
        }

        //calculates sums of a all rows in moves array.
        //winning row has the sum of 15
        public void calculateArray()
        {
            moves[0, 3] = moves[0, 0] + moves[0, 1] + moves[0, 2];
            moves[1, 3] = moves[1, 0] + moves[1, 1] + moves[1, 2];
            moves[2, 3] = moves[2, 0] + moves[2, 1] + moves[2, 2];
            moves[3, 3] = moves[0, 0] + moves[1, 1] + moves[2, 2];
            moves[3, 2] = moves[0, 2] + moves[1, 2] + moves[2, 2];
            moves[3, 1] = moves[0, 1] + moves[1, 1] + moves[2, 1];
            moves[3, 0] = moves[0, 0] + moves[1, 0] + moves[2, 0];
        }

        //returns false if input from user is illegal
        //or if the move has already been made.
        //otherwise true
        public bool parseInput(string s)
        {
            bool isok = false;
        
            if (s.Length == 2)
            {
                int row = 5;//this initial value is to high to be approved.
                int column = int.Parse(s[1].ToString()) - 1;
                s = s.ToUpper();

                switch (s[0])
                {
                    case 'A':
                        row = 0;
                        break;
                    case 'B':
                        row = 1;
                        break;
                    case 'C':
                        row = 2;
                        break;
                }

            if (row == 0 || row == 1 || row == 2)
            {
                if (column == 0 || column == 1 || column == 2)
                {
                    if (moves[row, column] == 0)
                        {
                            isok = true;
                            saveMove(row, column);
                            Console.WriteLine("Value is: {0}{1}", row, column);
                        }
                        else
                        {
                            isok = false;
                        }
                    }
                }
            }

            return isok;
        }

        #endregion

        #region Getters/Setters
        public int getBoardValue(int i, int j)
        {
            return boardvalue[i,j];
        }

        //Hvernig typecastar maður String inn í Int array? 
        //Inserts 'X' og 'O' into board.
        public void setBoardValue(int i, int j, String k)
        {
            boardvalue[i,j] = (String)k;

    }
}
