using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CadastrarMarcadorProjetosSteps
    {
        CadastrarMarcadorProjetosPage cadastrarMarcadorProjetosPage;
        public CadastrarMarcadorProjetosSteps()
        {
            cadastrarMarcadorProjetosPage = new CadastrarMarcadorProjetosPage();
        }
        [StepDefinition(@"clicar na aba gerenciar marcadores")]
        public void GivenClicarNaAbaGerenciarMarcadores()
        {
            cadastrarMarcadorProjetosPage.ClicarAbaMarcadores();
        }
        
        [StepDefinition(@"preencher o campo nome do marcador")]
        public void GivenPreencherOCampoNomeDoMarcador()
        {
            cadastrarMarcadorProjetosPage.PreencherCampoNomeMarcador(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }
        
        [StepDefinition(@"preencher o campo descricao do marcador")]
        public void GivenPreencherOCampoDescricaoDoMarcador()
        {
            cadastrarMarcadorProjetosPage.PreencherCampoDescricaoMarcador(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR"));
        }
        
        [StepDefinition(@"clicar no botao criar marcador")]
        public void WhenClicarNoBotaoCriarMarcador()
        {
            cadastrarMarcadorProjetosPage.ClicarBotaoCriarMarcador();
        }

        [StepDefinition(@"visualizar a inclusao do marcador")]
        public void ThenVisualizarAInclusaoDoMarcador()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_tag_table", "name", "DesafioB2"));
        }

        [StepDefinition(@"clicar com java script  na aba gerenciar marcadores")]
        public void GivenClicarComJavaScriptNaAbaGerenciarMarcadores()
        {
            cadastrarMarcadorProjetosPage.ClicarComJavaScriptNaAbaGerenciarMarcadores();
        }

        [StepDefinition(@"preencher com java script o campo nome do marcador")]
        public void GivenPreencherComJavaScriptOCampoNomeDoMarcador()
        {
            cadastrarMarcadorProjetosPage.PreencherComJavaScriptOCampoNomeDoMarcador(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }

        [StepDefinition(@"preencher com java script o campo descricao do marcador")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoMarcador()
        {
            cadastrarMarcadorProjetosPage.PreencherComJavaScriptOCampoDescricaoDoMarcador(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR"));
        }

        [StepDefinition(@"clicar com java script no botao criar marcador")]
        public void WhenClicarComJavaScriptNoBotaoCriarMarcador()
        {
            cadastrarMarcadorProjetosPage.ClicarComJavaScriptNoBotaoCriarMarcador();
        }
    }
}
