using OpenQA.Selenium;
using System;
using System.Text;
using MarsOnBoardingTask.Utils;

namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }
    }
}

