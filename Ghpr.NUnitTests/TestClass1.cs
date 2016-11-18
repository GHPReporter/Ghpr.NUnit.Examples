using System;
using System.Threading;
using NUnit.Engine.Drivers;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Ghpr.NUnitTests
{
    [TestFixture]
    public class TestClass1
    {
        [TestCase("0", 0, "11111111-1111-1111-1111-111111111211")]
        [TestCase("1", 1, "11111111-1111-1111-1111-111111111212")]
        [TestCase("2", 2, "11111111-1111-1111-1111-111111111213", TestName = "Testing name attribute")]
        [Category("Cat1")]
        public void ParamTestName1(string input, int expected, string guid)
        {
            Thread.Sleep(200);
            Assert.AreEqual(input, expected.ToString("D"));
        }

        [TestCase("0", 1, "11111111-1111-1111-1111-111111111214", TestName = "param test 1")]
        [TestCase("1", 1, "11111111-1111-1111-1111-111111111215", TestName = "param test 2")]
        [TestCase("2", 1, "11111111-1111-1111-1111-111111111216", TestName = "param test 3")]
        [Category("Cat1")]
        public void ParamTestName2(string input, int expected, string guid)
        {
            Assert.AreEqual(input, expected.ToString("D"));
        }

        [Test]
        [Category("Cat1")]
        [Property("aaa", 42)]
        public void TestMethod3()
        {
            Console.WriteLine("Testing log writing 1");
            Console.WriteLine("Testing log writing 2");
            
            var pb=  new PropertyBag();
            pb.Add("a", "1");
            pb.Add("b", "2");
            pb.Add("b", "3");
            foreach (var key in pb.Keys)
            {
                TestContext.CurrentContext.Test.Properties.Add(key, pb.Get(key));
            }

            Console.Write($"{TestContext.CurrentContext.Test.FullName}");

            var p = TestContext.CurrentContext.Test.Properties;

            foreach (var k in p.Keys)
            {
                Console.WriteLine($"k: {k}, v: {p.Get(k)}");
            }

            //throw new Exception("Some error occured!");
        }
    }
}
