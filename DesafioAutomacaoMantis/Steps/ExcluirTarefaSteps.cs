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
        ExcluirTarefaPage excluirTarefaPage;
        public ExcluirTarefaSteps()
        {
            excluirTarefaPage = new ExcluirTarefaPage();
        }
        [StepDefinition(@"clicar no checkbox da tarefa a excluir")]
        public void GivenClicarNoCheckboxDaTarefaAExcluir()
        {
            excluirTarefaPage.ClicarNoCheckboxDaTarefaAExcluir();
        }
        
        [StepDefinition(@"selecionar o selecionar tudo")]
        public void GivenSelecionarOSelecionarTudo()
        {
            excluirTarefaPage.SelecionarOSelecionarTudo("Apagar");
        }
        
        [StepDefinition(@"clicar no botao ok")]
        public void GivenClicarNoBotaoOk()
        {
            excluirTarefaPage.ClicarNoBotaoOk();
        }
        
        [StepDefinition(@"clicar no botao apagar tarefas")]
        public void WhenClicarNoBotaoApagarTarefas()
        {
            excluirTarefaPage.ClicarNoBotaoApagarTarefas();
        }

        [StepDefinition(@"validar a exclusao da tarefa no banco")]
        public void ThenValidarAExclusaoDaTarefaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD("mantis_bug_table", "id", "2"));
        }

        [StepDefinition(@"clicar com java script no botao ok")]
        public void GivenClicarComJavaScriptNoBotaoOk()
        {
            excluirTarefaPage.GivenClicarComJavaScriptNoBotaoOk();
        }

        [StepDefinition(@"clicar com java script no botao apagar tarefas")]
        public void WhenClicarComJavaScriptNoBotaoApagarTarefas()
        {
            excluirTarefaPage.ClicarNoBotaoApagarTarefasJavaScript();
        }
    }
}
