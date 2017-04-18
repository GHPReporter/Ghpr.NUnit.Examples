using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixtureSource("SomeData")]
    public class TestFixtureSourceTests2
    {
        private readonly TestDataObject _data;

        public TestFixtureSourceTests2(TestDataObject data)
        {
            _data = data;
        }

        [Test]
        public void Test()
        {
            Assert.IsTrue(_data.Field1.Equals(1));
            Assert.IsTrue(_data.Field2.Equals("1"));
        }

        public static TestDataObject[] SomeData =
        {
            new TestDataObject { Field1 = 1, Field2 = "1", Field3 = new[]{0.1, 0.2}},
            new TestDataObject { Field1 = 2, Field2 = "2", Field3 = new[]{0.2, 0.4}},
            new TestDataObject { Field1 = 3, Field2 = "3", Field3 = new[]{0.3, 0.6}},
        };
    }

    public class TestDataObject
    {
        public int Field1;
        public string Field2;
        public double[] Field3;

        public override string ToString()
        {
            return $"Field1:{Field1}, Field2:{Field2}";
        }
    }
}