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
        MarcadorProjetosPage marcadorProjetosPage;
        public CadastrarMarcadorProjetosSteps()
        {
            marcadorProjetosPage = new MarcadorProjetosPage();
        }
        [StepDefinition(@"clicar na aba gerenciar marcadores")]
        public void GivenClicarNaAbaGerenciarMarcadores()
        {
            marcadorProjetosPage.ClicarAbaMarcadores();
        }
        
        [StepDefinition(@"preencher o campo nome do marcador")]
        public void GivenPreencherOCampoNomeDoMarcador()
        {
            marcadorProjetosPage.PreencherCampoNomeMarcador(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }
        
        [StepDefinition(@"preencher o campo descricao do marcador")]
        public void GivenPreencherOCampoDescricaoDoMarcador()
        {
            marcadorProjetosPage.PreencherCampoDescricaoMarcador(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR"));
        }
        
        [StepDefinition(@"clicar no botao criar marcador")]
        public void WhenClicarNoBotaoCriarMarcador()
        {
            marcadorProjetosPage.ClicarBotaoCriarMarcador();
        }

        [StepDefinition(@"visualizar a inclusao do marcador")]
        public void ThenVisualizarAInclusaoDoMarcador()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_tag_table", "name", "DesafioB2"));
        }

        [StepDefinition(@"clicar com java script  na aba gerenciar marcadores")]
        public void GivenClicarComJavaScriptNaAbaGerenciarMarcadores()
        {
            marcadorProjetosPage.ClicarComJavaScriptNaAbaGerenciarMarcadores();
        }

        [StepDefinition(@"preencher com java script o campo nome do marcador")]
        public void GivenPreencherComJavaScriptOCampoNomeDoMarcador()
        {
            marcadorProjetosPage.PreencherComJavaScriptOCampoNomeDoMarcador(JsonBuilder.GetAppSettings("NOME_MARCADOR"));
        }

        [StepDefinition(@"preencher com java script o campo descricao do marcador")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoMarcador()
        {
            marcadorProjetosPage.PreencherComJavaScriptOCampoDescricaoDoMarcador(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR"));
        }

        [StepDefinition(@"clicar com java script no botao criar marcador")]
        public void WhenClicarComJavaScriptNoBotaoCriarMarcador()
        {
            marcadorProjetosPage.ClicarComJavaScriptNoBotaoCriarMarcador();
        }
    }
}
