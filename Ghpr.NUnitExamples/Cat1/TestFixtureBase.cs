using System;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat1
{
    public class TestFixtureBase
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Console.WriteLine("OneTimeSetUp Base");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("OneTimeTearDown Base");
        }
    }
}