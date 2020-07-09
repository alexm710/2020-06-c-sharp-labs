using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using lab_15_unit_testing;

namespace lab_16_nunit_testing
{
    public class Tests
    {
        private int _result;
        private int _sum;
        [SetUp]
        public void Setup()
        {
            _result = Calc.TripleCalc(10, 2, 4, out int sum);
            _sum = sum;
        }

        [Test]
        public void ProdutIsCorrect()
        {
            // arrange and act  (3 a's in testing, arrange, act, assert)
            var actualResult = Calc.TripleCalc(10, 2, 4, out int sum);
            // Assert
            Assert.AreEqual(80, actualResult);
        }

        [Test]
        public void SumIsCorrect()
        {
            // Assert
            Assert.AreEqual(16, _sum);
        }
    }
}