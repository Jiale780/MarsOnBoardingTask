using MarsOnBoardingTask.Pages;
using MarsOnBoardingTask.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsOnBoardingTask.SpecFlow.Feature
{
    [Binding]
    public class ProfileCertificationsSteps : Hooks
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Language Page object initialization and definition
        ProfileCertifications profileCertsObj = new ProfileCertifications();

        [Given(@"I login to the Trade Skills portal for Certs successfully")]
        public void GivenILoginToTheTradeSkillsPortalForCertsSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"I navigate to the skiils page under Certifications tab")]
        public void GivenINavigateToTheSkiilsPageUnderCertificationsTab()
        {
            NaviHomePageObj.CertificationsPage(testDriver);
        }

        [Given(@"I click on Add New button under Certifications tab")]
        public void GivenIClickOnAddNewButtonUnderCertificationsTab()
        {
            profileCertsObj.AddNewCertBtn(testDriver);
        }

        [When(@"I enter the records in '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsInAndClickOnAddButton(string Certificate, string From)
        {
            profileCertsObj.AddInvalidCert1(testDriver, Certificate, From);
        }

        [Then(@"The error popup message '(.*)' will shown")]
        public void ThenTheErrorPopupMessageWillShown(string Message)
        {
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "Please enter Certification Name, Certification From and Certification Year");
        }

        [Given(@"I click on the Add New button under Certifications tab")]
        public void GivenIClickOnTheAddNewButtonUnderCertificationsTab()
        {
            profileCertsObj.AddNewCertBtn(testDriver);
        }

        [When(@"I enter the details in '(.*)', '(.*)', '(.*)' and click on add button")]
        public void WhenIEnterTheDetailsInAndClickOnAddButton(string Certificate, string From, string Year)
        {
            profileCertsObj.AddCertification(testDriver, Certificate, From, Year);
        }

        [Then(@"The display popup message '(.*)' will appear")]
        public void ThenTheDisplayPopupMessageWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CT-MT has been added to your certification");
        }

        [Then(@"A new row should be added as in '(.*)', '(.*)', '(.*)' successfully")]
        public void ThenANewRowShouldBeAddedAsInSuccessfully(string Certificate, string From, string Year)
        {
            // Assertion that Certificate, From and Year record has been added.
            Assert.AreEqual(profileCertsObj.GetCertification(testDriver), Certificate, "CT-MT has been added to your certification");
            Assert.AreEqual(profileCertsObj.GetFrom(testDriver), From, "ISTQB has been added to your certification");
            Assert.AreEqual(profileCertsObj.GetYear(testDriver), Year, "2019 has been added to your certification");
        }

        [Given(@"I click on the Add New button under Certifications section")]
        public void GivenIClickOnTheAddNewButtonUnderCertificationsSection()
        {
            profileCertsObj.AddNewCertBtn(testDriver);
        }

        [When(@"I enter the record in '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordInAndClickOnAddButton(string Certificate, string From, string SecondYear)
        {
            profileCertsObj.AddCertification2(testDriver, Certificate, From, SecondYear);
        }

        [When(@"The error popup message of '(.*)' will be shown")]
        public void WhenTheErrorPopupMessageOfWillBeShown(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "This information is already exist.");
        }

        [When(@"I enter the record '(.*)', '(.*)', '(.*)' and click on add button")]
        public void WhenIEnterTheRecordAndClickOnAddButton(string Certificate, string From, string SecondYear)
        {
            profileCertsObj.AddCertification2(testDriver, Certificate, From, SecondYear);
        }

        [Then(@"The display error popup message '(.*)' will shown")]
        public void ThenTheDisplayErrorPopupMessageWillShown(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "Duplicated data");
        }

        [Given(@"I click on the Certification pen icon")]
        public void GivenIClickOnTheCertificationPenIcon()
        {
            profileCertsObj.EditNewCertBtn(testDriver);
        }

        [When(@"edit the data in '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenEditTheDataInAndClickOnAddButton(string Certificate, string From, string SecondYear)
        {
            profileCertsObj.EditCertification(testDriver, Certificate, From, SecondYear);
        }

        [When(@"The display prompt message '(.*)' will appear")]
        public void WhenTheDisplayPromptMessageWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CTFL-AuT has been updated to your certification");
        }

        [Then(@"The new row should be updated as '(.*)', '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeUpdatedAsSuccessfully(string Certificate, string From, string Year)
        {
            // Assertion that Certificate, From and Year record has been edited.
            Assert.AreEqual(profileCertsObj.GetCertification(testDriver), Certificate, "CT-MT has been updated to your certification");
            Assert.AreEqual(profileCertsObj.GetFrom(testDriver), From, "ISTQB has been updated to your certification");
            Assert.AreEqual(profileCertsObj.GetYear(testDriver), Year, "2019 has been updated to your certification");
        }

        [Given(@"I click on delete icon under Certification tab")]
        public void GivenIClickOnDeleteIconUnderCertificationTab()
        {
            profileCertsObj.DeleteNewCertBtn(testDriver);
        }

        [When(@"The prompt message of the '(.*)' will appear")]
        public void WhenThePromptMessageOfTheWillAppear(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CTFL-AuT has been deleted from your certification");
        }

        [Then(@"the Certification should have the deleted successfully")]
        public void ThenTheCertificationShouldHaveTheDeletedSuccessfully()
        {
            string editedCertification = profileCertsObj.GetCertification2(testDriver);
            string editedFrom = profileCertsObj.GetFrom2(testDriver);
            string editedYear = profileCertsObj.GetYear2(testDriver);

            // Assertion that Language and Level record has been deleted.
            Assert.AreNotEqual(editedCertification == "CTFL-AuT", "Actual Certification and expected certification don't match");
            Assert.AreNotEqual(editedFrom == "ISTQB-V2", "Actual From and expected from don't match");
            Assert.AreNotEqual(editedYear == "2020", "Actual Year and expected year don't match");
        }
    }
}
