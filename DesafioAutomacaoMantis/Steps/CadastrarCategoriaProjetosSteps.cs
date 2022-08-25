using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CadastrarCategoriaProjetosSteps
    {
        CategoriaProjetosPage categoriaProjetosPage;

        public CadastrarCategoriaProjetosSteps()
        {
            categoriaProjetosPage = new CategoriaProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_category_table";
        string coluna = "name";
        string textoEsperado = "BASE_2";
        #endregion

        [StepDefinition(@"preencher o campo nome da categoria")]
        public void GivenPreencherOCampoNomeDaCategoria()
        {
            categoriaProjetosPage.PreencherCampoNomeCategoria(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA"));
        }

        [StepDefinition(@"clicar no botao adicionar categoria")]
        public void WhenClicarNoBotaoAdicionarCategoria()
        {
            categoriaProjetosPage.ClicarBotaoAdicionarProjeto();
        }

        [StepDefinition(@"visualizar a inclusao da categoria no banco")]
        public void ThenVisualizarAInclusaoDaCategoriaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"preencher com java script o campo nome da categoria")]
        public void GivenPreencherComJavaScriptOCampoNomeDaCategoria()
        {
            categoriaProjetosPage.PreencherCampoNomeCategoriaComJavaScript(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA"));
        }

        [StepDefinition(@"clicar com java script no botao adicionar categoria")]
        public void WhenClicarComJavaScriptNoBotaoAdicionarCategoria()
        {
            categoriaProjetosPage.ClicarBotaoAdicionarProjetoComJavaScript();
        }
    }
}
