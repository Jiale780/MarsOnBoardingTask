using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MarsOnBoardingTask.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsOnBoardingTask.Utils
{
    [Binding]
    public class Hooks : Steps
    {
        public IWebDriver testDriver;
        // ExtentReports
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext sc)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            object TestResult = getter.Invoke(sc, null);
            if (sc.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            if (sc.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(sc.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(sc.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(sc.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(sc.TestError.Message);
            }
            //Pending Status
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            }
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            featureName = extent.CreateTest(featurecontext.FeatureInfo.Title);
        }

        [BeforeScenario]
        [System.Obsolete]
        public void Setup()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();

            // Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.GoToHomePage(testDriver);
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(testDriver, "TestProfile");
            featureName.Log(Status.Info, "Snapshot below: " + featureName.AddScreenCaptureFromPath(img));

            testDriver.Quit();
        }
    }
}
