using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician.Commands;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnIntstance()
        {
            //Arrange

            //Act
            Integer my_int = new Integer();//what i want to be able to do
            //Assert
            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void EnsureMethodIsReturningAString()
        {
            Integer testCommand = new Integer();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            testCommand.Numbers.AddRange(testNumbers);

            Assert.IsTrue(testCommand.NumbersToString() is string);
        }

        [TestMethod]
        public void EnsureMethodIsPrintingNumbersToList()
        {
            Integer test = new Integer();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            test.Numbers.AddRange(testNumbers);

            Assert.AreEqual("Here are your Integers: \n1, 2, 3, 4, 5", test.NumbersToString());
        }

        [TestMethod]
        public void EnsureQuantityOfNumsToGenerateIsCorrect()
        {
            
        }
    }
}
