using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarProjetosSteps
    {
        ProjetosPage projetosPage;

        public AlterarProjetosSteps()
        {
            projetosPage = new ProjetosPage();
        }
        
        [StepDefinition(@"clicar no projeto para alterar")]
        public void GivenClicarNoProjetoParaAlterar()
        {
            projetosPage.ClicarProjetoDisplayed();
        }
        
        [StepDefinition(@"preencher o campo nome do projeto atualizado")]
        public void GivenPreencherOCampoNomeDoProjetoAtualizado()
        {
            projetosPage.PreencherNomeProjeto(JsonBuilder.GetAppSettings("NOME_PROJETO") + " [Atualizado]");
        }
        
        [StepDefinition(@"selecionar o estado do projeto atualizado")]
        public void GivenSelecionarOEstadoDoProjetoAtualizado()
        {
            projetosPage.SelecionarEstadoProjeto("obsoleto");
        }
        
        [StepDefinition(@"selecionar a visibilidade do projeto atualizado")]
        public void GivenSelecionarAVisibilidadeDoProjetoAtualizado()
        {
            projetosPage.SelecionarVisibilidadeProjeto("público");
        }
        
        [StepDefinition(@"preencher o campo descricao do projeto atualizado")]
        public void GivenPreencherOCampoDescricaoDoProjetoAtualizado()
        {
            projetosPage.PreencherAreaDescricao(" [Atualizado]");
        }

        [StepDefinition(@"clicar no botao atualizar projeto")]
        public void WhenClicarNoBotaoAtualizarProjeto()
        {
            projetosPage.ClicarBotaoAtualizarProjeto();
        }

        [StepDefinition(@"visualizar a alteracao do projeto no banco")]
        public void ThenVisualizarAAlteracaoDoProjetoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_project_table", "name", "Automacao Desafio Base2 [Atualizado]"));
        }

        [StepDefinition(@"preencher com java script o campo nome do projeto atualizado")]
        public void GivenPreencherComJavaScriptOCampoNomeDoProjetoAtualizado()
        {
            projetosPage.PreencherComJavaScriptOCampoNomeDoProjetoAtualizado(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"preencher com java script o campo descricao do projeto atualizado")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoProjetoAtualizado()
        {
            projetosPage.PreencherComJavaScriptOCampoDescricaoDoProjetoAtualizado(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"clicar com java script no botao atualizar projeto")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarProjeto()
        {
            projetosPage.ClicarComJavaScriptNoBotaoAtualizarProjeto();
        }
    }
}
