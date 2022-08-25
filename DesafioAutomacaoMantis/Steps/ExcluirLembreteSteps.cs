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
    public class ExcluirLembreteSteps
    {
        TarefaPage tarefaPage;

        public ExcluirLembreteSteps()
        {
            tarefaPage = new TarefaPage();
        }

        #region Parameters of test
        string tabela = "mantis_bugnote_text_table";
        string coluna = "note";
        string textoEsperado = "Teste lembrete! [Atualizado]!";
        #endregion

        [StepDefinition(@"clicar no botao apagar lembrete")]
        public void GivenClicarNoBotaoApagarLembrete()
        {
            tarefaPage.ClicarNoBotaoApagarLembrete();
        }

        [StepDefinition(@"clicar no botao apagar anotacao")]
        public void WhenClicarNoBotaoApagarAnotacao()
        {
            tarefaPage.ClicarNoBotaoApagarAnotacao();
        }

        [StepDefinition(@"visualizar a exclusao do lembrete no banco")]
        public void ThenVisualizarAExclusaoDoLembreteNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
        }
    }
}
