using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public void ThisIsNotATest()
        {

        }
        [TestMethod]
        public void TestThatThisIsTrue()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ThisShouldFail()
        {
            //Arrange
            //Act
            //Assert
            Assert.Fail();

        }
    }
}
