using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsOnBoardingTask.Pages
{
    class ProfileSkills
    {
        private IWebDriver testDriver;

        public void AddNewSkillsBtn(IWebDriver testDriver)
        {
            // Click on the "Add new" button of skills
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]", 4);
            IWebElement SkillsBtn = testDriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            SkillsBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidSkills1(IWebDriver testDriver)
        {
            this.testDriver = testDriver;

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddInvalidSkills2(IWebDriver testDriver, string Skill)
        {
            this.testDriver = testDriver;

            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement skillsTextBox = testDriver.FindElement(By.Name("name"));
            skillsTextBox.Click();
            skillsTextBox.Clear();
            skillsTextBox.SendKeys(Skill);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddSkills(IWebDriver testDriver, string Skill, string Level)
        {
            this.testDriver = testDriver;

            // Identify the skills textbox enter valid skills
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement skillsTextBox = testDriver.FindElement(By.Name("name"));
            skillsTextBox.Click();
            //skillsTextBox.Clear();
            skillsTextBox.SendKeys(Skill);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddSkills2(IWebDriver testDriver, string Skill, string SecondLevel)
        {
            this.testDriver = testDriver;

            // Identify the skills textbox enter valid skills
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement skillsTextBox = testDriver.FindElement(By.Name("name"));
            skillsTextBox.Click();
            skillsTextBox.Clear();
            skillsTextBox.SendKeys(Skill);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(SecondLevel);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetSkill(IWebDriver testDriver)
        {
            IWebElement skill1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return skill1.Text;
        }

        public string GetLevel(IWebDriver testDriver)
        {
            IWebElement level1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return level1.Text;
        }

        public void EditNewLanguageBtn(IWebDriver testDriver)
        {
            // Click on edit pen icon of the skills
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 4);
            IWebElement skillsPenIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            skillsPenIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditLSkills(IWebDriver testDriver, string Skill, string Level)
        {
            this.testDriver = testDriver;

            // Identify the skills textbox enter valid skills
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            IWebElement skillsTextBox = testDriver.FindElement(By.Name("name"));
            skillsTextBox.Click();
            skillsTextBox.Clear();
            skillsTextBox.SendKeys(Skill);

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
            // Click on the "Delete" button of skills
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 4);
            IWebElement skillsBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            skillsBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetSkill2(IWebDriver testDriver)
        {
            IWebElement skill1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
            return skill1.Text;
        }

        public string GetLevel2(IWebDriver testDriver)
        {
            IWebElement level2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[2]"));
            return level2.Text;
        }
    }
}
