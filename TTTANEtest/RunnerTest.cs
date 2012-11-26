using System.IO;
using TTTANE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TTTANEtest
{
    
    
    /// <summary>
    ///This is a test class for RunnerTest and is intended
    ///to contain all RunnerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RunnerTest
    {
        //private StringReader _input;
        //private StringWriter _output;
        private Runner _runner;
        
        [TestInitialize]
        public void InitializeRunner()
        {
            //_input = new StringReader();
            //_output = new StringWriter();
            _runner = new Runner();
            //var standardOut = new StreamWriter(Console.OpenStandardOutput());
            //standardOut.AutoFlush = true;
            //Console.SetOut(standardOut);
        }
        /// <summary>
        ///A test for Runner Constructor
        ///</summary>
        [TestMethod]
        public void IsRunnerRunning()
        {
            //_runner 
            //var output =
            //Assert.AreEqual<string>(output, _runner.PlayerSelect());
            //using (var sw = new StringWriter())
            //{
            //    Console.SetOut(sw);

            //    using (var sr = new StringReader("X"))
            //    {
            //        Console.SetIn(sr);
                   

            //        var expected = string.Format("Choose X or O{0}X", Environment.NewLine);
            //        Assert.AreEqual<string>(expected, sw.ToString());
            //    }
            //}
            //TODO: Unit test to ask for player X or O
            //var askForPlayer = "Choose X or O";
            //Assert.AreEqual("X", player);
        }

       // [TestMethod]
//public void ValidateConsoleOutput()
//{
//    using (StringWriter sw = new StringWriter())
//    {
//        Console.SetOut(sw);
 
//        ConsoleUser cu = new ConsoleUser();
//        cu.DoWork();
 
//        string expected = 
//            string.Format("Ploeh{0}", Environment.NewLine);
//        Assert.AreEqual<string>(expected, sw.ToString());
//    }
//}


        //[TestMethod]
        //public void ()
        //{
        //    //TODO: Unit test to ask for player X or O
        //    Assert.Inconclusive("TODO: Implement code to verify target");
        //}

    }
}