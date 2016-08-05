﻿using System;
using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class CommandTests
    {
        // Need to create a mock Class to be used in testing the abstract class "Command".
        public class TestClass : Command { }

        [TestMethod]
        public void AssertNumbersToStringReturnsString()
        {
            TestClass test = new TestClass();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            test.Numbers.AddRange(testNumbers);

            Assert.IsTrue(test.NumbersToString() is string);  
        }

        [TestMethod]
        public void AssertNumbersToStringReturnsCorrectMessageWithEmptyList()
        {
            
            TestClass test = new TestClass();
            int[] testNumbers = {};
            test.Numbers.AddRange(testNumbers);

            Assert.AreEqual("Give me a quantity that I can work with! At least let me show you a single number.", test.NumbersToString());
        }

        [TestMethod]
        public void AssertNumbersToStringIsPrintingAllNumbersInList()
        {
            
            TestClass test = new TestClass();
            int[] testNumbers = { 1, 2, 3, 4, 5 };
            test.Numbers.AddRange(testNumbers);

            Assert.AreEqual("Here are your numbers: \n1, 2, 3, 4, 5", test.NumbersToString());
        }

        [TestMethod]
        public void TestThatClassesCanInheritFromCommand()
        { 
            TestClass test = new TestClass();
            // NumbersToString is inherited from Command
            string testString = test.NumbersToString();
            Assert.IsNotNull(testString);
        }
}
}