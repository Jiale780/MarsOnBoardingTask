using MarsOnBoardingTask.Pages;
using MarsOnBoardingTask.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsOnBoardingTask.SpecFlow.StepDefinition
{
    [Binding]
    public class ProfileSkillsSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Language Page object initialization and definition
        ProfileSkills profileSkillsObj = new ProfileSkills();

        [Given(@"I login to the Trade Skills portal in Profile successfully")]
        public void GivenILoginToTheTradeSkillsPortalInProfileSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"I navigate to the skiils page under Skills tab")]
        public void GivenINavigateToTheSkiilsPageUnderSkillsTab()
        {
            NaviHomePageObj.SkillsPage(testDriver);
        }

        [Given(@"I click on the Add New button under Skills tab")]
        public void GivenIClickOnTheAddNewButtonUnderSkillsTab()
        {
            profileSkillsObj.AddNewSkillsBtn(testDriver);
        }

        [When(@"I click on Add button without records")]
        public void WhenIClickOnAddButtonWithoutRecords()
        {
            profileSkillsObj.AddInvalidSkills1(testDriver);
        }

        [When(@"The popup message '(.*)' will shown")]
        public void WhenThePopupMessageWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "Please enter skill and experience level");
        }

        [When(@"I enter the data in '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInAndClickOnAddButton(string Skill)
        {
            profileSkillsObj.AddInvalidSkills2(testDriver, Skill);
        }

        [Then(@"The invalid popup message '(.*)' will appear")]
        public void ThenTheInvalidPopupMessageWillAppear(string Message)
        {
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "Please enter skill and experience level");
        }

        [Given(@"I click on the Add New button under Skills section")]
        public void GivenIClickOnTheAddNewButtonUnderSkillsSection()
        {
            profileSkillsObj.AddNewSkillsBtn(testDriver);
        }

        [When(@"I enter the records of '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsOfAndClickOnAddButton(string Skill, string Level)
        {
            profileSkillsObj.AddSkills(testDriver, Skill, Level);
        }

        [When(@"The display popup message '(.*)' will appear")]
        public void WhenTheDisplayPopupMessageWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "Selenium has been added to your skills");
        }

        [Then(@"The new row should be added as in '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeAddedAsInSuccessfully(string Skill, string Level)
        {
            // Assertion that Skill and Level record has been added.
            Assert.AreEqual(profileSkillsObj.GetSkill(testDriver), Skill, "Selenium has been added to your skills");
            Assert.AreEqual(profileSkillsObj.GetLevel(testDriver), Level, "Selenium has been added to your skills");
        }

        [Given(@"I click on Add New button under Skills tab")]
        public void GivenIClickOnAddNewButtonUnderSkillsTab()
        {
            profileSkillsObj.AddNewSkillsBtn(testDriver);
        }

        [When(@"I enter the records '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsAndClickOnAddButton(string Skill, string SecondLevel)
        {
            profileSkillsObj.AddSkills2(testDriver, Skill, SecondLevel);
        }

        [Then(@"Invalid error popup message '(.*)' will appear")]
        public void ThenInvalidErrorPopupMessageWillAppear(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "Duplicated data");
        }

        [Given(@"I click on edit pen icon under Skills tab")]
        public void GivenIClickOnEditPenIconUnderSkillsTab()
        {
            profileSkillsObj.EditNewLanguageBtn(testDriver);
        }

        [When(@"I edit the data in '(.*)', '(.*)' and click on Add button")]
        public void WhenIEditTheDataInAndClickOnAddButton(string Skill, string Level)
        {
            profileSkillsObj.EditLSkills(testDriver, Skill, Level);
        }

        [When(@"The display popup message '(.*)' will shown")]
        public void WhenTheDisplayPopupMessageWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "SpecFlow has been updated to your skills");
        }

        [Then(@"The new row should be edited as in '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeEditedAsInSuccessfully(string Skill, string Level)
        {
            // Assertion that Skill and Level record has been updated.
            Assert.AreEqual(profileSkillsObj.GetSkill(testDriver), Skill, "SpecFlow has been updated to your skills");
            Assert.AreEqual(profileSkillsObj.GetLevel(testDriver), Level, "SpecFlow has been updated to your skills");
        }

        [Given(@"I click on delete icon under Skills tab")]
        public void GivenIClickOnDeleteIconUnderSkillsTab()
        {
            profileSkillsObj.DeleteNewLanguageBtn(testDriver);
        }

        [When(@"The prompt message of '(.*)' will shown")]
        public void WhenThePromptMessageOfWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "SpecFlow has been deleted");
        }

        [Then(@"the Skill should have the deleted successfully")]
        public void ThenTheSkillShouldHaveTheDeletedSuccessfully()
        {
            string editedSkill = profileSkillsObj.GetSkill2(testDriver);
            string editedLevel = profileSkillsObj.GetLevel2(testDriver);

            // Assertion that Skill and Level record has been deleted.
            Assert.AreNotEqual(editedSkill == "SpecFlow", "Actual Skills and expected skills don't match");
            Assert.AreNotEqual(editedLevel == "NativeExpertBilingual", "Actual Level and expected level don't match");
        }
    }
}
