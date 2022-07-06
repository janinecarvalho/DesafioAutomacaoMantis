using DesafioAutomacaoMantis.Pages;
using TechTalk.SpecFlow;
using DesafioAutomacaoMantis.DataBaseSteps;
using NUnit.Framework;

namespace DesafioAutomacaoMantis.Features
{
    [Binding]
    public class GerenciarProjetosSteps
    {
        ExcluirProjetosPage excluirProjetosPage;
        public GerenciarProjetosSteps()
        {
            excluirProjetosPage = new ExcluirProjetosPage();
        }
        
        [StepDefinition(@"clicar no projeto para excluir")]
        public void GivenClicarNoProjetoParaExcluir()
        {
            excluirProjetosPage.ClicarProjetoDisplayed();
        }
        
        [StepDefinition(@"clicar no botao apagar projeto")]
        public void GivenClicarNoBotaoApagarProjeto()
        {
            excluirProjetosPage.ClicarBotaoApagarProjeto();
        }

        [StepDefinition(@"validar a exclusao no banco")]
        public void ThenValidarAExclusaoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_project_table", "name", "Automacao Desafio Base2OLD"));
        }

        [StepDefinition(@"clicar com java script no projeto para excluir")]
        public void GivenClicarComJavaScriptNoProjetoParaExcluir()
        {
            excluirProjetosPage.ClicarComJavaScriptNoProjetoParaExcluir();
        }

        [StepDefinition(@"clicar com java script no botao apagar projeto")]
        public void GivenClicarComJavaScriptNoBotaoApagarProjeto()
        {
            excluirProjetosPage.ClicarComJavaScriptNoBotaoApagarProjeto();
        }
    }
}
