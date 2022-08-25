using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirCamposPersonalizadosProjetosSteps
    {
        CamposPersonalizadosProjetosPage CamposPersonalizadosProjetosPage;

        public ExcluirCamposPersonalizadosProjetosSteps()
        {
            CamposPersonalizadosProjetosPage = new CamposPersonalizadosProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_custom_field_table";
        string coluna = "id";
        string textoEsperado = "2";
        #endregion

        [StepDefinition(@"clicar no campo personalizado para excluir")]
        public void GivenClicarNoCampoPersonalizadoParaExcluir()
        {
            CamposPersonalizadosProjetosPage.ClicarNoCampoPersonalizadoParaExcluir();
        }
        
        [StepDefinition(@"clicar no botao apagar campo personalizado")]
        public void GivenClicarNoBotaoApagarCampoPersonalizado()
        {
            CamposPersonalizadosProjetosPage.ClicarNoBotaoApagarCampoPersonalizado();
        }
        
        [StepDefinition(@"clicar no botao apagar campo")]
        public void WhenClicarNoBotaoApagarCampo()
        {
            CamposPersonalizadosProjetosPage.ClicarNoBotaoApagarCampo();
        }

        [StepDefinition(@"visualizar a exclusao do campo personalizado no banco")]
        public void ThenVisualizarAExclusaoDoCampoPersonalizadoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"clicar com java script no campo personalizado para excluir")]
        public void GivenClicarComJavaScriptNoCampoPersonalizadoParaExcluir()
        {
            CamposPersonalizadosProjetosPage.ClicarComJavaScriptNoCampoPersonalizadoParaExcluir();
        }

        [StepDefinition(@"clicar com java script no botao apagar campo personalizado")]
        public void GivenClicarComJavaScriptNoBotaoApagarCampoPersonalizado()
        {
            CamposPersonalizadosProjetosPage.ClicarComJavaScriptNoBotaoApagarCampoPersonalizado();
        }

        [StepDefinition(@"clicar com java script no botao apagar campo")]
        public void WhenClicarComJavaScriptNoBotaoApagarCampo()
        {
            CamposPersonalizadosProjetosPage.ClicarComJavaScriptNoBotaoApagarCampo();
        }
    }
}
