using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Pages;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarLembreteSteps
    {
        TarefaPage tarefaPage;
        CadastrarLembreteFlow CadastrarLembreteFlow;

        public AlterarLembreteSteps()
        {
            tarefaPage = new TarefaPage();

            CadastrarLembreteFlow = new CadastrarLembreteFlow();

            CadastrarLembreteFlow.CadastrarLembreteComSucesso("janine", "Teste lembrete!");
        }

        [StepDefinition(@"clicar no botao alterar lembrete")]
        public void GivenClicarNoBotaoAlterarLembrete()
        {
            tarefaPage.ClicarNoBotaoAlterarLembrete();
        }
        
        [StepDefinition(@"atualizar o texto do lembrete")]
        public void GivenAtualizarOTextoDoLembrete()
        {
            tarefaPage.AtualizarOTextoDoLembrete(" [Atualizado]!");
        }
        
        [StepDefinition(@"clicar no botao atualizar informacao do lembrete")]
        public void WhenClicarNoBotaoAtualizarInformacaoDoLembrete()
        {
            tarefaPage.ClicarNoBotaoAtualizarInformacaoDoLembrete();
        }

        [StepDefinition(@"clicar com java script no botao alterar lembrete")]
        public void GivenClicarComJavaScriptNoBotaoAlterarLembrete()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoAlterarLembrete();
        }

        [StepDefinition(@"atualizar com java script o texto do lembrete")]
        public void GivenAtualizarComJavaScriptOTextoDoLembrete()
        {
            tarefaPage.PreencherComJavaScriptOTextoDoLembrete(" [Atualizado]!");
        }

        [StepDefinition(@"clicar com java script no botao atualizar informacao do lembrete")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarInformacaoDoLembrete()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoAtualizarInformacaoDoLembrete();
        }

        [StepDefinition(@"visualizar a alteracao do lembrete no banco")]
        public void ThenVisualizarAAlteracaoDoLembreteNoBanco()
        {
            tarefaPage.VisualizarAAlteracaoDoLembreteNoBanco("Teste lembrete! [Atualizado]!");
        }
    }
}
