using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class PesquisarTarefaSteps
    {
        AlterarTarefaPage alterarTarefaPage;
        public PesquisarTarefaSteps()
        {
            alterarTarefaPage = new AlterarTarefaPage();
        }
        [StepDefinition(@"preencher o campo tarefa")]
        public void GivenPreencherOCampoTarefa()
        {
            alterarTarefaPage.PreencherOCampoTarefa("0000002");
        }
        
        [StepDefinition(@"apertar a tecla enter")]
        public void WhenApertarATecla()
        {
            alterarTarefaPage.ApertarATeclaEnter();
        }
        
        [StepDefinition(@"visualizar o numero da tarefa")]
        public void ThenVisualizarONumeroDaTarefa()
        {
            Assert.AreEqual("0000002", alterarTarefaPage.VisualizarONumeroDaTarefa());
        }
    }
}
