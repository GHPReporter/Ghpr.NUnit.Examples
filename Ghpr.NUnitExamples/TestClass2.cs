using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples
{

    [TestFixture]
    public class TestClass2
    {
        [Test]
        public void TestMethod1()
        {
            Thread.Sleep(500);
            Assert.AreEqual(1, 2);
        }

        [Test, Category("SuccessCategory")]
        public void TestPassed()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 1);
        }

        [Test, Category("SuccessCategory")]
        public void TestPassed2()
        {
            Thread.Sleep(100);
            Assert.AreEqual(1, 1);
        }

        [Test, Category("SuccessCategory")]
        public void NoGuidTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}