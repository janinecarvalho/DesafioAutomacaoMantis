using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirMarcadorProjetosSteps
    {
        ExcluirMarcadorProjetosPage ExcluirMarcadorProjetosPage;

        public ExcluirMarcadorProjetosSteps()
        {
            ExcluirMarcadorProjetosPage = new ExcluirMarcadorProjetosPage();
        }
        [StepDefinition(@"clicar no botao apagar marcador")]
        public void GivenClicarNoBotaoApagarMarcador()
        {
            ExcluirMarcadorProjetosPage.ClicarBotaoApagarMarcador();
        }

        [StepDefinition(@"visualizar a exclusao do marcador no banco")]
        public void ThenVisualizarAExclusaoDoMarcadorNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_tag_table", "id", "2"));
        }

        [StepDefinition(@"clicar com java script no botao apagar marcador")]
        public void GivenClicarComJavaScriptNoBotaoApagarMarcador()
        {
            ExcluirMarcadorProjetosPage.GivenClicarComJavaScriptNoBotaoApagarMarcador();
        }
    }
}
