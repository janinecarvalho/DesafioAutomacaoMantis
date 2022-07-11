using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarCamposPersonalizadosProjetosSteps
    {
        CamposPersonalizadosProjetosPage CamposPersonalizadosProjetosPage;

        public AlterarCamposPersonalizadosProjetosSteps()
        {
            CamposPersonalizadosProjetosPage = new CamposPersonalizadosProjetosPage();
        }
        [StepDefinition(@"clicar no campo personalizado para alterar")]
        public void GivenClicarNoCampoPersonalizadoParaAlterar()
        {
            CamposPersonalizadosProjetosPage.ClicarNoCampoPersonalizadoParaAlterar("Pipeline" + JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"selecionar o tipo")]
        public void GivenSelecionarOTipo()
        {
            CamposPersonalizadosProjetosPage.SelecionarOTipo(JsonBuilder.GetAppSettings("TIPO_CAMPO_PERSONALIZADO"));
        }
        
        [StepDefinition(@"desmarcar o checkbox criar tarefas")]
        public void GivenDesmarcarOCheckboxCriarTarefas()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxCriarTarefas();
        }
        
        [StepDefinition(@"desmarcar o checkbox resolver tarefas")]
        public void GivenDesmarcarOCheckboxResolverTarefas()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxResolverTarefas();
        }
        
        [StepDefinition(@"desmarcar o checkbox fechar tarefas")]
        public void GivenDesmarcarOCheckboxFecharTarefas()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxFecharTarefas();
        }
        
        [StepDefinition(@"desmarcar o checkbox relato")]
        public void GivenDesmarcarOCheckboxRelato()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxRelato();
        }
        
        [StepDefinition(@"desmarcar o checkbox atualizacao")]
        public void GivenDesmarcarOCheckboxAtualizacao()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxAtualizacao();
        }
        
        [StepDefinition(@"desmarcar o checkbox resolucao")]
        public void GivenDesmarcarOCheckboxResolucao()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxResolucao();
        }
        
        [StepDefinition(@"desmarcar o checkbox fechamento")]
        public void GivenDesmarcarOCheckboxFechamento()
        {
            CamposPersonalizadosProjetosPage.DesmarcarOCheckboxFechamento();
        }

        [StepDefinition(@"visualizar a alteracao do campo personalizado no banco")]
        public void ThenVisualizarAAlteracaoDoCampoPersonalizadoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_custom_field_table", "name", "PipelinejanineOLD"));
        }

        [StepDefinition(@"clicar com java script no campo personalizado para alterar")]
        public void GivenClicarComJavaScriptNoCampoPersonalizadoParaAlterar()
        {
            CamposPersonalizadosProjetosPage.ClicarComJavaScriptNoCampoPersonalizadoParaAlterar();
        }
    }
}
