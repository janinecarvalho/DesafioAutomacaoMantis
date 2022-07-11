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

        [StepDefinition(@"preencher com java script o campo tarefa")]
        public void GivenPreencherComJavaScriptOCampoTarefa()
        {
            tarefaPage.PreencherComJavaScriptOCampoTarefa("0000002");
        }

        [StepDefinition(@"clicar com java script no botao apagar lembrete")]
        public void GivenClicarComJavaScriptNoBotaoApagarLembrete()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoApagarLembrete();
        }

        [StepDefinition(@"clicar com java script no botao apagar anotacao")]
        public void WhenClicarComJavaScriptNoBotaoApagarAnotacao()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoApagarAnotacao();
        }
    }
}
