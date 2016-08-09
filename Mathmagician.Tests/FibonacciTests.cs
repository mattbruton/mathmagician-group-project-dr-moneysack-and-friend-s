using System;
using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciCanBeInstantiated()
        {
            Fibonacci test = new Fibonacci();
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void FibonacciCreatesAString()
        {
            Fibonacci test = new Fibonacci();
            test.CreateNumbers(7);

            Assert.AreEqual(7, test.Numbers.Count); 
        }

        [TestMethod]
        public void FibonacciIsCorrectSequence()
        {
            Fibonacci test = new Fibonacci();
            test.CreateNumbers(7);

            List<int> testList = new List<int>() { 0, 1, 1, 2, 3, 5, 8 };
            
            CollectionAssert.AreEqual(testList,  test.Numbers);
        }
    }
}
