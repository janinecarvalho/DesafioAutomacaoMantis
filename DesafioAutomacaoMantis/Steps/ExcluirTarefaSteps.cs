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

        #region Parameters of test
        string tabela = "mantis_bug_table";
        string coluna = "id";
        string texto = "Apagar";
        string textoEsperado = "2";
        #endregion

        [StepDefinition(@"clicar no checkbox da tarefa a excluir")]
        public void GivenClicarNoCheckboxDaTarefaAExcluir()
        {
            tarefaPage.ClicarNoCheckboxDaTarefaAExcluir();
        }
        
        [StepDefinition(@"selecionar o selecionar tudo")]
        public void GivenSelecionarOSelecionarTudo()
        {
            tarefaPage.SelecionarOSelecionarTudo(texto);
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
            Assert.IsTrue(ManageDBSteps.ValidarExclusaoBD(tabela, coluna, textoEsperado));
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
