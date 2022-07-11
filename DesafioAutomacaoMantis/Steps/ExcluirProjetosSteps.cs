using DesafioAutomacaoMantis.Pages;
using TechTalk.SpecFlow;
using DesafioAutomacaoMantis.DataBaseSteps;
using NUnit.Framework;

namespace DesafioAutomacaoMantis.Features
{
    [Binding]
    public class GerenciarProjetosSteps
    {
        ProjetosPage projetosPage;
        public GerenciarProjetosSteps()
        {
            projetosPage = new ProjetosPage();
        }
        
        [StepDefinition(@"clicar no projeto para excluir")]
        public void GivenClicarNoProjetoParaExcluir()
        {
            projetosPage.ClicarProjetoDisplayed();
        }
        
        [StepDefinition(@"clicar no botao apagar projeto")]
        public void GivenClicarNoBotaoApagarProjeto()
        {
            projetosPage.ClicarBotaoApagarProjeto();
        }

        [StepDefinition(@"validar a exclusao no banco")]
        public void ThenValidarAExclusaoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_project_table", "name", "Automacao Desafio Base2OLD"));
        }

        [StepDefinition(@"clicar com java script no projeto para excluir")]
        public void GivenClicarComJavaScriptNoProjetoParaExcluir()
        {
            projetosPage.ClicarComJavaScriptNoProjetoParaExcluir();
        }

        [StepDefinition(@"clicar com java script no botao apagar projeto")]
        public void GivenClicarComJavaScriptNoBotaoApagarProjeto()
        {
            projetosPage.ClicarComJavaScriptNoBotaoApagarProjeto();
        }
    }
}
