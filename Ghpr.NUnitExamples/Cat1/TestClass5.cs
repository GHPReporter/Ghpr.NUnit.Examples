using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixture]
    public class TestClass5
    {
        [Test]
        [Category("Cat1")]
        public void TestMethod1()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 2);
        }

        [Test, Category("SuccessCategory")]
        [Category("Cat1")]
        public void TestMethod2()
        {
            Thread.Sleep(100);
            Assert.AreEqual(1, 1);
        }

        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2, TestName = "Testing name attribute")]
        [Category("SuccessCategory")]
        [Category("Cat1")]
        public void ParamTestName(string input, int expected)
        {
            Thread.Sleep(100);
            Assert.AreEqual(input, expected.ToString("D"));
        }
    }
}