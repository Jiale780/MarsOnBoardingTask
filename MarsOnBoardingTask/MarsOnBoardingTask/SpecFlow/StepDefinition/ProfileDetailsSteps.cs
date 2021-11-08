using MarsOnBoardingTask.Pages;
using MarsOnBoardingTask.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsOnBoardingTask.SpecFlow.StepDefinitions
{
    [Binding]
    public class ProfileDetailsSteps : Hooks
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Profile Details Page object initialization and definition
        ProfileDetails profileDetailsObj = new ProfileDetails();

        [Given(@"I login to the Trade Skills portal successfully")]
        public void GivenILoginToTheTradeSkillsPortalSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"I click on the name expand icon")]
        public void GivenIClickOnTheNameExpandIcon()
        {
            profileDetailsObj.AddNameIcon(testDriver);
        }

        [When(@"I clear on FirstName and LastName fields in the textbox")]
        public void WhenIClearOnFirstNameAndLastNameFieldsInTheTextbox()
        {
            profileDetailsObj.ClearNameFields(testDriver);
        }

        [Then(@"Click on Save button and the auto popup message will appear")]
        public void ThenClickOnSaveButtonAndTheAutoPopupMessageWillAppear()
        {
            profileDetailsObj.AddSaveBtn(testDriver);
        }

        [When(@"I update the '(.*)', '(.*)' and click on Save button")]
        public void WhenIUpdateTheAndClickOnSaveButton(string FirstName, string LastName)
        {
            profileDetailsObj.EditProfileName(testDriver, FirstName, LastName);
        }

        [Then(@"the Fullname should be updated as '(.*)', '(.*)' successfully")]
        public void ThenTheFullnameShouldBeUpdatedAsSuccessfully(string FirstName, string LastName)
        {
            // Assertion that Fullname record has been edited.
            Assert.AreNotEqual(profileDetailsObj.GetFirstName(testDriver), FirstName, "Actual FirstName and expected FirstName don't match");
            Assert.AreNotEqual(profileDetailsObj.GetLastName(testDriver), LastName, "Actual LastName and expected LastName don't match");
        }

        [Given(@"I click on the Availability pen icon")]
        public void GivenIClickOnTheAvailabilityPenIcon()
        {
            profileDetailsObj.AvailabilityPenIcon(testDriver);
        }

        [When(@"I select Availability of '(.*)' from the dropdown list")]
        public void WhenISelectAvailabilityOfFromTheDropdownList(string Availability)
        {
            profileDetailsObj.AddAvailability(testDriver, Availability);
        }

        [Then(@"the availability should be updated as '(.*)' successfully")]
        public void ThenTheAvailabilityShouldBeUpdatedAsSuccessfully(string Availability)
        {
            // Assertion that Availability record has been edited.
            Assert.AreEqual(profileDetailsObj.GetAvailability(testDriver), Availability, "Actual Availability and expected Availability don't match");
        }

        [Given(@"I click on the Hours pen icon")]
        public void GivenIClickOnTheHoursPenIcon()
        {
            profileDetailsObj.HoursPenIcon(testDriver);
        }

        [When(@"I select Hours of '(.*)' from the dropdown list")]
        public void WhenISelectHoursOfFromTheDropdownList(string Hours)
        {
            profileDetailsObj.AddHours(testDriver, Hours);
        }

        [Then(@"the Hours should be updated as '(.*)' successfully")]
        public void ThenTheHoursShouldBeUpdatedAsSuccessfully(string Hours)
        {
            // Assertion that Hours record has been edited.
            Assert.AreEqual(profileDetailsObj.GetHours(testDriver), Hours, "Actual Hours and expected Hours don't match");
        }

        [Given(@"I click on the Earn Target pen icon")]
        public void GivenIClickOnTheEarnTargetPenIcon()
        {
            profileDetailsObj.EarnTargetPenIcon(testDriver);
        }

        [When(@"I select EarnTarget of '(.*)' from the dropdown list")]
        public void WhenISelectEarnTargetOfFromTheDropdownList(string EarnTarget)
        {
            profileDetailsObj.AddEarnTarget(testDriver, EarnTarget);
        }

        [Then(@"the EarnTarget should be updated as '(.*)' successfully")]
        public void ThenTheEarnTargetShouldBeUpdatedAsSuccessfully(string EarnTarget)
        {
            // Assertion that EarnTarget record has been edited.
            Assert.AreEqual(profileDetailsObj.GetEarnTarget(testDriver), EarnTarget, "Actual EarnTarget and expected EarnTarget don't match");
        }
    }
}
