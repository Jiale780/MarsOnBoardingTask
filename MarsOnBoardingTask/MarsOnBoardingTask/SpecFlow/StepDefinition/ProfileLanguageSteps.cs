using MarsOnBoardingTask.Pages;
using MarsOnBoardingTask.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsOnBoardingTask.SpecFlow.StepDefinitions
{
    [Binding]
    public class ProfileLanguageSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Profile Language Page object initialization and definition
        ProfileLangauge profileLanguageObj = new ProfileLangauge();

        [Given(@"I login to the Trade Skills portal in the Profile successfully")]
        public void GivenILoginToTheTradeSkillsPortalInTheProfileSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"I click on the Add New button under Languages tab")]
        public void GivenIClickOnTheAddNewButtonUnderLanguagesTab()
        {
            profileLanguageObj.AddNewLanguageBtn(testDriver);
        }

        [When(@"I click on the Add button without records")]
        public void WhenIClickOnTheAddButtonWithoutRecords()
        {
            profileLanguageObj.AddInvalidLanguage1(testDriver);
        }

        [When(@"The display error popup message of '(.*)' will appear")]
        public void WhenTheDisplayErrorPopupMessageOfWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "Please enter language and level");
        }

        [When(@"I enter the data in level of '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInLevelOfAndClickOnAddButton(string Level)
        {
            profileLanguageObj.AddInvalidLanguage2(testDriver, Level);
        }

        [When(@"The display error popup message '(.*)' will appear")]
        public void WhenTheDisplayErrorPopupMessageWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "Please enter language and level");
        }

        [When(@"I enter the data in language of '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInLanguageOfAndClickOnAddButton(string Language)
        {
            profileLanguageObj.AddInvalidLanguage3(testDriver, Language);
        }

        [Then(@"The display error popup message '(.*)' will appear")]
        public void ThenTheDisplayErrorPopupMessageWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "Please enter language and level");
        }

        [When(@"I enter the data in language and level '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInLanguageAndLevelAndClickOnAddButton(string Language, string Level)
        {
            profileLanguageObj.AddLanguage(testDriver, Language, Level);
        }

        [When(@"The popup message of '(.*)' will appear")]
        public void WhenThePopupMessageOfWillAppear(string message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), message, "Japanese has been added to your languages");
        }

        [Then(@"The new row should be added as '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeAddedAsSuccessfully(string Language, string Level)
        {
            // Assertion that Language and Level record has been added.
            Assert.AreEqual(profileLanguageObj.GetLanguage(testDriver), Language, "Japanese has been added to your languages");
            Assert.AreEqual(profileLanguageObj.GetLevel(testDriver), Level, "Japanese has been added to your languages");
        }

        [Given(@"I click on Add New button under Languages section")]
        public void GivenIClickOnAddNewButtonUnderLanguagesSection()
        {
            profileLanguageObj.AddNewLanguageBtn(testDriver);
        }

        [When(@"I enter the records in language,level '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsInLanguageLevelAndClickOnAddButton(string Language, string SecondLevel)
        {
            profileLanguageObj.AddLanguage2(testDriver, Language, SecondLevel);
        }

        [When(@"The error popup message of '(.*)' will shown")]
        public void WhenTheErrorPopupMessageOfWillShown(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "This language is already exist in your language list.");
        }

        [When(@"I enter the data in languageandlevel '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInLanguageandlevelAndClickOnAddButton(string Language, string SecondLevel)
        {
            profileLanguageObj.AddLanguage2(testDriver, Language, SecondLevel);
        }

        [Then(@"The display error popup message of'(.*)' will appear")]
        public void ThenTheDisplayErrorPopupMessageOfWillAppear(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "Duplicated data");
        }

        [Given(@"I click on Edit of pen icon under Languages tab")]
        public void GivenIClickOnEditOfPenIconUnderLanguagesTab()
        {
            profileLanguageObj.EditNewLanguageBtn(testDriver);
        }

        [When(@"edit the data in language and level '(.*)', '(.*)' and click on Add button")]
        public void WhenEditTheDataInLanguageAndLevelAndClickOnAddButton(string Language, string Level)
        {
            profileLanguageObj.EditLanguage(testDriver, Language, Level);
        }

        [When(@"The popup message of '(.*)' will shown")]
        public void WhenThePopupMessageOfWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "English has been updated to your languages");
        }

        [Then(@"The new row should be edited as '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeEditedAsSuccessfully(string Language, string Level)
        {
            // Assertion that Language and Level record has been updated.
            Assert.AreEqual(profileLanguageObj.GetLanguage(testDriver), Language, "English has been updated to your languages");
            Assert.AreEqual(profileLanguageObj.GetLevel(testDriver), Level, "English has been updated to your languages");
        }

        [Given(@"I click on delete icon under Languages tab")]
        public void GivenIClickOnDeleteIconUnderLanguagesTab()
        {
            profileLanguageObj.DeleteNewLanguageBtn(testDriver);
        }

        [When(@"The prompt message of the '(.*)' will shown")]
        public void WhenThePromptMessageOfTheWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "English has been added from your languages");
        }

        [Then(@"the Language should have the deleted successfully")]
        public void ThenTheLanguageShouldHaveTheDeletedSuccessfully()
        {
            string editedLanguage = profileLanguageObj.GetLanguage2(testDriver);
            string editedLevel = profileLanguageObj.GetLevel2(testDriver);

            // Assertion that Language and Level record has been deleted.
            Assert.AreNotEqual(editedLanguage == "English", "Actual Language and expected language don't match");
            Assert.AreNotEqual(editedLevel == "Native/Bilingual", "Actual Level and expected level don't match");
        }
    }
}
