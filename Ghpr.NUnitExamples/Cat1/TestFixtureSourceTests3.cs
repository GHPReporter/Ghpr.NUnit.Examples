using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixtureSource("SomeData")]
    public class TestFixtureSourceTests3
    {
        private readonly TestDataObject2 _data;

        public TestFixtureSourceTests3(TestDataObject2 data)
        {
            _data = data;
        }

        [Test]
        public void Test()
        {
            Assert.IsTrue(_data.Field1.Equals(1));
            Assert.IsTrue(_data.Field2.Equals("1"));
        }

        public static TestDataObject2[] SomeData =
        {
            new TestDataObject2 { Field1 = 1, Field2 = "1", Field3 = new[]{0.1, 0.2}},
            new TestDataObject2 { Field1 = 2, Field2 = "2", Field3 = new[]{0.2, 0.4}},
            new TestDataObject2 { Field1 = 3, Field2 = "3", Field3 = new[]{0.3, 0.6}}
        };
    }

    //this object will give the wrong test list!
    public class TestDataObject2
    {
        public int Field1;
        public string Field2;
        public double[] Field3;
    }
}