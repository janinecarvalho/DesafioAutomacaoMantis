using DesafioAutomacaoMantis.Helpers;
using TechTalk.SpecFlow;
using DesafioAutomacaoMantis.DataBaseSteps;

namespace DesafioAutomacaoMantis.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReportHelpers.ConfigureReport();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            ExtentReportHelpers.CreateFeature();
            ManageDBSteps.DeleteUserDB(JsonBuilder.GetAppSettings("USER"));
            ManageDBSteps.InsertUserDB(JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("PASSWORD_HASH"));
            ManageDBSteps.InserirMassaDB();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            ExtentReportHelpers.CreateScenario();
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Manage().Window.Maximize();
        }

        [AfterStep]
        public static void AfterStep()
        {
            ExtentReportHelpers.CreateStep();
        }

        [AfterScenario]
        public static void TearDownScenario()
        {
            DriverFactory.QuitInstance();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReportHelpers.FlushExtent();
        }
    }
}
