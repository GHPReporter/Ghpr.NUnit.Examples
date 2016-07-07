using System;
using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixture]
    public class TestClass1
    {
        [Test, Property("TestGuid", "11111111-1111-1111-1111-111111111111"), 
            Property("Priority", "High"), 
            Property("TestType", "Smoke")]
        [Category("Cat1")]
        [Category("Failed")]
        public void SimpleFailedTest()
        {
            Console.WriteLine("This is test output, we are logging some stuff!");
            Assert.AreEqual(1, 2);
        }
        
        [Test, Property("TestGuid", "11111111-1111-1111-1111-111111111112")]
        [Category("Cat1")]
        public void RandomDurationPassedTest()
        {
            var r = new Random();
            Thread.Sleep(r.Next(700));
            Assert.AreEqual(1, 1);
        }

        [Test]
        [Category("Cat1")]
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
        [Category("Cat1")]
        public void SuccessTest()
        {
            Thread.Sleep(200);
            Assert.AreEqual(1, 1);
        }

        [Test]
        [Category("Cat1")]
        public void ErrorExpected()
        {
            Thread.Sleep(300);
            throw new Exception("Some error occured!");
        }

        [Test]
        [Category("Cat1")]
        public void TestMethodInconclusive()
        {
            Thread.Sleep(300);
            Assert.Inconclusive("Inconc. test :)");
        }

        [Test]
        [Category("Cat1")]
        public void TestMethodIgnored()
        {
            Thread.Sleep(300);
            Assert.Ignore("Test was ignored!");
        }

        [Test]
        [Category("Cat1")]
        public void TestMethodIgnored2()
        {
            Thread.Sleep(300);
            Assert.Ignore("Test was ignored!");
        }
    }
}
