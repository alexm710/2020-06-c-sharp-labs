using NUnit.Framework;
using System.ComponentModel;
using CalculatorLib;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //Arrange
        [TestCase (4, 6, 10)]
        public void TestingSum(int x, int y, int expectSum)
        {
            //Act
            var actual = Calc.Add(x, y);
            //Assert
            Assert.AreEqual(expectSum, actual);
        }

        [TestCase (15, 7, 8)]
        public void TestingSubtractSum(int x, int y, int expectTotal)
        {
            //Act
            var actual = Calc.Subtract(x, y);
            //Assert
            Assert.AreEqual(expectTotal, actual);
        }

        [TestCase(5, 5, 25)]
        public void TestingMultiplySum(int x, int y, int expectAnswer)
        {
            //Act
            var actual1 = Calc.Multiply(x, y);
            Assert.AreEqual(expectAnswer, actual1);
        }

        [TestCase(20, 5, 4)]
        public void TestingDivisionSum(int x, int y, int expectDiv)
        {
            //Act
            var actual = Calc.Divide(x, y);
            Assert.AreEqual(expectDiv, actual);
        }

        [TestCase(17, 3, 2)]
        public void TestingModulusSum(int x, int y, int expectMod)
        {
            //Act
            var actual = Calc.Modulus(x, y);
            Assert.AreEqual(expectMod, actual);
        }
    }
}