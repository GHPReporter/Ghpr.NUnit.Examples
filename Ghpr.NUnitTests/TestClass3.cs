using NUnit.Framework;

namespace Ghpr.NUnitTests
{
    [TestFixture, Ignore("Ignored test fixture")]
    public class TestClass3
    {
        [Test]
        [Category("Cat3")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 2);
        }

        [Test, Category("SuccessCategory")]
        [Category("Cat3")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}