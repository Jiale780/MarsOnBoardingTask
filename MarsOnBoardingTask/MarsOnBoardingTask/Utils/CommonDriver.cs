using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using MarsOnBoardingTask.Pages;
using System.Text;
using TechTalk.SpecFlow;
using System;

namespace MarsOnBoardingTask.Utils
{
    public class CommonDriver
    {
        public static IWebDriver testDriver;

        public static void Initialize()
        {
            // open chrome browser
            //testDriver = new ChromeDriver();

            // login page object initialization and definition
            //LoginPage loginPageObj = new LoginPage();
            //loginPageObj.LoginAction(driver);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            testDriver.Quit();
        }
    }
}
