using DesafioAutomacaoMantis.Pages;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirLembreteSteps
    {
        AlterarTarefaPage alterarTarefaPage;

        public ExcluirLembreteSteps()
        {
            alterarTarefaPage = new AlterarTarefaPage();
        }

        [StepDefinition(@"clicar no botao apagar lembrete")]
        public void GivenClicarNoBotaoApagarLembrete()
        {
            alterarTarefaPage.ClicarNoBotaoApagarLembrete();
        }

        [StepDefinition(@"clicar no botao apagar anotacao")]
        public void WhenClicarNoBotaoApagarAnotacao()
        {
            alterarTarefaPage.ClicarNoBotaoApagarAnotacao();
        }

        [StepDefinition(@"visualizar a exclusao do lembrete no banco")]
        public void ThenVisualizarAExclusaoDoLembreteNoBanco()
        {
            alterarTarefaPage.VisualizarAExclusaoDoLembreteNoBanco("Teste lembrete! [Atualizado]!");
        }

        [StepDefinition(@"preencher com java script o campo tarefa")]
        public void GivenPreencherComJavaScriptOCampoTarefa()
        {
            alterarTarefaPage.PreencherComJavaScriptOCampoTarefa("0000002");
        }

        [StepDefinition(@"clicar com java script no botao apagar lembrete")]
        public void GivenClicarComJavaScriptNoBotaoApagarLembrete()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoApagarLembrete();
        }

        [StepDefinition(@"clicar com java script no botao apagar anotacao")]
        public void WhenClicarComJavaScriptNoBotaoApagarAnotacao()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoApagarAnotacao();
        }
    }
}
