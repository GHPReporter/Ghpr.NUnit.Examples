using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Ghpr.NUnit.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Ghpr.NUnitTests
{
    [TestFixture]
    public class TestingScreenshotTaking
    {
        [TearDown]
        public void TakeScreenIfFailed()
        {
            var res = TestContext.CurrentContext.Result.Outcome;
            if (res.Equals(ResultState.Failure) || res.Equals(ResultState.Error))
            {
                ScreenHelper.SaveScreenshot(TakeScreen());
            }
        }

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

        public static string SaveScreen(byte[] screen, string fileName)
        {
            var folder = @"C:\Screenshots";
            Directory.CreateDirectory(folder);
            var fullPath = Path.Combine(folder, fileName);
            File.WriteAllBytes(fullPath, screen);
            return fullPath;
        }

        [Test(Description = "This is example of taking screenshots inside test")]
        [Category("Screenshots")]
        public void TestMethodPassed()
        {
            Console.WriteLine("Taking screen...");
            var bytes = TakeScreen();
            //all you need to do is to pass byte[] to ScreenHelper:
            ScreenHelper.SaveScreenshot(bytes);
            Console.WriteLine("Done.");
        }

        [Test(Description = "This is example of taking screenshots inside test")]
        [Category("Screenshots")]
        public void TestMethodFailed()
        {
            Console.WriteLine("Taking screen...");
            var bytes = TakeScreen();
            //all you need to do is to pass byte[] to ScreenHelper:
            ScreenHelper.SaveScreenshot(bytes);
            Console.WriteLine("Done.");
            Assert.Fail("Noooooo..... Test is failed.");
        }

        [Test(Description = "This is example of saving screenshots using NUnit context")]
        [Category("Screenshots")]
        public void TestMethod()
        {
            Console.WriteLine("Taking screen...");
            var bytes = TakeScreen();
            var fullPath1 = SaveScreen(bytes, Guid.NewGuid() + ".png");
            var fullPath2 = SaveScreen(bytes, Guid.NewGuid() + ".png");
            var fullPath3 = SaveScreen(bytes, Guid.NewGuid() + ".png");
            //all you need to do is to add full path to TestContext:
            TestContext.AddTestAttachment(fullPath1);
            TestContext.AddTestAttachment(fullPath2);
            TestContext.AddTestAttachment(fullPath3);
            Console.WriteLine("Done.");
        }
    }
}