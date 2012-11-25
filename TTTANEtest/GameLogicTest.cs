using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTTANE;

namespace TTTANEtest
{
    [TestClass]
    public class GameLogicTest
    {
        [TestMethod]
        ///<Summary>
        ///Gets input from keyboard from each user. Inserts into board array using setBoardValue(int,int,string)
        public void getUserInputTest()
        {
            User user = new User("Player1");
            user.setMove(1, 2);
            

        }

        
    }
}
