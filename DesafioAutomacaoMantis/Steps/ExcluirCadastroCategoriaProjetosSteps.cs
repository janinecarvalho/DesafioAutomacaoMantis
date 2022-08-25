using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirCadastroCategoriaProjetosSteps
    {
        CategoriaProjetosPage categoriaProjetosPage;

        public ExcluirCadastroCategoriaProjetosSteps()
        {
            categoriaProjetosPage = new CategoriaProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_category_table";
        string coluna = "id";
        string textoEsperado = "2";
        #endregion

        [StepDefinition(@"clicar no botao apagar")]
        public void GivenClicarNoBotaoApagar()
        {
            categoriaProjetosPage.ClicarBotaoApagar();
        }
        
        [StepDefinition(@"clicar no botao apagar categoria")]
        public void WhenClicarNoBotaoApagarCategoria()
        {
            categoriaProjetosPage.ClicarBotaoApagarCategoria();
        }

        [StepDefinition(@"visualizar a exclusao da categoria no banco")]
        public void ThenVisualizarAExclusaoDaCategoriaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"clicar com java script no botao apagar")]
        public void GivenClicarComJavaScriptNoBotaoApagar()
        {
            categoriaProjetosPage.ClicarComJavaScriptNoBotaoApagar();
        }

        [StepDefinition(@"clicar com java script no botao apagar categoria")]
        public void WhenClicarComJavaScriptNoBotaoApagarCategoria()
        {
            categoriaProjetosPage.ClicarComJavaScriptNoBotaoApagarCategoria();
        }
    }
}
