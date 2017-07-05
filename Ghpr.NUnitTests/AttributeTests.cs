using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Ghpr.Core;
using Ghpr.Core.Enums;
using Ghpr.Core.Interfaces;
using Ghpr.Core.Utils;
using Ghpr.NUnit.Attributes;
using Ghpr.NUnit.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace Ghpr.NUnitTests
{
    [TestFixture]
    public class AttributeTests
    {
        [AttributeUsage(AttributeTargets.Method)]
        public class MyTestAttribute : Attribute, ITestAction
        {
            public void BeforeTest(ITest nunitTest)
            {
            }

            public void AfterTest(ITest nunitTest)
            {
                if (!nunitTest.IsSuite)
                {
                    var testNode = nunitTest.ToXml(false);
                    var testXml = testNode.OuterXml;
                    Console.WriteLine(testXml);
                }
            }

            public ActionTargets Targets => ActionTargets.Test;
            
        }

        [TestCase("0", 0)]
        [TestCase("1", 2)]
        [Category("AttrTests")]
        [MyTest]
        public void AttrParamTestName1(string input, int expected)
        {
            Console.WriteLine("Here is my test!");
            Thread.Sleep(200);
            Assert.AreEqual(input, expected.ToString("D"));
        }
    }
}