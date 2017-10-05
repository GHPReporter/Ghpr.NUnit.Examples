using System;
using System.Threading;
using Ghpr.NUnit.Utils;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    [TestFixture]
    public class TestClass1
    {
        private const string Actual = @"
<?xml version=""1.0""?>
<PARTS>
   <TITLE>Computer Parts</TITLE>
   <PART>
      <ITEM>Motherboard</ITEM>
      <MANUFACTURER>ASUS</MANUFACTURER>
      <MODEL>P3B-F</MODEL>
      <COST>123.00</COST>
   </PART>
</PARTS>
";
        private const string Expected = @"
<?xml version=""1.0""?>
<PARTS>
   <TITLE>Computer Parts</TITLE>
   <PART>
      <ITEM>Motherboard</ITEM>
      <MANUFACTURER>ASWS</MANUFACTURER>
      <MODEL>P3B-F</MODEL>
      <COST>124.00</COSTT>
   </QWER>
</PARTS>
";

        [Test, Property("TestGuid", "11111111-1111-1111-1111-111111111111"), 
            Property("Priority", "High"), 
            Property("TestType", "Smoke")]
        [Category("Cat1")]
        [Category("Failed")]
        [Description("This is test description")]
        public void SimpleFailedTest()
        {
            Console.WriteLine("This is test output, we are logging some stuff!");
            Console.WriteLine($"Comparing '{Actual}' and '{Expected}'");
            TestDataHelper.AddTestData(Actual, Expected, "Let's compare to XML strings!");
            Console.WriteLine($"Comparing '{Actual}' and '{Expected}'");
            TestDataHelper.AddTestData(Actual, Expected, "Let's compare for the second time!");
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
