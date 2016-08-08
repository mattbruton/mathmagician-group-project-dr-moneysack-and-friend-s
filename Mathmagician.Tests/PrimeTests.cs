using System;
using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void PrimeTestPrimeCanBeInstantiated()
        {
            Prime test = new Prime();

            Assert.IsNotNull(test);
        }
    }
}
