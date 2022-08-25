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

        #region Parameters of test
        string tabela = "mantis_project_table";
        string coluna = "name";
        string textoEsperado = "Automacao Desafio Base2OLD";
        #endregion

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
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
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
