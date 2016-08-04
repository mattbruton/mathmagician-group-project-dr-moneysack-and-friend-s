using System;
using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void AssertNumbersToStringReturnsString()
        {
            Command testCommand = new Command();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            testCommand.Numbers.AddRange(testNumbers);

            Assert.IsTrue(testCommand.NumbersToString() is string);
        }

        [TestMethod]
        public void AssertNumbersToStringIsPrintingAllNumbersInList()
        {
            Command testCommand = new Command();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            testCommand.Numbers.AddRange(testNumbers);

            Assert.AreEqual("1, 2, 3, 4, 5", testCommand.NumbersToString());
        }
    }
}
