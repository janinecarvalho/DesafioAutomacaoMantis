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
        CriarTarefaPage criarTarefaPage;
        public CriarTarefaSteps()
        {
            criarTarefaPage = new CriarTarefaPage();
        }
        [StepDefinition(@"clicar no botao criar tarefa")]
        public void GivenClicarNoBotaoCriarTarefa()
        {
            criarTarefaPage.ClicarNoBotaoCriarTarefa();
        }
        
        [StepDefinition(@"selecionar a categoria")]
        public void GivenSelecionarACategoria()
        {
            criarTarefaPage.SelecionarACategoria(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"));
        }
        
        [StepDefinition(@"selecionar a frequencia")]
        public void GivenSelecionarAFrequencia()
        {
            criarTarefaPage.SelecionarAFrequencia("aleatório");
        }
        
        [StepDefinition(@"selecionar a gravidade")]
        public void GivenSelecionarAGravidade()
        {
            criarTarefaPage.SelecionarAGravidade("mínimo");
        }
        
        [StepDefinition(@"selecionar a prioridade")]
        public void GivenSelecionarAPrioridade()
        {
            criarTarefaPage.SelecionarAPrioridade("baixa");
        }
        [StepDefinition(@"selecionar o campo perfil")]
        public void GivenSelecionarOCampoPerfil()
        {
            criarTarefaPage.SelecionarOCampoPerfil(JsonBuilder.GetAppSettings("PERFIL_OS"));
        }
        
        [StepDefinition(@"selecionar o campo atribuir")]
        public void GivenSelecionarOCampoAtribuir()
        {
            criarTarefaPage.SelecionarOCampoAtribuir(JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"preencher o campo resumo")]
        public void GivenPreencherOCampoResumo()
        {
            criarTarefaPage.PreencherOCampoResumo(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }
        
        [StepDefinition(@"preencher o campo descricao")]
        public void GivenPreencherOCampoDescricao()
        {
            criarTarefaPage.PreencherOCampoDescricao(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }
        
        [StepDefinition(@"preencher o campo passos para reproduzir")]
        public void GivenPreencherOCampoPassosParaReproduzir()
        {
            criarTarefaPage.PreencherOCampoPassosParaReproduzir("1-Executar.");
        }
        
        [StepDefinition(@"preencher o campo informacao adicionais")]
        public void GivenPreencherOCampoInformacaoAdicionais()
        {
            criarTarefaPage.PreencherOCampoInformacaoAdicionais("N-A");
        }
        
        [StepDefinition(@"preencher o campo aplicar marcadores")]
        public void GivenPreencherOCampoAplicarMarcadores()
        {
            criarTarefaPage.PreencherOCampoAplicarMarcadores(";");
        }
        
        [StepDefinition(@"marcar o check continuar relatando")]
        public void GivenMarcarOCheckContinuarRelatando()
        {
            criarTarefaPage.MarcarOCheckContinuarRelatando();
        }
        
        [StepDefinition(@"clicar no botao criar nova tarefa")]
        public void WhenClicarNoBotaoCriarNovaTarefa()
        {
            criarTarefaPage.ClicarNoBotaoCriarNovaTarefa();
        }
       
        [StepDefinition(@"vizualizar a inclusao da tarefa no banco")]
        public void ThenVizualizarAInclusaoDaTarefaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_bug_table", "summary", "DesafioB2"));
        }

        [StepDefinition(@"clicar com java script no botao criar tarefa")]
        public void GivenClicarComJavaScriptNoBotaoCriarTarefa()
        {
            criarTarefaPage.GivenClicarComJavaScriptNoBotaoCriarTarefa();
        }

        [StepDefinition(@"preencher com java script o campo resumo")]
        public void GivenPreencherComJavaScriptOCampoResumo()
        {
            criarTarefaPage.PreencherComJavaScriptOCampoResumo(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }

        [StepDefinition(@"preencher com java script o campo descricao")]
        public void GivenPreencherComJavaScriptOCampoDescricao()
        {
            criarTarefaPage.PreencherComJavaScriptOCampoDescricao(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }

        [StepDefinition(@"preencher com java script o campo passos para reproduzir")]
        public void GivenPreencherComJavaScriptOCampoPassosParaReproduzir()
        {
            criarTarefaPage.PreencherComJavaScriptOCampoPassosParaReproduzir("1-Executar.");
        }

        [StepDefinition(@"preencher com java script o campo informacao adicionais")]
        public void GivenPreencherComJavaScriptOCampoInformacaoAdicionais()
        {
            criarTarefaPage.PreencherComJavaScriptOCampoInformacaoAdicionais("N-A");
        }

        [StepDefinition(@"preencher com java script o campo aplicar marcadores")]
        public void GivenPreencherComJavaScriptOCampoAplicarMarcadores()
        {
            criarTarefaPage.PreencherComJavaScriptOCampoAplicarMarcadores(";");
        }

        [StepDefinition(@"clicar com java script no botao criar nova tarefa")]
        public void WhenClicarComJavaScriptNoBotaoCriarNovaTarefa()
        {
            criarTarefaPage.ClicarComJavaScriptNoBotaoCriarNovaTarefa();
        }
    }
}
