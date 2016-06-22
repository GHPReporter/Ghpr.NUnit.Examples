using System;
using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples
{
    [TestFixture]
    public class TestClass1
    {
        [Test, Property("TestGuid", "11111111-1111-1111-1111-111111111111")]
        public void UnsuccessTestThreeEvents()
        {
            Assert.AreEqual(1, 2);
        }
        
        [Test, Property("TestGuid", "11111111-1111-1111-1111-111111111112")]
        public void SuccessTestThreeEvents()
        {
            var r = new Random();
            Thread.Sleep(r.Next(700));
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void LongLogTest()
        {
            Console.WriteLine("Testing log writing 1");
            Thread.Sleep(100);
            Console.WriteLine("Testing log writing 2");
            Thread.Sleep(200);
            Console.WriteLine("Testing log writing 3");
            Thread.Sleep(100);
            Console.WriteLine("Testing log writing 4");
            Thread.Sleep(200);
            Console.WriteLine("Testing log writing 5");
            for (var i = 6; i < 55; i++)
            {
                Console.WriteLine("Testing log writing " + i);
            }
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void SuccessTest()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void ErrorExpected()
        {
            Thread.Sleep(300);
            throw new Exception("Some error occured!");
        }

        [Test]
        public void TestMethodInconclusive()
        {
            Thread.Sleep(300);
            Assert.Inconclusive("Inconc. test :)");
        }

        [Test]
        public void TestMethodIgnored()
        {
            Thread.Sleep(300);
            Assert.Ignore("Test was ignored!");
        }

        [Test]
        public void TestMethodIgnored2()
        {
            Thread.Sleep(300);
            Assert.Ignore("Test was ignored!");
        }
    }
}
