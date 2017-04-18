using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixtureSource("SomeData")]
    public class TestFixtureSourceTests
    {
        private readonly string _data;

        public TestFixtureSourceTests(string data)
        {
            _data = data;
        }

        [Test]
        public void Test()
        {
            Assert.IsTrue(_data.Equals("data1"));
        }

        public static string[] SomeData = { "data1", "data2" };
    }
}