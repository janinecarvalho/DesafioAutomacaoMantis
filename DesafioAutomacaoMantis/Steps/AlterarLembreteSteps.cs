using DesafioAutomacaoMantis.Pages;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarLembreteSteps
    {
        AlterarTarefaPage alterarTarefaPage;

        public AlterarLembreteSteps()
        {
            alterarTarefaPage = new AlterarTarefaPage();
        }

        [StepDefinition(@"clicar no botao alterar lembrete")]
        public void GivenClicarNoBotaoAlterarLembrete()
        {
            alterarTarefaPage.ClicarNoBotaoAlterarLembrete();
        }
        
        [StepDefinition(@"atualizar o texto do lembrete")]
        public void GivenAtualizarOTextoDoLembrete()
        {
            alterarTarefaPage.AtualizarOTextoDoLembrete(" [Atualizado]!");
        }
        
        [StepDefinition(@"clicar no botao atualizar informacao do lembrete")]
        public void WhenClicarNoBotaoAtualizarInformacaoDoLembrete()
        {
            alterarTarefaPage.ClicarNoBotaoAtualizarInformacaoDoLembrete();
        }

        [StepDefinition(@"clicar com java script no botao alterar lembrete")]
        public void GivenClicarComJavaScriptNoBotaoAlterarLembrete()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoAlterarLembrete();
        }

        [StepDefinition(@"atualizar com java script o texto do lembrete")]
        public void GivenAtualizarComJavaScriptOTextoDoLembrete()
        {
            alterarTarefaPage.PreencherComJavaScriptOTextoDoLembrete(" [Atualizado]!");
        }

        [StepDefinition(@"clicar com java script no botao atualizar informacao do lembrete")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarInformacaoDoLembrete()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoAtualizarInformacaoDoLembrete();
        }

        [StepDefinition(@"visualizar a alteracao do lembrete no banco")]
        public void ThenVisualizarAAlteracaoDoLembreteNoBanco()
        {
            alterarTarefaPage.VisualizarAAlteracaoDoLembreteNoBanco("Teste lembrete! [Atualizado]!");
        }
    }
}
