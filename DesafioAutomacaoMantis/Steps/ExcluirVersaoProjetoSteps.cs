using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirVersaoProjetoSteps
    {
        ProjetosPage projetosPage;
        CadastrarVersaoProjetoFlow cadastrarVersaoProjetoFlow;

        public ExcluirVersaoProjetoSteps()
        {
            projetosPage = new ProjetosPage();

            cadastrarVersaoProjetoFlow = new CadastrarVersaoProjetoFlow();

            cadastrarVersaoProjetoFlow.CadastrarVersaoProjetoComSucesso();
        }

        [StepDefinition(@"clicar no botao apagar da versao do projeto")]
        public void GivenClicarNoBotaoApagarDaVersaoDoProjeto()
        {
            projetosPage.ClicarNoBotaoApagarDaVersaoDoProjeto();
        }
        
        [StepDefinition(@"clicar no botao apagar versao")]
        public void WhenClicarNoBotaoApagarVersao()
        {
            projetosPage.ClicarNoBotaoApagarVersao();
        }
        
        [StepDefinition(@"visualizar a exclusao da versao no banco")]
        public void ThenVisualizarAExclusaoDaVersaoNoBanco()
        {
            Assert.True(projetosPage.VisualizarAExclusaoDaVersaoNoBanco(JsonBuilder.GetAppSettings("VERSAO_PROJETO")));
        }
    }
}
