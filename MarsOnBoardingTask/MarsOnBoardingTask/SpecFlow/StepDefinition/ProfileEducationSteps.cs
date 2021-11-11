using MarsOnBoardingTask.Pages;
using MarsOnBoardingTask.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsOnBoardingTask.SpecFlow.StepDefinition
{
    [Binding]
    public class ProfileEducationSteps : Hooks
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Language Page object initialization and definition
        ProfileEducation profileEducObj = new ProfileEducation();

        [Given(@"I login to the Trade Skills portal for education successfully")]
        public void GivenILoginToTheTradeSkillsPortalForEducationSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"I navigate to the skiils page under Education tab")]
        public void GivenINavigateToTheSkiilsPageUnderEducationTab()
        {
            NaviHomePageObj.EducationPage(testDriver);
        }

        [Given(@"I click on the Add New button under Education tab")]
        public void GivenIClickOnTheAddNewButtonUnderEducationTab()
        {
            profileEducObj.AddNewEducationBtn(testDriver);
        }

        [When(@"I enter the records for '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsForAndClickOnAddButton(string UniversityName, string CountryUniversity, string GraduationYear)
        {
            profileEducObj.AddInvalidEducation1(testDriver, UniversityName, CountryUniversity, GraduationYear);
        }

        [Then(@"The display error popup message '(.*)' come out")]
        public void ThenTheDisplayErrorPopupMessageComeOut(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Please enter all the fields");
        }

        [Given(@"I click on Add New button under Education tab")]
        public void GivenIClickOnAddNewButtonUnderEducationTab()
        {
            profileEducObj.AddNewEducationBtn(testDriver);
        }

        [When(@"I enter the records as '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsAsAndClickOnAddButton(string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            profileEducObj.AddEducation(testDriver, UniversityName, CountryUniversity, Title, Degree, GraduationYear);
        }

        [Then(@"The display popup message '(.*)' will come out")]
        public void ThenTheDisplayPopupMessageWillComeOut(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Education has been added");
        }

        [Then(@"The new row should be added for '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeAddedForSuccessfully(string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            // Assertion that UniversityName, University, Title, Degree and GraduationYear record has been added.
            Assert.AreEqual(profileEducObj.GetUniversityName(testDriver), UniversityName, "NUS has been added");
            Assert.AreEqual(profileEducObj.GetCountryUni(testDriver), CountryUniversity, "Singapore has been added");
            Assert.AreEqual(profileEducObj.GetTitle(testDriver), Title, "B.Sc has been added");
            Assert.AreEqual(profileEducObj.GetDegree(testDriver), Degree, "Software-Testing has been added");
            Assert.AreEqual(profileEducObj.GetGraduationYear(testDriver), GraduationYear, "2020 has been added");
        }

        [Given(@"I click on Add New button under Education section")]
        public void GivenIClickOnAddNewButtonUnderEducationSection()
        {
            profileEducObj.AddNewEducationBtn(testDriver);
        }

        [When(@"I enter the details of '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheDetailsOfAndClickOnAddButton(string UniversityName, string CountryUniversity, string Title, string Degree, string SecondGraduationYear)
        {
            profileEducObj.AddEducation2(testDriver, UniversityName, CountryUniversity, Title, Degree, SecondGraduationYear);
        }

        [When(@"The display error popup message '(.*)' will be come out")]
        public void WhenTheDisplayErrorPopupMessageWillBeComeOut(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "This information is already exist.");
        }

        [When(@"I enter the data in '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'and click on Add button")]
        public void WhenIEnterTheDataInAndClickOnAddButton(string UniversityName, string CountryUniversity, string Title, string Degree, string SecondGraduationYear)
        {
            profileEducObj.AddEducation2(testDriver, UniversityName, CountryUniversity, Title, Degree, SecondGraduationYear);
        }

        [Then(@"The display error popup message '(.*)' will come out")]
        public void ThenTheDisplayErrorPopupMessageWillComeOut(string Message)
        {
            // Assertion that error popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Duplicated data");
        }

        [Given(@"I click on the Education pen icon")]
        public void GivenIClickOnTheEducationPenIcon()
        {
            profileEducObj.EditEducationBtn(testDriver);
        }

        [When(@"I edit the records in '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEditTheRecordsInAndClickOnAddButton(string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            profileEducObj.EditEducation(testDriver, UniversityName, CountryUniversity, Title, Degree, GraduationYear);
        }

        [When(@"The display prompt message '(.*)' will shown")]
        public void WhenTheDisplayPromptMessageWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Education as been updated");
        }

        [Then(@"The new row should be updated in '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' successfully")]
        public void ThenTheNewRowShouldBeUpdatedInSuccessfully(string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            // Assertion that UniversityName, University, Title, Degree and GraduationYear record has been updated.
            Assert.AreEqual(profileEducObj.GetUniversityName(testDriver), UniversityName, "SMU as been updated");
            Assert.AreEqual(profileEducObj.GetCountryUni(testDriver), CountryUniversity, "Singapore as been updated");
            Assert.AreEqual(profileEducObj.GetTitle(testDriver), Title, "B.Tech as been updated");
            Assert.AreEqual(profileEducObj.GetDegree(testDriver), Degree, "Software Testing as been updated");
            Assert.AreEqual(profileEducObj.GetGraduationYear(testDriver), GraduationYear, "2021 as been updated");
        }

        [Given(@"I click on delete icon under Education tab")]
        public void GivenIClickOnDeleteIconUnderEducationTab()
        {
            profileEducObj.DeleteEducationBtn(testDriver);
        }

        [When(@"The prompt message of the '(.*)' will be shown")]
        public void WhenThePromptMessageOfTheWillBeShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Education entry successfully removed");
        }

        [Then(@"the Education should have the deleted successfully")]
        public void ThenTheEducationShouldHaveTheDeletedSuccessfully()
        {
            string editedUniversityName = profileEducObj.GetUniversityName2(testDriver);
            string editedCountryUni = profileEducObj.GetCountryUni2(testDriver);
            string editedTitle = profileEducObj.GetTitle2(testDriver);
            string editedDegree = profileEducObj.GetDegree2(testDriver);
            string editedGraduationYr =  profileEducObj.GetGraduationYear2(testDriver);

            // Assertion that UniversityName, University, Title, Degree and GraduationYear record has been deleted.
            Assert.AreNotEqual(editedUniversityName == "SMU", "SMU entry successfully removed");
            Assert.AreNotEqual(editedCountryUni == "Singapore", "Singapore entry successfully removed");
            Assert.AreNotEqual(editedTitle == "B.Tech", "B.Tech entry successfully removed");
            Assert.AreNotEqual(editedDegree == "Software Testing", "Software Testing entry successfully removed");
            Assert.AreNotEqual(editedGraduationYr == "2021", "2021 entry successfully removed");
        }
    }
}
