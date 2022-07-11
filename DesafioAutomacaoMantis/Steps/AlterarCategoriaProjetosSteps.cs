using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarCategoriaProjetosSteps
    {
        CategoriaProjetosPage categoriaProjetosPage;

        public AlterarCategoriaProjetosSteps()
        {
            categoriaProjetosPage = new CategoriaProjetosPage();
        }
        
        [StepDefinition(@"clicar no botao alterar")]
        public void GivenClicarNoBotaoAlterar()
        {
            categoriaProjetosPage.ClicarBotaoAlterarCategoria();
        }
        
        [StepDefinition(@"preencher o campo nome da categoria atualizado")]
        public void GivenPreencherOCampoNomeDaCategoriaAtualizado()
        {
            categoriaProjetosPage.PreencherCampoNomeCategoriaAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA"));
        }
        
        [StepDefinition(@"selecionar a atribuicao da categoria")]
        public void GivenSelecionarAAtribuicaoDaCategoria()
        {
            categoriaProjetosPage.SelecionarAtribuicaoCategoria(JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"clicar no botao atualizar categoria")]
        public void WhenClicarNoBotaoAtualizarCategoria()
        {
            categoriaProjetosPage.ClicarBotaoAtualizarCategoria();
        }

        [StepDefinition(@"visualizar a alteracao da categoria no banco")]
        public void ThenVisualizarAAlteracaoDaCategoriaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_category_table", "name", "BASE_2 [Atualizado]"));
        }

        [StepDefinition(@"clicar com java script no botao alterar")]
        public void GivenClicarComJavaScriptNoBotaoAlterar()
        {
            categoriaProjetosPage.ClicarBotaoAlterarCategoriaComJavaScript();
        }

        [StepDefinition(@"preencher com java script o campo nome da categoria atualizado")]
        public void GivenPreencherComJavaScriptOCampoNomeDaCategoriaAtualizado()
        {
            categoriaProjetosPage.PreencherCampoNomeCategoriaComJavaScript(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA") + " [Atualizado]");
        }

        [StepDefinition(@"selecionar com java script a atribuicao da categoria")]
        public void GivenSelecionarComJavaScriptAAtribuicaoDaCategoria()
        {
            categoriaProjetosPage.SelecionarAtribuicaoCategoriaComJavaScript(JsonBuilder.GetAppSettings("USER"));
        }

        [StepDefinition(@"clicar com java script no botao atualizar categoria")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarCategoria()
        {
            categoriaProjetosPage.ClicarBotaoAtualizarCategoriaComJavaScript();
        }

    }
}
