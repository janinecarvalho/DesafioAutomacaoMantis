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
        AlterarCategoriaProjetosPage alterarCategoriaProjetosPage;

        public AlterarCategoriaProjetosSteps()
        {
            alterarCategoriaProjetosPage = new AlterarCategoriaProjetosPage();
        }
        
        [StepDefinition(@"clicar no botao alterar")]
        public void GivenClicarNoBotaoAlterar()
        {
            alterarCategoriaProjetosPage.ClicarBotaoAlterarCategoria();
        }
        
        [StepDefinition(@"preencher o campo nome da categoria atualizado")]
        public void GivenPreencherOCampoNomeDaCategoriaAtualizado()
        {
            alterarCategoriaProjetosPage.PreencherCampoNomeCategoria(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA"));
        }
        
        [StepDefinition(@"selecionar a atribuicao da categoria")]
        public void GivenSelecionarAAtribuicaoDaCategoria()
        {
            alterarCategoriaProjetosPage.SelecionarAtribuicaoCategoria(JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"clicar no botao atualizar categoria")]
        public void WhenClicarNoBotaoAtualizarCategoria()
        {
            alterarCategoriaProjetosPage.ClicarBotaoAtualizarCategoria();
        }

        [StepDefinition(@"visualizar a alteracao da categoria no banco")]
        public void ThenVisualizarAAlteracaoDaCategoriaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_category_table", "name", "BASE_2 [Atualizado]"));
        }

        [StepDefinition(@"clicar com java script no botao alterar")]
        public void GivenClicarComJavaScriptNoBotaoAlterar()
        {
            alterarCategoriaProjetosPage.ClicarBotaoAlterarCategoriaComJavaScript();
        }

        [StepDefinition(@"preencher com java script o campo nome da categoria atualizado")]
        public void GivenPreencherComJavaScriptOCampoNomeDaCategoriaAtualizado()
        {
            alterarCategoriaProjetosPage.PreencherCampoNomeCategoriaComJavaScript(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA"));
        }

        [StepDefinition(@"selecionar com java script a atribuicao da categoria")]
        public void GivenSelecionarComJavaScriptAAtribuicaoDaCategoria()
        {
            alterarCategoriaProjetosPage.SelecionarAtribuicaoCategoriaComJavaScript(JsonBuilder.GetAppSettings("USER"));
        }

        [StepDefinition(@"clicar com java script no botao atualizar categoria")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarCategoria()
        {
            alterarCategoriaProjetosPage.ClicarBotaoAtualizarCategoriaComJavaScript();
        }

    }
}
