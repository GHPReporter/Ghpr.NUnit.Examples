﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Ghpr.NUnit.Utils;
using NUnit.Framework;

namespace Ghpr.NUnitTests
{
    [TestFixture]
    public class TestingScreenshotTaking
    {
        public const string GhprNUnitOutputFolder = @"C:\_GHPReportOutput";

        public static byte[] TakeScreen()
        {
            var b = Screen.PrimaryScreen.Bounds;
            var ic = new ImageConverter();
            using (var btm = new Bitmap(b.Width, b.Height))
            using (var g = Graphics.FromImage(btm))
            {
                g.CopyFromScreen(b.X, b.Y, 0, 0, btm.Size, CopyPixelOperation.SourceCopy);
                return (byte[])ic.ConvertTo(btm, typeof(byte[]));
            }
        }

        [Test(Description = "This is example of taking screenshots inside test")]
        [Category("Screenshots")]
        public void TestMethodPassed()
        {
            Console.WriteLine("Taking screen...");
            var bytes = TakeScreen();
            //all you need to do is to pass byte[] to ScreenHelper:
            ScreenHelper.SaveScreenshot(bytes, GhprNUnitOutputFolder);
            Console.WriteLine("Done.");
        }
    }
}