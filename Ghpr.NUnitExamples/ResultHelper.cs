using System;
using NUnit.Framework;

namespace Ghpr.NUnitExamples
{
    public static class ResultHelper
    {
        public static void RandomResultMethod()
        {
            var r = new Random();
            var randValue = r.Next(1000);
            if (randValue > 0 && randValue <= 199)//passed
            {
                Assert.AreEqual(1, 1);
            }
            else if (randValue > 199 && randValue <= 399)//failed
            {
                Assert.AreEqual(1, 2);
            }
            else if (randValue > 399 && randValue <= 599)//broken
            {
                throw new Exception("Broken:(");
            }
            else if (randValue > 599 && randValue <= 799)//ignored
            {
                Assert.Ignore("Ignored test");
            }
            else if (randValue > 799)//inconclusive
            {
                Assert.Inconclusive("Iconc. test");
            }
        }
    }
}