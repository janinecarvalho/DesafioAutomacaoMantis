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
        AlterarProjetosPage alterarProjetosPage;

        public AlterarProjetosSteps()
        {
            alterarProjetosPage = new AlterarProjetosPage();
        }
        
        [StepDefinition(@"clicar no projeto para alterar")]
        public void GivenClicarNoProjetoParaAlterar()
        {
            alterarProjetosPage.ClicarProjetoDisplayed();
        }
        
        [StepDefinition(@"preencher o campo nome do projeto atualizado")]
        public void GivenPreencherOCampoNomeDoProjetoAtualizado()
        {
            alterarProjetosPage.PreencherNomeProjeto(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }
        
        [StepDefinition(@"selecionar o estado do projeto atualizado")]
        public void GivenSelecionarOEstadoDoProjetoAtualizado()
        {
            alterarProjetosPage.SelecionarEstadoProjeto("obsoleto");
        }
        
        [StepDefinition(@"selecionar a visibilidade do projeto atualizado")]
        public void GivenSelecionarAVisibilidadeDoProjetoAtualizado()
        {
            alterarProjetosPage.SelecionarVisibilidadeProjeto("público");
        }
        
        [StepDefinition(@"preencher o campo descricao do projeto atualizado")]
        public void GivenPreencherOCampoDescricaoDoProjetoAtualizado()
        {
            alterarProjetosPage.PreencherAreaDescricao(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"clicar no botao atualizar projeto")]
        public void WhenClicarNoBotaoAtualizarProjeto()
        {
            alterarProjetosPage.ClicarBotaoAtualizarProjeto();
        }

        [StepDefinition(@"visualizar a alteracao do projeto no banco")]
        public void ThenVisualizarAAlteracaoDoProjetoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_project_table", "name", "Automacao Desafio Base2 [Atualizado]"));
        }

        [StepDefinition(@"preencher com java script o campo nome do projeto atualizado")]
        public void GivenPreencherComJavaScriptOCampoNomeDoProjetoAtualizado()
        {
            alterarProjetosPage.PreencherComJavaScriptOCampoNomeDoProjetoAtualizado(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"preencher com java script o campo descricao do projeto atualizado")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoProjetoAtualizado()
        {
            alterarProjetosPage.PreencherComJavaScriptOCampoDescricaoDoProjetoAtualizado(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"clicar com java script no botao atualizar projeto")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarProjeto()
        {
            alterarProjetosPage.ClicarComJavaScriptNoBotaoAtualizarProjeto();
        }
    }
}
