using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirCadastroCategoriaProjetosSteps
    {
        ExcluirCategoriaProjetosPage excluirCadastroCategoriaProjetosPage;

        public ExcluirCadastroCategoriaProjetosSteps()
        {
            excluirCadastroCategoriaProjetosPage = new ExcluirCategoriaProjetosPage();
        }
        
        [StepDefinition(@"clicar no botao apagar")]
        public void GivenClicarNoBotaoApagar()
        {
            excluirCadastroCategoriaProjetosPage.ClicarBotaoApagar();
        }
        
        [StepDefinition(@"clicar no botao apagar categoria")]
        public void WhenClicarNoBotaoApagarCategoria()
        {
            excluirCadastroCategoriaProjetosPage.ClicarBotaoApagarCategoria();
        }

        [StepDefinition(@"visualizar a exclusao da categoria no banco")]
        public void ThenVisualizarAExclusaoDaCategoriaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_category_table", "id", "2"));
        }

        [StepDefinition(@"clicar com java script no botao apagar")]
        public void GivenClicarComJavaScriptNoBotaoApagar()
        {
            excluirCadastroCategoriaProjetosPage.ClicarComJavaScriptNoBotaoApagar();
        }

        [StepDefinition(@"clicar com java script no botao apagar categoria")]
        public void WhenClicarComJavaScriptNoBotaoApagarCategoria()
        {
            excluirCadastroCategoriaProjetosPage.ClicarComJavaScriptNoBotaoApagarCategoria();
        }
    }
}
