using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirPerfisGlobaisSteps
    {
        PerfisGlobaisPage perfisGlobaisPage;
        public ExcluirPerfisGlobaisSteps()
        {
            perfisGlobaisPage = new PerfisGlobaisPage();
        }

        #region Parameters of test
        string tabela = "mantis_bug_table";
        string coluna = "id";
        string textoEsperado = "2";
        #endregion

        [StepDefinition(@"clicar no radiobox apagar perfil")]
        public void GivenClicarNoRadioboxApagarPerfil()
        {
            perfisGlobaisPage.ClicarNoRadioboxApagarPerfil();
        }

        [StepDefinition(@"validar a exclusao do perfil no banco")]
        public void ThenValidarAExclusaoDoPerfilNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
        }
    }
}
