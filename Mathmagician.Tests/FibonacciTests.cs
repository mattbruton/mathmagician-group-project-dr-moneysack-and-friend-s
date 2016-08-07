using System;
using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
