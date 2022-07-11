using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ExcluirTarefaSteps
    {
        TarefaPage tarefaPage;
        public ExcluirTarefaSteps()
        {
            tarefaPage = new TarefaPage();
        }
        [StepDefinition(@"clicar no checkbox da tarefa a excluir")]
        public void GivenClicarNoCheckboxDaTarefaAExcluir()
        {
            tarefaPage.ClicarNoCheckboxDaTarefaAExcluir();
        }
        
        [StepDefinition(@"selecionar o selecionar tudo")]
        public void GivenSelecionarOSelecionarTudo()
        {
            tarefaPage.SelecionarOSelecionarTudo("Apagar");
        }
        
        [StepDefinition(@"clicar no botao ok")]
        public void GivenClicarNoBotaoOk()
        {
            tarefaPage.ClicarNoBotaoOk();
        }
        
        [StepDefinition(@"clicar no botao apagar tarefas")]
        public void WhenClicarNoBotaoApagarTarefas()
        {
            tarefaPage.ClicarNoBotaoApagarTarefas();
        }

        [StepDefinition(@"validar a exclusao da tarefa no banco")]
        public void ThenValidarAExclusaoDaTarefaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_bug_table", "id", "2"));
        }

        [StepDefinition(@"clicar com java script no botao ok")]
        public void GivenClicarComJavaScriptNoBotaoOk()
        {
            tarefaPage.GivenClicarComJavaScriptNoBotaoOk();
        }

        [StepDefinition(@"clicar com java script no botao apagar tarefas")]
        public void WhenClicarComJavaScriptNoBotaoApagarTarefas()
        {
            tarefaPage.ClicarNoBotaoApagarTarefasJavaScript();
        }
    }
}
