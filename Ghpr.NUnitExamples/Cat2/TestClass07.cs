using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat2
{
    [TestFixture]
    public class TestClass07
    {
        [Test]
        [Category("Cat2")]
        public void TestMethod1()
        {
            Thread.Sleep(500);
            Assert.AreEqual(1, 2);
        }

        [Test, Category("SuccessCategory")]
        [Category("Cat2")]
        public void TestPassed()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 1);
        }

        [Test, Category("SuccessCategory")]
        [Category("Cat2")]
        public void TestPassed2()
        {
            Thread.Sleep(100);
            Assert.AreEqual(1, 1);
        }

        [Test, Category("SuccessCategory")]
        [Category("Cat2")]
        public void TestPassed3()
        {
            Assert.AreEqual(1, 1);
        }
    }
}