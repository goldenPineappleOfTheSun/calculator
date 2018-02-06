using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalc;

namespace ConsoleTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Exec("sum", new double[] { 10, 5 });

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestSub()
        {
            // Arrange
            var calc = new Calc();
            var x = 10d;
            var y = 5d;

            // Act
            var result = calc.Exec("sub", new double[] { x, y });

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMul()
        {
            // Arrange
            var calc = new Calc();
            var x = 10d;
            var y = 5d;

            // Act
            var result = calc.Exec("mul", new double[] { x, y });

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calc();
            var x = 10d;
            var y = 5d;

            // Act
            var result = calc.Exec("div", new double[] { x, y });

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}