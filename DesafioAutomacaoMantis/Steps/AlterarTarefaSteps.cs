using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarTarefaSteps
    {
        TarefaPage tarefaPage;
        CadastrarTarefaFlow cadastrarTarefaFlow;
        public AlterarTarefaSteps()
        {
            tarefaPage = new TarefaPage();
            cadastrarTarefaFlow = new CadastrarTarefaFlow();
            cadastrarTarefaFlow.CadastrarTarefaComSucesso(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"), "aleatório", "mínimo", "baixa", JsonBuilder.GetAppSettings("PERFIL_OS"), JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("NOME_MARCADOR"), JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"), "1-Executar.", "N-A", ";");
        }

        #region Parameters of test
        string tabela = "mantis_bug_table";
        string coluna = "status";
        string textoEsperado = "10";
        #endregion

        [StepDefinition(@"clicar no botao ver tarefas")]
        public void GivenClicarNoBotaoVerTarefas()
        {
            tarefaPage.ClicarNoBotaoVerTarefas();
        }
        
        [StepDefinition(@"clicar no botao atualizar")]
        public void GivenClicarNoBotaoAtualizar()
        {
            tarefaPage.ClicarNoBotaoAtualizar();
        }
        
        [StepDefinition(@"selecionar a categoria atualizado")]
        public void GivenSelecionarACategoriaAtualizado()
        {
            tarefaPage.SelecionarACategoriaAtualizado(JsonBuilder.GetAppSettings("CATEGORIA_PROJETO"));
        }
        
        [StepDefinition(@"selecionar a visibilidade atualizado")]
        public void GivenSelecionarAvisibilidadeAtualizado()
        {
            tarefaPage.SelecionarAvisibilidadeAtualizado(JsonBuilder.GetAppSettings("VISIBILIDADE_PROJETO"));
        }

        [StepDefinition(@"selecionar o campo atribuir atualizado")]
        public void GivenSelecionarOCampoAtribuirAtualizado()
        {
            tarefaPage.SelecionarOCampoAtribuirAtualizado(JsonBuilder.GetAppSettings("USER"));
        }

        [StepDefinition(@"selecionar a prioridade atualizado")]
        public void GivenSelecionarAPrioridadeAtualizado()
        {
            tarefaPage.SelecionarAPrioridadeAtualizado(JsonBuilder.GetAppSettings("PRIORIDADE_PROJETO"));
        }

        [StepDefinition(@"selecionar a gravidade atualizado")]
        public void GivenSelecionarAGravidadeAtualizado()
        {
            tarefaPage.SelecionarAGravidadeAtualizado(JsonBuilder.GetAppSettings("GRAVIDADE_PROJETO"));
        }

        [StepDefinition(@"selecionar o campo estado")]
        public void GivenSelecionarOCampoEstado()
        {
            tarefaPage.SelecionarOCampoEstado(JsonBuilder.GetAppSettings("ESTADO_PROJETO_UPDATE"));
        }
        
        [StepDefinition(@"selecionar o campo resolucao")]
        public void GivenSelecionarOCampoResolucao()
        {
            tarefaPage.SelecionarOCampoResolucao(JsonBuilder.GetAppSettings("RESOLUCAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao atualizar informacao")]
        public void WhenClicarNoBotaoAtualizarInformacao()
        {
            tarefaPage.ClicarNoBotaoAtualizarInformacao();
        }

        [Then(@"visualizar a alteracao da tarefa no banco")]
        public void ThenVisualizarAAlteracaoDaTarefaNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"clicar com java script no botao ver tarefas")]
        public void GivenClicarComJavaScriptNoBotaoVerTarefas()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoVerTarefas();
        }

        [StepDefinition(@"clicar com java script no botao atualizar")]
        public void GivenClicarComJavaScriptNoBotaoAtualizar()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoAtualizar();
        }

        [StepDefinition(@"clicar com java script no botao atualizar informacao")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarInformacao()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoAtualizarInformacao();
        }
    }
}
