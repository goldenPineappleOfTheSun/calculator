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
            var x = 10d;
            var y = 5d;

            // Act
            var result = calc.Exec("sum", new double[] { x, y });

            // Assert
            Assert.AreEqual(15, result);
        }

        /*
        [TestMethod]
        public void TestSub()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Sub(x, y);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMul()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Mul(x, y);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Div(x, y);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMax()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Max(x, y);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMin()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Min(x, y);

            // Assert
            Assert.AreEqual(5, result);
        }*/
    }
}