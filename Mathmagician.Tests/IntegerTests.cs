using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician.Commands;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnIntstance()
        {
            Integer my_int = new Integer();

            Assert.IsNotNull(my_int);
        }

        [TestMethod]
        public void IntegerReturningAStringOfInts()
        {
            Integer testCommand = new Integer();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            testCommand.Numbers.AddRange(testNumbers);

            Assert.IsTrue(testCommand.NumbersToString() is string);
        }

        [TestMethod]
        public void IntegerOutputQuantityMatchesUserInput()
         {
            Integer outputInts = new Integer();
            outputInts.CreateNumbers(6);

            Assert.AreEqual(6, outputInts.Numbers.Count);
        }

        [TestMethod]
        public void CanIntegerCreateInts()
        {
            Integer testInts = new Integer();
            testInts.CreateNumbers(5);
            List<int> intList = new List<int>() { 0, 1, 2, 3, 4 };
        }

      
    }
}
