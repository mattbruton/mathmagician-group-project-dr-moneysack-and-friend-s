using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void EvenEnsureICanCreateAnIntstance()
        {
            Even evenInts = new Even();
            Assert.IsNotNull(evenInts);
        }

        [TestMethod]
        public void EvenNumsOutputsUserSpecifiedQuantity()
        {
            Even outputEvens = new Even();
            outputEvens.CreateNumbers(7);
            Assert.AreEqual(7, outputEvens.Numbers.Count);
        }

        [TestMethod]
        public void EvenEnsureNumsInListAreAllEven()
        {
            Even test = new Even();
            test.CreateNumbers(1000);
            Assert.IsTrue(test.Numbers.Any(n => n % 2 == 0));
        }

        [TestMethod]
        public void EvenEnsureNumsAreNotOdd()
        {
            Even test = new Even();
            test.CreateNumbers(1000);
            Assert.IsFalse(test.Numbers.Any(n => n % 2 != 0));
        }
    }
}
