using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace MarsOnBoardingTask.Pages
{
    class HomePage
    {
        private IWebDriver testDriver;

        public void NaviHomePage(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);

            // Select the Seller from "Seller" dropdown list
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/div[1]/div[2]/div/span", 2);
            IWebElement MouseHover = testDriver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/span"));
            Hover.MoveToElement(MouseHover).Perform();

            // Select the "Go to Profile" from "Seller" dropdown list
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='service-search-section']/div[1]/div[2]/div/span/div/a[1]", 2);
            IWebElement GoToProfile = testDriver.FindElement(By.XPath("//*[@id='service-search-section']/div[1]/div[2]/div/span/div/a[1]"));
            GoToProfile.Click();
        }

        public void SkillsPage(IWebDriver testDriver)
        {
            // Navigate to the Skills Tab
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);
            IWebElement skillsTab = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
        }

        public void EducationPage(IWebDriver testDriver)
        {
            // Navigate to the Education Tab
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 2);
            IWebElement educationTab = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
        }

        public void CertificationsPage(IWebDriver testDriver)
        {
            // Navigate to the Certifications Tab
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 2);
            IWebElement certificationsTab = testDriver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTab.Click();
        }
    }
}
