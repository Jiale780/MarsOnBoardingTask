using MarsOnBoardingTask.Utils;
using OpenQA.Selenium;

namespace MarsOnBoardingTask.Pages
{
    class ProfileViewPage
    {
        public void GoToMainPage(IWebDriver testDriver)
        {
            // Navigate to the Trade Skills portal
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/div[1]/a", 2);
            IWebElement NavigateBtn = testDriver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a"));
            NavigateBtn.Click();
        }

        public void NavigateToImgIcon(IWebDriver testDriver)
        {
            // Navigate to the Trade Skills portal
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='home']/div/section[1]/div/div[2]/div/div[2]/div[2]/a/h3", 2);
            IWebElement imgIconBtn = testDriver.FindElement(By.XPath("//*[@id='home']/div/section[1]/div/div[2]/div/div[2]/div[2]/a/h3"));
            imgIconBtn.Click();
        }

        public string ValidateUser(IWebDriver testDriver)
        {
            // Navigate to the Trade Skills portal
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[1]/div/div[1]/div[2]/div/span", 3);
            IWebElement actualUser = testDriver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span"));
            return actualUser.Text;
        }
    }
}
