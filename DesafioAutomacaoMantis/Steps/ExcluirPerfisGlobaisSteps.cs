using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirPerfisGlobaisSteps
    {
        ExcluirPerfisGlobaisPage excluirPerfisGlobaisPage;
        public ExcluirPerfisGlobaisSteps()
        {
            excluirPerfisGlobaisPage = new ExcluirPerfisGlobaisPage();
        }
        [StepDefinition(@"clicar no radiobox apagar perfil")]
        public void GivenClicarNoRadioboxApagarPerfil()
        {
            excluirPerfisGlobaisPage.ClicarNoRadioboxApagarPerfil();
        }

        [StepDefinition(@"validar a exclusao do perfil no banco")]
        public void ThenValidarAExclusaoDoPerfilNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_bug_table", "id", "2"));
        }
    }
}
