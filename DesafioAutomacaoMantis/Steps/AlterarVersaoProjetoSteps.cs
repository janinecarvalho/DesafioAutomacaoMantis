using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarVersaoProjetoSteps
    {
        ProjetosPage projetosPage;
        CadastrarVersaoProjetoFlow cadastrarVersaoProjetoFlow;

        public AlterarVersaoProjetoSteps()
        {
            projetosPage = new ProjetosPage();
            
            cadastrarVersaoProjetoFlow = new CadastrarVersaoProjetoFlow();
            
            cadastrarVersaoProjetoFlow.CadastrarVersaoProjetoComSucesso();
        }

        #region Parameters of test
        string tabela = "mantis_project_version_table";
        string coluna = "version";
        string textoEsperado = "Versão Final [Atualizado]";
        #endregion

        [StepDefinition(@"clicar no botao alterar da versao do projeto")]
        public void GivenClicarNoBotaoAlterarDaVersaoDoProjeto()
        {
            projetosPage.ClicarNoBotaoAlterarDaVersaoDoProjeto();
        }
        
        [StepDefinition(@"preencher o nome da versao do projeto atualizado")]
        public void GivenPreencherONomeDaVersaoDoProjetoAtualizado()
        {
            projetosPage.PreencherONomeDaVersaoDoProjetoAtualizado(JsonBuilder.GetAppSettings("VERSAO_PROJETO") + " [Atualizado]");
        }
        
        [StepDefinition(@"preencher o campo descricao versao do projeto")]
        public void GivenPreencherOCampoDescricaoVersaoDoProjeto()
        {
            projetosPage.PreencherOCampoDescricaoVersaoDoProjeto(JsonBuilder.GetAppSettings("DESCRICAO_CATEGORIA") + " [Atualizado]");
        }
        
        [StepDefinition(@"marcar o check liberada")]
        public void GivenMarcarOCheckLiberada()
        {
            projetosPage.MarcarOCheckLiberada();
        }
        
        [StepDefinition(@"clicar no botao atualizar versao")]
        public void WhenClicarNoBotaoAtualizarVersao()
        {
            projetosPage.ClicarNoBotaoAtualizarVersao();
        }
        
        [StepDefinition(@"visualizar a alteracao do versao no banco")]
        public void ThenVisualizarAAlteracaoDoVersaoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }
    }
}
