using System.Collections;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixtureSource(typeof(MyFixtureData), "FixtureParms")]
    public class ParameterizedTestFixture
    {
        private readonly string _eq1;
        private readonly string _eq2;
        private readonly string _neq;

        public ParameterizedTestFixture(string eq1, string eq2, string neq)
        {
            _eq1 = eq1;
            _eq2 = eq2;
            _neq = neq;
        }

        public ParameterizedTestFixture(string eq1, string eq2)
            : this(eq1, eq2, null) { }

        public ParameterizedTestFixture(int eq1, int eq2, int neq)
        {
            _eq1 = eq1.ToString();
            _eq2 = eq2.ToString();
            _neq = neq.ToString();
        }

        [Test]
        public void TestEquality()
        {
            Assert.AreEqual(_eq1, _eq2);
            if (_eq1 != null && _eq2 != null)
                Assert.AreEqual(_eq1.GetHashCode(), _eq2.GetHashCode());
        }

        [Test]
        public void TestInequality()
        {
            Assert.AreNotEqual(_eq1, _neq);
            if (_eq1 != null && _neq != null)
                Assert.AreNotEqual(_eq1.GetHashCode(), _neq.GetHashCode());
        }
    }


    public class MyFixtureData
    {
        public static IEnumerable FixtureParms
        {
            get
            {
                yield return new TestFixtureData("hello", "hello", "goodbye");
                yield return new TestFixtureData("zip", "zip");
                yield return new TestFixtureData(42, 42, 99);
            }
        }
    }
}