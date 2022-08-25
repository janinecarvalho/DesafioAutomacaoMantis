using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CadastrarVersaoProjetoSteps
    {
        ProjetosPage projetosPage;

        public CadastrarVersaoProjetoSteps()
        {
            projetosPage = new ProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_project_version_table";
        string coluna = "version";
        #endregion

        [StepDefinition(@"clicar no projeto")]
        public void GivenClicarNoProjeto()
        {
            projetosPage.ClicarProjetoDisplayed();
        }
        
        [StepDefinition(@"preencher o nome da versao do projeto")]
        public void GivenPreencherONomeDaVersaoDoProjeto()
        {
            projetosPage.PreencherONomeDaVersaoDoProjeto(JsonBuilder.GetAppSettings("VERSAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao adicionar versao")]
        public void WhenClicarNoBotaoAdicionarVersao()
        {
            projetosPage.ClicarNoBotaoAdicionarVersao();
        }
        
        [StepDefinition(@"visualizar a inclusao do versao no banco")]
        public void ThenVisualizarAInclusaoDoVersaoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, JsonBuilder.GetAppSettings("VERSAO_PROJETO")));
        }
    }
}
