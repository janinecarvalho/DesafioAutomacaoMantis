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
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_category_table", "id", "2"));
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
