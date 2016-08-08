using System;
using Mathmagician.Commands;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void PrimeDoesNotGenerateNonPrimeNumbers()
        {
            // Known low non-primes: 4, 6, 9, 12, 14, 15
            int[] lowNonPrimes = { 4, 6, 9, 12, 14, 15 };
            Prime test = new Prime();
            test.CreateNumbers(20);

            Assert.IsFalse(test.Numbers.Any(n => lowNonPrimes.Contains(n)));

        }
    }
}
