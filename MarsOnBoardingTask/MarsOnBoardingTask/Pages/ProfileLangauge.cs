using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsOnBoardingTask.Pages
{
    class ProfileLangauge
    {
        private IWebDriver testDriver;

        public void AddNewLanguageBtn(IWebDriver testDriver)
        {
            // Click on the "Add new" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 4);
            IWebElement languageBtn = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidLanguage1(IWebDriver testDriver)
        {
            this.testDriver = testDriver;

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddInvalidLanguage2(IWebDriver testDriver, string Level)
        {
            this.testDriver = testDriver;

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddInvalidLanguage3(IWebDriver testDriver, string Language)
        {
            this.testDriver = testDriver;

            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement languageTextBox = testDriver.FindElement(By.Name("name"));
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddLanguage(IWebDriver testDriver, string Language, string Level)
        {
            this.testDriver = testDriver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement languageTextBox = testDriver.FindElement(By.Name("name"));
            languageTextBox.Click();
            //languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddLanguage2(IWebDriver testDriver, string Language, string SecondLevel)
        {
            this.testDriver = testDriver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement languageTextBox = testDriver.FindElement(By.Name("name"));
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(SecondLevel);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetLanguage(IWebDriver testDriver)
        {
            IWebElement language1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return language1.Text;
        }

        public string GetLevel(IWebDriver testDriver)
        {
            IWebElement level1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return level1.Text;
        }

        public void EditNewLanguageBtn(IWebDriver testDriver)
        {
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 4);
            IWebElement languagePenIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            languagePenIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditLanguage(IWebDriver testDriver, string Language, string Level)
        {
            this.testDriver = testDriver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement languageTextBox = testDriver.FindElement(By.Name("name"));
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            IWebElement updateBtn = testDriver.FindElement(By.XPath("//input[@value='Update']"));
            updateBtn.Click();
        }

        public void DeleteNewLanguageBtn(IWebDriver testDriver)
        {
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 4);
            IWebElement languageBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            languageBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetLanguage2(IWebDriver testDriver)
        {
            IWebElement language2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));
            return language2.Text;
        }

        public string GetLevel2(IWebDriver testDriver)
        {
            IWebElement level2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[2]"));
            return level2.Text;
        }
    }
}
