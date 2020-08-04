using NUnit.Framework;
using lab_17_selection;
namespace lab_18_tests_for_lab_17
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Mark40AndOverPass()
        {
            var result = Selection.PassFail(40);
            var result2 = result.ToLower(); // turning answer to lower case
            Assert.AreEqual("Distinction", result2);
        }

        public void Mark39AndUnderPasses()
        {
            var result = Selection.PassFail(39);
            Assert.AreEqual("Merit", result);
        }

        public void Mark39AndUnderPasses()
        {
            var result = Selection.PassFail(39);
            Assert.AreEqual("Pass`", result);
        }
    }
}