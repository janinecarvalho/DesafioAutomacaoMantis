using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CriarTarefaSteps
    {
        TarefaPage tarefaPage;
        public CriarTarefaSteps()
        {
            tarefaPage = new TarefaPage();
        }
        [StepDefinition(@"clicar no botao criar tarefa")]
        public void GivenClicarNoBotaoCriarTarefa()
        {
            tarefaPage.ClicarNoBotaoCriarTarefa();
        }
        
        [StepDefinition(@"selecionar a categoria")]
        public void GivenSelecionarACategoria()
        {
            tarefaPage.SelecionarACategoria(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"));
        }
        
        [StepDefinition(@"selecionar a frequencia")]
        public void GivenSelecionarAFrequencia()
        {
            tarefaPage.SelecionarAFrequencia("aleatório");
        }
        
        [StepDefinition(@"selecionar a gravidade")]
        public void GivenSelecionarAGravidade()
        {
            tarefaPage.SelecionarAGravidade("mínimo");
        }
        
        [StepDefinition(@"selecionar a prioridade")]
        public void GivenSelecionarAPrioridade()
        {
            tarefaPage.SelecionarAPrioridade("baixa");
        }
        [StepDefinition(@"selecionar o campo perfil")]
        public void GivenSelecionarOCampoPerfil()
        {
            tarefaPage.SelecionarOCampoPerfil(JsonBuilder.GetAppSettings("PERFIL_OS"));
        }
        
        [StepDefinition(@"selecionar o campo atribuir")]
        public void GivenSelecionarOCampoAtribuir()
        {
            tarefaPage.SelecionarOCampoAtribuir(JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"preencher o campo resumo")]
        public void GivenPreencherOCampoResumo()
        {
            tarefaPage.PreencherOCampoResumo(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }
        
        [StepDefinition(@"preencher o campo descricao")]
        public void GivenPreencherOCampoDescricao()
        {
            tarefaPage.PreencherOCampoDescricao(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }
        
        [StepDefinition(@"preencher o campo passos para reproduzir")]
        public void GivenPreencherOCampoPassosParaReproduzir()
        {
            tarefaPage.PreencherOCampoPassosParaReproduzir("1-Executar.");
        }
        
        [StepDefinition(@"preencher o campo informacao adicionais")]
        public void GivenPreencherOCampoInformacaoAdicionais()
        {
            tarefaPage.PreencherOCampoInformacaoAdicionais("N-A");
        }
        
        [StepDefinition(@"preencher o campo aplicar marcadores")]
        public void GivenPreencherOCampoAplicarMarcadores()
        {
            tarefaPage.PreencherOCampoAplicarMarcadores(";");
        }
        
        [StepDefinition(@"marcar o check continuar relatando")]
        public void GivenMarcarOCheckContinuarRelatando()
        {
            tarefaPage.MarcarOCheckContinuarRelatando();
        }
        
        [StepDefinition(@"clicar no botao criar nova tarefa")]
        public void WhenClicarNoBotaoCriarNovaTarefa()
        {
            tarefaPage.ClicarNoBotaoCriarNovaTarefa();
        }
       
        [StepDefinition(@"visualizar a inclusao da tarefa no banco")]
        public void ThenVisualizarAInclusaoDaTarefaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_bug_table", "summary", "DesafioB2"));
        }

        [StepDefinition(@"clicar com java script no botao criar tarefa")]
        public void GivenClicarComJavaScriptNoBotaoCriarTarefa()
        {
            tarefaPage.GivenClicarComJavaScriptNoBotaoCriarTarefa();
        }

        [StepDefinition(@"preencher com java script o campo resumo")]
        public void GivenPreencherComJavaScriptOCampoResumo()
        {
            tarefaPage.PreencherComJavaScriptOCampoResumo(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }

        [StepDefinition(@"preencher com java script o campo descricao")]
        public void GivenPreencherComJavaScriptOCampoDescricao()
        {
            tarefaPage.PreencherComJavaScriptOCampoDescricao(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }

        [StepDefinition(@"preencher com java script o campo passos para reproduzir")]
        public void GivenPreencherComJavaScriptOCampoPassosParaReproduzir()
        {
            tarefaPage.PreencherComJavaScriptOCampoPassosParaReproduzir("1-Executar.");
        }

        [StepDefinition(@"preencher com java script o campo informacao adicionais")]
        public void GivenPreencherComJavaScriptOCampoInformacaoAdicionais()
        {
            tarefaPage.PreencherComJavaScriptOCampoInformacaoAdicionais("N-A");
        }

        [StepDefinition(@"preencher com java script o campo aplicar marcadores")]
        public void GivenPreencherComJavaScriptOCampoAplicarMarcadores()
        {
            tarefaPage.PreencherComJavaScriptOCampoAplicarMarcadores(";");
        }

        [StepDefinition(@"clicar com java script no botao criar nova tarefa")]
        public void WhenClicarComJavaScriptNoBotaoCriarNovaTarefa()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoCriarNovaTarefa();
        }
    }
}
