using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_W2D2
{
    [TestClass]
    public class CalculatorTest
    {
        //Create a field that basically an ACTUAL Calculator for us to us
        public Calculator calc = new Calculator();

        [TestMethod]
        public void AddTest_ShouldReturnTheCorrectValueWhenAddingTwoNumbers()
        {
            double expected = 10;
            double actual = calc.AddTwoNumbers(7.5, 2.5);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest_intDoubleOverload_ShouldReturnTheCorrectValueWhenAddingTwoNumbers()
        {
            int expected = 15;
            int actual = calc.AddTwoNumbers(10, 5);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTest_ShouldReturnTheCorrectValueWhenSubtractingTwoNumbers()
        {
            double expected = 1;
            double actual = calc.SubtractTwoNumbers(3, 2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MultipleTest_ShouldReturnTheCorrectValueWhenMultiplyingTwoNumbers()
        {
            double expected = 10;
            double actual = calc.MultiplyTwoNumbers(5, 2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTest_ShouldReturnTheCorrectValueWhenDividingTwoNumbers()
        {
            double expected = 3;
            double actual = calc.DivideTwoNumbers(9, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDifference_DoubleArrayOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            double expected = 10d;
            double actual = calc.Difference(100d, 50d, 40d);

            //Array
            Assert.AreEqual(expected, actual);
        }
    }
}
