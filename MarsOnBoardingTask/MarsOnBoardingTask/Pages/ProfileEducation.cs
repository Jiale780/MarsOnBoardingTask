using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsOnBoardingTask.Pages
{
    class ProfileEducation
    {
        private IWebDriver testDriver;

        public void AddNewEducationBtn(IWebDriver testDriver)
        {
            // Click on the "Add new" button of certification
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 4);
            IWebElement certBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            certBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidEducation1(IWebDriver testDriver, string UniversityName, string CountryUniversity, string GraduationYear)
        {
            this.testDriver = testDriver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = testDriver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            //UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(testDriver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(GraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddEducation(IWebDriver testDriver, string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            this.testDriver = testDriver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = testDriver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            //UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
            SelectElement levelDDList1 = new SelectElement(testDriver.FindElement(By.Name("title")));
            levelDDList1.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "degree", 2);
            IWebElement degreeTextBox = testDriver.FindElement(By.Name("degree"));
            degreeTextBox.Click();
            //degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(testDriver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(GraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddEducation2(IWebDriver testDriver, string UniversityName, string CountryUniversity, string Title, string Degree, string SecondGraduationYear)
        {
            this.testDriver = testDriver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = testDriver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
            SelectElement levelDDList1 = new SelectElement(testDriver.FindElement(By.Name("title")));
            levelDDList1.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "degree", 2);
            IWebElement degreeTextBox = testDriver.FindElement(By.Name("degree"));
            degreeTextBox.Click();
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(testDriver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(SecondGraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = testDriver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetCountryUni(IWebDriver testDriver)
        {
            IWebElement countryUni1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return countryUni1.Text;
        }

        public string GetUniversityName(IWebDriver testDriver)
        {
            IWebElement universityName1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return universityName1.Text;
        }

        public string GetTitle(IWebDriver testDriver)
        {
            IWebElement title1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return title1.Text;
        }

        public string GetDegree(IWebDriver testDriver)
        {
            IWebElement degree1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return degree1.Text;
        }

        public string GetGraduationYear(IWebDriver testDriver)
        {
            IWebElement graduationYear1 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return graduationYear1.Text;
        }

        public void EditEducationBtn(IWebDriver testDriver)
        {
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i", 4);
            IWebElement certPenIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            certPenIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditEducation(IWebDriver testDriver, string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            this.testDriver = testDriver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = testDriver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(testDriver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
            SelectElement levelDDList1 = new SelectElement(testDriver.FindElement(By.Name("title")));
            levelDDList1.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "degree", 2);
            IWebElement degreeTextBox = testDriver.FindElement(By.Name("degree"));
            degreeTextBox.Click();
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(testDriver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(GraduationYear);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            IWebElement updateBtn = testDriver.FindElement(By.XPath("//input[@value='Update']"));
            updateBtn.Click();
        }

        public void DeleteEducationBtn(IWebDriver testDriver)
        {
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i", 4);
            IWebElement deleteBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deleteBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetCountryUni2(IWebDriver testDriver)
        {
            IWebElement countryUni2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[1]"));
            return countryUni2.Text;
        }

        public string GetUniversityName2(IWebDriver testDriver)
        {
            IWebElement universityName2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[2]"));
            return universityName2.Text;
        }

        public string GetTitle2(IWebDriver testDriver)
        {
            IWebElement title2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[3]"));
            return title2.Text;
        }

        public string GetDegree2(IWebDriver testDriver)
        {
            IWebElement degree2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[4]"));
            return degree2.Text;
        }

        public string GetGraduationYear2(IWebDriver testDriver)
        {
            IWebElement graduationYear2 = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[5]"));
            return graduationYear2.Text;
        }

    }
}
