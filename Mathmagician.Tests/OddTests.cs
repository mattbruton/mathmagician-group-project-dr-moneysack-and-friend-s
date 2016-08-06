using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void CanOddBeInstantiated()
        {
            Odd test = new Odd();

            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void OddCreateNumbersAddsExpectedAmountOfNumbersToNumbersList()
        {
            Odd test = new Odd();
            test.CreateNumbers(7);

            Assert.AreEqual(7, test.Numbers.Count);
        }

        [TestMethod]
        public void OddCreateNumbersCreatesOddNumbers()
        {
            Odd test = new Odd();
            test.CreateNumbers(7);
            //  Known consecutive odd numbers: 1, 3, 5, 7, 9, 11, 13
            List<int> testList = new List<int>() { 1, 3, 5, 7, 9, 11, 13 };

            CollectionAssert.AreEqual(test.Numbers, testList);
        }

        [TestMethod]
        public void OddCreateDoesNotCreateEvenNumbers()
        {
            Odd test = new Odd();
            test.CreateNumbers(1000);
            
            Assert.IsFalse(test.Numbers.Any(n => n % 2 == 0));
        }
    }
}
