﻿using System;
using System.Threading;
using NUnit.Framework;

namespace Ghpr.NUnitExamples.Cat2
{
    [TestFixture]
    public class TestClass09
    {
        [TestCase("0", 1, "11111111-1111-1111-1111-111111111141", TestName = "Test 1")]
        [TestCase("1", 1, "11111111-1111-1111-1111-111111111142", TestName = "Test 2")]
        [TestCase("2", 2, "11111111-1111-1111-1111-111111111143", TestName = "Test 3")]
        [TestCase("3", 3, "11111111-1111-1111-1111-111111111144", TestName = "Test with really really really really really really really " +
                                                                             "really really really really really really really really really " +
                                                                             "really really really really really really really really really " +
                                                                             "really really really really really really really really really " +
                                                                             "really really really really really really really really long name")]
        [TestCase("4", 4, "11111111-1111-1111-1111-111111111145", TestName = "Test 5")]
        [TestCase("5", 5, "11111111-1111-1111-1111-111111111146", TestName = "Test 6")]
        [TestCase("6", 6, "11111111-1111-1111-1111-111111111147", TestName = "Test 7")]
        [TestCase("7", 7, "11111111-1111-1111-1111-111111111148", TestName = "Test 8")]
        [Category("Cat2")]
        public void ParamTestName(string input, int expected, string guid)
        {
            Console.WriteLine($"Guid: {guid}");
            Thread.Sleep(100);
            Assert.AreEqual(input, expected.ToString("D"));
        }
    }
}