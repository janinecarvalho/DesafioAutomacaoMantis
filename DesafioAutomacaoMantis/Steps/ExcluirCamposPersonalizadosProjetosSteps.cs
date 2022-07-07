using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirCamposPersonalizadosProjetosSteps
    {
        ExcluirCamposPersonalizadosPage excluirCamposPersonalizadosPage;

        public ExcluirCamposPersonalizadosProjetosSteps()
        {
            excluirCamposPersonalizadosPage = new ExcluirCamposPersonalizadosPage();
        }
        [StepDefinition(@"clicar no campo personalizado para excluir")]
        public void GivenClicarNoCampoPersonalizadoParaExcluir()
        {
            excluirCamposPersonalizadosPage.ClicarNoCampoPersonalizadoParaExcluir();
        }
        
        [StepDefinition(@"clicar no botao apagar campo personalizado")]
        public void GivenClicarNoBotaoApagarCampoPersonalizado()
        {
            excluirCamposPersonalizadosPage.ClicarNoBotaoApagarCampoPersonalizado();
        }
        
        [StepDefinition(@"clicar no botao apagar campo")]
        public void WhenClicarNoBotaoApagarCampo()
        {
            excluirCamposPersonalizadosPage.ClicarNoBotaoApagarCampo();
        }

        [StepDefinition(@"visualizar a exclusao do campo personalizado no banco")]
        public void ThenVisualizarAExclusaoDoCampoPersonalizadoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_custom_field_table", "id", "2"));
        }

        [StepDefinition(@"clicar com java script no campo personalizado para excluir")]
        public void GivenClicarComJavaScriptNoCampoPersonalizadoParaExcluir()
        {
            excluirCamposPersonalizadosPage.ClicarComJavaScriptNoCampoPersonalizadoParaExcluir();
        }

        [StepDefinition(@"clicar com java script no botao apagar campo personalizado")]
        public void GivenClicarComJavaScriptNoBotaoApagarCampoPersonalizado()
        {
            excluirCamposPersonalizadosPage.ClicarComJavaScriptNoBotaoApagarCampoPersonalizado();
        }

        [StepDefinition(@"clicar com java script no botao apagar campo")]
        public void WhenClicarComJavaScriptNoBotaoApagarCampo()
        {
            excluirCamposPersonalizadosPage.ClicarComJavaScriptNoBotaoApagarCampo();
        }
    }
}
