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
        AlterarCamposPersonalizadosProjetosPage AlterarCamposPersonalizadosProjetosPage;

        public AlterarCamposPersonalizadosProjetosSteps()
        {
            AlterarCamposPersonalizadosProjetosPage = new AlterarCamposPersonalizadosProjetosPage();
        }
        [StepDefinition(@"clicar no campo personalizado para alterar")]
        public void GivenClicarNoCampoPersonalizadoParaAlterar()
        {
            AlterarCamposPersonalizadosProjetosPage.ClicarNoCampoPersonalizadoParaAlterar("Pipeline" + JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"selecionar o tipo")]
        public void GivenSelecionarOTipo()
        {
            AlterarCamposPersonalizadosProjetosPage.SelecionarOTipo(JsonBuilder.GetAppSettings("TIPO_CAMPO_PERSONALIZADO"));
        }
        
        [StepDefinition(@"desmarcar o checkbox criar tarefas")]
        public void GivenDesmarcarOCheckboxCriarTarefas()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxCriarTarefas();
        }
        
        [StepDefinition(@"desmarcar o checkbox resolver tarefas")]
        public void GivenDesmarcarOCheckboxResolverTarefas()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxResolverTarefas();
        }
        
        [StepDefinition(@"desmarcar o checkbox fechar tarefas")]
        public void GivenDesmarcarOCheckboxFecharTarefas()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxFecharTarefas();
        }
        
        [StepDefinition(@"desmarcar o checkbox relato")]
        public void GivenDesmarcarOCheckboxRelato()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxRelato();
        }
        
        [StepDefinition(@"desmarcar o checkbox atualizacao")]
        public void GivenDesmarcarOCheckboxAtualizacao()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxAtualizacao();
        }
        
        [StepDefinition(@"desmarcar o checkbox resolucao")]
        public void GivenDesmarcarOCheckboxResolucao()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxResolucao();
        }
        
        [StepDefinition(@"desmarcar o checkbox fechamento")]
        public void GivenDesmarcarOCheckboxFechamento()
        {
            AlterarCamposPersonalizadosProjetosPage.DesmarcarOCheckboxFechamento();
        }

        [StepDefinition(@"vizualizar a alteracao do campo personalizado no banco")]
        public void ThenVizualizarAAlteracaoDoCampoPersonalizadoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_custom_field_table", "name", "PipelinejanineOLD"));
        }

        [StepDefinition(@"clicar com java script no campo personalizado para alterar")]
        public void GivenClicarComJavaScriptNoCampoPersonalizadoParaAlterar()
        {
            AlterarCamposPersonalizadosProjetosPage.ClicarComJavaScriptNoCampoPersonalizadoParaAlterar();
        }
    }
}
