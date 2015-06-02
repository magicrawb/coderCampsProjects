using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day4UnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.AddNumbers(0, 0);

            //Assert
            Assert.AreEqual(0, result);

        }
    }
}
