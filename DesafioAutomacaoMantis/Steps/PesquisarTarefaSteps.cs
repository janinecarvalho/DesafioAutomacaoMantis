using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class PesquisarTarefaSteps
    {
        TarefaPage tarefaPage;
        public PesquisarTarefaSteps()
        {
            tarefaPage = new TarefaPage();
        }
        [StepDefinition(@"preencher o campo tarefa")]
        public void GivenPreencherOCampoTarefa()
        {
            tarefaPage.PreencherOCampoTarefa("0000002");
        }
        
        [StepDefinition(@"apertar a tecla enter")]
        public void WhenApertarATecla()
        {
            tarefaPage.ApertarATeclaEnter();
        }
        
        [StepDefinition(@"visualizar o numero da tarefa")]
        public void ThenVisualizarONumeroDaTarefa()
        {
            Assert.AreEqual("0000002", tarefaPage.VisualizarONumeroDaTarefa());
        }
    }
}
