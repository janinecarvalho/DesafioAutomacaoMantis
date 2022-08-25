using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirMarcadorProjetosSteps
    {
        MarcadorProjetosPage marcadorProjetosPage;

        public ExcluirMarcadorProjetosSteps()
        {
            marcadorProjetosPage = new MarcadorProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_tag_table";
        string coluna = "id";
        string textoEsperado = "2";
        #endregion

        [StepDefinition(@"clicar no botao apagar marcador")]
        public void GivenClicarNoBotaoApagarMarcador()
        {
            marcadorProjetosPage.ClicarBotaoApagarMarcador();
        }

        [StepDefinition(@"visualizar a exclusao do marcador no banco")]
        public void ThenVisualizarAExclusaoDoMarcadorNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"clicar com java script no botao apagar marcador")]
        public void GivenClicarComJavaScriptNoBotaoApagarMarcador()
        {
            marcadorProjetosPage.GivenClicarComJavaScriptNoBotaoApagarMarcador();
        }
    }
}
