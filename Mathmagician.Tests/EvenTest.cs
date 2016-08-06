using Mathmagician.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
           
        }
    }
}
