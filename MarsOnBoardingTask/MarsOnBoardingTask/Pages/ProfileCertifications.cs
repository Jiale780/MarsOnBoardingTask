using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsOnBoardingTask.Pages
{
    class ProfileCertifications
    {
        private IWebDriver testDriver;

        public void AddNewCertBtn(IWebDriver testDriver)
        {
            // Click on the "Add new" button of certification
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 4);
            IWebElement certBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidCert1(IWebDriver testDriver, string Certificate, string From)
        {
            this.testDriver = testDriver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationName", 2);
            IWebElement certTextBox = testDriver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            //certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = testDriver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            //certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddCertification(IWebDriver testDriver, string Certificate, string From, string Year)
        {
            this.testDriver = testDriver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationName", 2);
            IWebElement certTextBox = testDriver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            //certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = testDriver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            //certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationYear", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("certificationYear")));
            levelDDList.SelectByValue(Year);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddCertification2(IWebDriver testDriver, string Certificate, string From, string SecondYear)
        {
            this.testDriver = testDriver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationName", 2);
            IWebElement certTextBox = testDriver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = testDriver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationYear", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("certificationYear")));
            levelDDList.SelectByValue(SecondYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetCertification(IWebDriver testDriver)
        {
            IWebElement certification1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return certification1.Text;
        }

        public string GetFrom(IWebDriver testDriver)
        {
            IWebElement from1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return from1.Text;
        }

        public string GetYear(IWebDriver testDriver)
        {
            IWebElement year1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return year1.Text;
        }

        public void EditNewCertBtn(IWebDriver testDriver)
        {
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i", 4);
            IWebElement certPenIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            certPenIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditCertification(IWebDriver testDriver, string Certificate, string From, string Year)
        {
            this.testDriver = testDriver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationName", 2);
            IWebElement certTextBox = testDriver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = testDriver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationYear", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("certificationYear")));
            levelDDList.SelectByValue(Year);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            IWebElement updateBtn = testDriver.FindElement(By.XPath("//input[@value='Update']"));
            updateBtn.Click();
        }

        public void DeleteNewCertBtn(IWebDriver testDriver)
        {
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i", 4);
            IWebElement deleteBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            deleteBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetCertification2(IWebDriver testDriver)
        {
            IWebElement certification2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[1]"));
            return certification2.Text;
        }

        public string GetFrom2(IWebDriver testDriver)
        {
            IWebElement from2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[2]"));
            return from2.Text;
        }

        public string GetYear2(IWebDriver testDriver)
        {
            IWebElement year2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[3]"));
            return year2.Text;
        }

    }
}
