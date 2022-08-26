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
            ManageDBSteps.DeleteUserDB(JsonBuilder.GetAppSettings("USER_ADM"));
            ManageDBSteps.InsertUserDB(JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("PASSWORD_HASH"));
            ManageDBSteps.InsertUserDB(JsonBuilder.GetAppSettings("USER_ADM"), JsonBuilder.GetAppSettings("PASSWORD_HASH"));
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            ExtentReportHelpers.CreateScenario();
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Manage().Window.Maximize();
            ManageDBSteps.InserirMassaDB();
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
            ManageDBSteps.DeletarMassaDB();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReportHelpers.FlushExtent();
        }
    }
}
