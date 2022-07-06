using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarTarefaSteps
    {
        AlterarTarefaPage alterarTarefaPage;
        CadastrarTarefaFlow cadastrarTarefaFlow;
        public AlterarTarefaSteps()
        {
            alterarTarefaPage = new AlterarTarefaPage();
            cadastrarTarefaFlow = new CadastrarTarefaFlow();
            cadastrarTarefaFlow.CadastrarTarefaComSucesso(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"), "aleatório", "mínimo", "baixa", JsonBuilder.GetAppSettings("PERFIL_OS"), JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("NOME_MARCADOR"), JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"), "1-Executar.", "N-A", ";");
        }
        [StepDefinition(@"clicar no botao ver tarefas")]
        public void GivenClicarNoBotaoVerTarefas()
        {
            alterarTarefaPage.ClicarNoBotaoVerTarefas();
        }
        
        [StepDefinition(@"clicar no botao atualizar")]
        public void GivenClicarNoBotaoAtualizar()
        {
            alterarTarefaPage.ClicarNoBotaoAtualizar();
        }
        
        [StepDefinition(@"selecionar a categoria atualizado")]
        public void GivenSelecionarACategoriaAtualizado()
        {
            alterarTarefaPage.SelecionarACategoriaAtualizado(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"));
        }
        
        [StepDefinition(@"selecionar a visibilidade atualizado")]
        public void GivenSelecionarAvisibilidadeAtualizado()
        {
            alterarTarefaPage.SelecionarAvisibilidadeAtualizado(JsonBuilder.GetAppSettings("VISIBILIDADE_PROJETO"));
        }

        [StepDefinition(@"selecionar o campo atribuir atualizado")]
        public void GivenSelecionarOCampoAtribuirAtualizado()
        {
            alterarTarefaPage.SelecionarOCampoAtribuirAtualizado(JsonBuilder.GetAppSettings("USER"));
        }

        [StepDefinition(@"selecionar a prioridade atualizado")]
        public void GivenSelecionarAPrioridadeAtualizado()
        {
            alterarTarefaPage.SelecionarAPrioridadeAtualizado(JsonBuilder.GetAppSettings("PRIORIDADE_PROJETO"));
        }

        [StepDefinition(@"selecionar a gravidade atualizado")]
        public void GivenSelecionarAGravidadeAtualizado()
        {
            alterarTarefaPage.SelecionarAGravidadeAtualizado(JsonBuilder.GetAppSettings("GRAVIDADE_PROJETO"));
        }

        [StepDefinition(@"selecionar o campo estado")]
        public void GivenSelecionarOCampoEstado()
        {
            alterarTarefaPage.SelecionarOCampoEstado(JsonBuilder.GetAppSettings("ESTADO_PROJETO_UPDATE"));
        }
        
        [StepDefinition(@"selecionar o campo resolucao")]
        public void GivenSelecionarOCampoResolucao()
        {
            alterarTarefaPage.SelecionarOCampoResolucao(JsonBuilder.GetAppSettings("RESOLUCAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao atualizar informacao")]
        public void WhenClicarNoBotaoAtualizarInformacao()
        {
            alterarTarefaPage.ClicarNoBotaoAtualizarInformacao();
        }

        [Then(@"vizualizar a alteracao da tarefa no banco")]
        public void ThenVizualizarAAlteracaoDaTarefaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_bug_table", "status", "10"));
        }

        [StepDefinition(@"clicar com java script no botao ver tarefas")]
        public void GivenClicarComJavaScriptNoBotaoVerTarefas()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoVerTarefas();
        }

        [StepDefinition(@"clicar com java script no botao atualizar")]
        public void GivenClicarComJavaScriptNoBotaoAtualizar()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoAtualizar();
        }

        [StepDefinition(@"clicar com java script no botao atualizar informacao")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarInformacao()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoAtualizarInformacao();
        }
    }
}
