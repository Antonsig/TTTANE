using System;
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

        //public int[,] moves = new int[4, 4];

        public String userName { get ; set; }
        private int totNumberOfMoves;
        /// <summary>
        /// Tvívítt fylki sem inniheldur virði hvers vals fyrir útreikning
        /// á vinningsröð.
        /// </summary>
        //public int[,] boardValue = { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } };
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
        }

       

        #endregion
    }
}
