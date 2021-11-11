using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsOnBoardingTask.Pages
{
    class ProfileDetails
    {
        public void AddNameIcon(IWebDriver testDriver)
        {
            // Identify Profile icon and click
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]", 2);
            IWebElement nameIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            nameIcon.Click();

            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 2);
            IWebElement selectNameIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            selectNameIcon.Click();
        }

        public void ClearNameFields(IWebDriver testDriver)
        {
            // Identify the first name textbox enter valid first name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "firstName", 2);
            IWebElement firstNameTextBox = testDriver.FindElement(By.Name("firstName"));
            firstNameTextBox.Clear();

            // Identify last name textbox enter valid last name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "lastName", 2);
            IWebElement lastNameTextBox = testDriver.FindElement(By.Name("lastName"));
            lastNameTextBox.Clear();
        }

        public void AddSaveBtn(IWebDriver testDriver)
        {
            // Click on "Save" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 3);
            IWebElement saveButton = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            saveButton.Click();
        }

        public void EditProfileName(IWebDriver testDriver, string FirstName, string LastName)
        {
            // Identify the first name textbox enter valid first name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "firstName", 2);
            IWebElement firstNameTextBox = testDriver.FindElement(By.Name("firstName"));
            firstNameTextBox.Clear();
            firstNameTextBox.SendKeys(FirstName);

            // Identify last name textbox enter valid last name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "lastName", 2);
            IWebElement lastNameTextBox = testDriver.FindElement(By.Name("lastName"));
            lastNameTextBox.Clear();
            lastNameTextBox.SendKeys(LastName);

            // Click on "Save" button
            IWebElement saveButton = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            saveButton.Click();
        }

        public string GetFirstName(IWebDriver testDriver)
        {
            IWebElement newFirstName = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            return newFirstName.Text;
        }

        public string GetLastName(IWebDriver testDriver)
        {
            IWebElement newLastName = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            return newLastName.Text;
        }

        public void AvailabilityPenIcon(IWebDriver testDriver)
        {
            // Identify Availability icon and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 2);
            IWebElement availabilityIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            availabilityIcon.Click();
        }

        public void AddAvailability(IWebDriver testDriver, string Availability)
        {
            // Select Availability from "Availability" dropdown list
            WaitHelpers.WaitForElementToBeClickable(testDriver, "Name", "availabiltyType", 2);
            IWebElement availabileDropdown = testDriver.FindElement(By.Name("availabiltyType"));
            availabileDropdown.Click();

            if(Availability == "Full Time")
            {
                WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]", 2);
                IWebElement fullTime = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
                fullTime.Click();
            }
            else
            {
                WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[1]", 2);
                IWebElement selectAvailability = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[1]"));
                selectAvailability.Click();
            }

            // Select the remove icon
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 2);
            IWebElement selectRemoveIcon = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            selectRemoveIcon.Click();
        }

        public string GetAvailability(IWebDriver testDriver)
        {
            IWebElement newAvailability1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            return newAvailability1.Text;
        }

        public void HoursPenIcon(IWebDriver testDriver)
        {
            // Identify Hours icon and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 2);
            IWebElement hoursIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            hoursIcon.Click();
        }

        public void AddHours(IWebDriver testDriver, string Hours)
        {
            // Select Hours from "Hours" dropdown list
            WaitHelpers.WaitForElementToBeClickable(testDriver, "Name", "availabiltyHour", 2);
            IWebElement hoursDropdown = testDriver.FindElement(By.Name("availabiltyHour"));
            hoursDropdown.Click();

            if (Hours == "As needed")
            {
                WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]", 2);
                IWebElement asNeeded = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));
                asNeeded.Click();
            }
            else
            {
                WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[1]", 2);
                IWebElement selectHrs = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[1]"));
                selectHrs.Click();
            }

            // Select the remove icon
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 2);
            IWebElement selectRemoveIcon = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            selectRemoveIcon.Click();
        }

        public string GetHours(IWebDriver testDriver)
        {
            IWebElement newHours1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));
            return newHours1.Text;
        }

        public void EarnTargetPenIcon(IWebDriver testDriver)
        {
            // Identify EarnTarget icon and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 2);
            IWebElement earnTargetIcon = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            earnTargetIcon.Click();
        }

        public void AddEarnTarget(IWebDriver testDriver, string EarnTarget)
        {
            // Select EarnTarget from "Earn Target" dropdown list
            WaitHelpers.WaitForElementToBeClickable(testDriver, "Name", "availabiltyTarget", 2);
            IWebElement earnTargetDropdown = testDriver.FindElement(By.Name("availabiltyTarget"));
            earnTargetDropdown.Click();

            if (EarnTarget == "More than $1000 per month")
            {
                WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]", 2);
                IWebElement moreThan1000permth = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
                moreThan1000permth.Click();
            }
            else
            {
                WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[1]", 2);
                IWebElement selectHrs = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[1]"));
                selectHrs.Click();
            }

            // Select the remove icon
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 2);
            IWebElement selectRemoveIcon = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            selectRemoveIcon.Click();
        }

        public string GetEarnTarget(IWebDriver testDriver)
        {
            IWebElement newEarnTarget1 = testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
            return newEarnTarget1.Text;
        }
    }
}
