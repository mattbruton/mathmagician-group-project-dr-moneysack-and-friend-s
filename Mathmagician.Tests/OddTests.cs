using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            bool hasEvenNumbers = false;
            test.CreateNumbers(1000000);
            foreach(int number in test.Numbers)
            {
                if(number % 2 == 0)
                {
                    hasEvenNumbers = true;
                }
            }

            Assert.IsFalse(hasEvenNumbers);
        }
    }
}
