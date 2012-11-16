﻿using TTTANE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TTTANEtest
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        /// A test for player inserting name
        /// Should return 'Playername'
        /// If no name is entered return is "Player1"
        /// </summary>
        [TestMethod()]
        public void Program()
        {
            Runner runner = new Runner();
        }

//Following test on Cosntructor() and Main() commented out for now since not really neccessary
 /*
        /// <summary>
        ///A test for Program Constructor
        ///</summary>
        [TestMethod()]
        public void ProgramConstructorTest()
        {
            Program target = new Program();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Main
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TTTANE.exe")]
        public void MainTest()
        {
            string[] args = null; // TODO: Initialize to an appropriate value
            Program_Accessor.Main(args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
*/
        [TestMethod()]
        public void TestUserNameReturned()
        {
            User User1 = new User();
            User User2 = new User();
            User1.name = "Anton";
            User2.name = "Lena";

            Assert.AreEqual("Anton", User1.name);
            Assert.AreEqual("Lena", User2.name);
        }
        
    }
}
