﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTTANE
{
    /// <summary>
    ///  Klasinn geymir upplýsingar um notandann.
    /// </summary>
    class User
    {
        #region Klasabreytur

        public int[,] moves = new int[4, 4];

        public String userName { get; set; }

        /// <summary>
        /// Tvívítt fylki sem inniheldur virði hvers vals fyrir útreikning
        /// á vinningsröð.
        /// </summary>
        public int[,] boardValue = { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } };
        #endregion

        #region Class Methods
        /// <summary>
        ///  Smiður fyrir User klasann sem gefur honum nafnið Player ef
        ///  ekkert nafn er valið.
        /// </summary>
        public User(String newname)
        {
            if (newname.Length == 0)
            {
                userName = "Player";
            }
            else
            {
                userName = newname;
            }

            resetMoves();
        }

        /// <summary>
        ///  Skilar True ef einhver röð gefur SUM 15
        ///  annars false.
        /// </summary>
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

        /// <summary>
        /// Setur öll gildi í moves breytunni í 0.
        /// </summary>
        public void resetMoves()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    moves[i,j] = 0;
                }
            }
        }

        /// <summary>
        ///  Reiknar út samtalgildi úr innra 3x3 fylkinu.
        ///  Ysti dálkurinn og neðsta röðin geyma gildin.
        /// </summary>
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

        /// <summary>
        /// Skilar false ef val notanda er ekki leyft
        /// eða reitur hefur þegar verið valinn. Annars True
        /// </summary>
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
                            setMove(row, column);
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
        /// <summary>
        /// Skilar gildi vals notanda.
        /// </summary>
        public int getBoardValue(int i, int j)
        {
            return boardValue[i,j];
        }

        /// <summary>
        /// Vistar val notanda og keyrir uppfærslu á moves-fylkið
        /// </summary>
        public void setMove(int a, int b)
        {
            moves[a, b] = boardValue[a, b];
            calculateArray();
        }

        #endregion
    }
}
