using System.Threading;
using NUnit.Framework;

namespace ParallelTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1() { Thread.Sleep(1000); }

        [Test]
        public void Test2() { Thread.Sleep(1000); }

        [Test]
        public void Test3() { Thread.Sleep(1000); }
    }
}
