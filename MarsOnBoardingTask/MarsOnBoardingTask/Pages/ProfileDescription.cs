using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace MarsOnBoardingTask.Pages
{
    class ProfileDescription
    {
        private IWebDriver testDriver;

        public void DescriptionPenIcon(IWebDriver testDriver)
        {
            // Identify Description icon and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 4);
            IWebElement descriptionIcon = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void AddDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);

            // Identify the description textarea enter valid description
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 2);
            IWebElement descriptionTextBox = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            Hover.Click(descriptionTextBox).Perform();
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys(Description);

            // Click on "Save" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 5);
            IWebElement saveButton = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }

        public string GetDescription1(IWebDriver testDriver)
        {
            IWebElement newDescription1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            return newDescription1.Text;
        }

        public void EditDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);

            // Identify the description textarea enter valid description
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 2);
            IWebElement descriptionTextBox = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            Hover.Click(descriptionTextBox).Perform();
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys(Description);

            // Click on "Save" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 5);
            IWebElement saveButton = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }
        public string GetDescription2(IWebDriver testDriver)
        {
            IWebElement newDescription1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return newDescription1.Text;
        }
    }
}
