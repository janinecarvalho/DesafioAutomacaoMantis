using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
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
        CadastrarTarefaFlow cadastrarTarefaFlow;
        CadastrarLembreteFlow CadastrarLembreteFlow;
        string idTable;

        public PesquisarTarefaSteps()
        {
            tarefaPage = new TarefaPage();

            cadastrarTarefaFlow = new CadastrarTarefaFlow();

            CadastrarLembreteFlow = new CadastrarLembreteFlow();

            cadastrarTarefaFlow.CadastrarTarefaComSucesso(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"), "aleatório", "mínimo", "baixa", JsonBuilder.GetAppSettings("PERFIL_OS"), JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("NOME_MARCADOR"), JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"), "1-Executar.", "N-A", ";");

            CadastrarLembreteFlow.CadastrarLembreteComSucesso("janine", "Teste lembrete!");

            idTable = tarefaPage.GetMaxIdTable();
        }
        [StepDefinition(@"preencher o campo tarefa")]
        public void GivenPreencherOCampoTarefa()
        {
            tarefaPage.PreencherOCampoTarefa(idTable);
        }
        
        [StepDefinition(@"apertar a tecla enter")]
        public void WhenApertarATecla()
        {
            tarefaPage.ApertarATeclaEnter();
        }
        
        [StepDefinition(@"visualizar o numero da tarefa")]
        public void ThenVisualizarONumeroDaTarefa()
        {
            Assert.AreEqual(GeneralHelpers.CompletarNumeroEsquerda(idTable, 7), tarefaPage.VisualizarONumeroDaTarefa());

        }
    }
}
