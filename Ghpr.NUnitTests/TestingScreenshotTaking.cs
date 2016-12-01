using System;
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

        public static void TakeScreen()
        {
            var b = Screen.PrimaryScreen.Bounds;
            var ic = new ImageConverter();
            using (var btm = new Bitmap(b.Width, b.Height))
            using (var g = Graphics.FromImage(btm))
            {
                g.CopyFromScreen(b.X, b.Y, 0, 0, btm.Size, CopyPixelOperation.SourceCopy);
                var bytes = (byte[])ic.ConvertTo(btm, typeof(byte[]));
                ScreenHelper.SaveScreenshot(bytes, GhprNUnitOutputFolder);
            }
        }

        [Test]
        [Category("Screenshots")]
        [Property("aaa", 42)]
        public void TestMethodPassed()
        {
            Console.Write("This is example of taking screenshots inside test");
            Console.WriteLine("Taking screen...");
            TakeScreen();
            Console.WriteLine("Done.");
        }
    }
}