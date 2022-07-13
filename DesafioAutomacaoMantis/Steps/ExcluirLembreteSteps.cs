using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
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
            tarefaPage.VisualizarAExclusaoDoLembreteNoBanco("Teste lembrete! [Atualizado]!");
        }
    }
}
