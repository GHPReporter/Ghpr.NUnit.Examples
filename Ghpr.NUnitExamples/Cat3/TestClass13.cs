﻿using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat3
{
    [TestFixture, Ignore("Ignored test fixture")]
    public class TestClass13
    {
        [Test]
        [Category("Cat2")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 2);
        }

        [Test, Category("SuccessCategory")]
        [Category("Cat2")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}