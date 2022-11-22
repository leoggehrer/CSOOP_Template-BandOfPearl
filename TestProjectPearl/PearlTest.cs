using BandOfPearl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectPearl
{
    
    
    /// <summary>
    ///This is a test class for PearlTest and is intended
    ///to contain all PearlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PearlTest
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


        [TestMethod()]
        public void P01_ConstructorSimple()
        {
            Pearl pearl = new Pearl("Red", 1.7);
            Assert.AreEqual("Red", pearl.Color);
            Assert.AreEqual(1.7, pearl.Weight);
        }

        [TestMethod()]
        public void P02_ConstructorFailure()
        {
            Pearl pearl = new Pearl("Yellow", -10);
            Assert.AreEqual("Unknown", pearl.Color);
            Assert.AreEqual(0, pearl.Weight);
        }

        [TestMethod()]
        public void P03_ConstructorNullFailure()
        {
            Pearl pearl = new Pearl(null, -10);
            Assert.AreEqual("Unknown", pearl.Color);
            Assert.AreEqual(0, pearl.Weight);
        }
    }
}
