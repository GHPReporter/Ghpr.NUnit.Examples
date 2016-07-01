using System;
using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat3
{
    [TestFixture]
    public class TestClass11
    {
        private static void RandomResultMethod()
        {
            var r = new Random();
            var randValue = r.Next(1000);
            if (randValue > 0)//passed
            {
                Assert.AreEqual(1, 1);
            }
            else if (randValue > 199)//failed
            {
                Assert.AreEqual(1, 2);
            }
            else if (randValue > 399)//failed
            {
                throw new Exception("Broken:(");
            }
            else if (randValue > 599)//ignored
            {
                Assert.Ignore("Ignored test");
            }
            else if (randValue > 799)//failed
            {
                Assert.Inconclusive("Iconc. test");
            }
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest1()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest2()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest3()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest4()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest5()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest6()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest7()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest8()
        {
            RandomResultMethod();
        }

        [Test]
        [Category("Cat2")]
        public void RandomResultTest9()
        {
            RandomResultMethod();
        }
    }
}
