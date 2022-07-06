using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarMarcadorProjetosSteps
    {
        AlterarMarcadorProjetosPage alterarMarcadorProjetosPage;
        public AlterarMarcadorProjetosSteps()
        {
            alterarMarcadorProjetosPage = new AlterarMarcadorProjetosPage();
        }
        [StepDefinition(@"clicar no marcador")]
        public void GivenClicarNoMarcador()
        {
            alterarMarcadorProjetosPage.ClicarMarcadorDisplayed();
        }
        
        [StepDefinition(@"clicar no botao atualizar marcador")]
        public void GivenClicarNoBotaoAtualizarMarcador()
        {
            alterarMarcadorProjetosPage.ClicarBotaoAtualizarMarcador();
        }
        
        [StepDefinition(@"preencher o campo nome do marcador atualizado")]
        public void GivenPreencherOCampoNomeDoMarcadorAtualizado()
        {
            alterarMarcadorProjetosPage.PreencherNomeMarcador(JsonBuilder.GetAppSettings("NOME_MARCADOR") + " [Atualizado]");
        }
        
        [StepDefinition(@"selecionar o criador atualizado")]
        public void GivenSelecionarOCriadorAtualizado()
        {
            alterarMarcadorProjetosPage.SelecionarCriadorMarcador(JsonBuilder.GetAppSettings("CRIADOR_MARCADOR"));
        }
        
        [StepDefinition(@"preencher o campo descricao do marcador atualizado")]
        public void GivenPreencherOCampoDescricaoDoMarcadorAtualizado()
        {
            alterarMarcadorProjetosPage.PreencherDescricaoMarcador(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR") + " [Atualizado]");
        }

        [StepDefinition(@"visualizar a alteracao do marcador no banco")]
        public void ThenVisualizarAAlteracaoDoMarcadorNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_tag_table", "name", "DesafioB2 [Atualizado]"));
        }

        [StepDefinition(@"clicar com java script no marcador")]
        public void GivenClicarComJavaScriptNoMarcador()
        {
            alterarMarcadorProjetosPage.ClicarComJavaScriptNoMarcador();
        }

        [StepDefinition(@"clicar com java script no botao atualizar marcador")]
        public void GivenClicarComJavaScriptNoBotaoAtualizarMarcador()
        {
            alterarMarcadorProjetosPage.ClicarComJavaScriptNoBotaoAtualizarMarcador();
        }

        [StepDefinition(@"preencher com java script o campo nome do marcador atualizado")]
        public void GivenPreencherComJavaScriptOCampoNomeDoMarcadorAtualizado()
        {
            alterarMarcadorProjetosPage.PreencherComJavaScriptOCampoNomeDoMarcadorAtualizado(JsonBuilder.GetAppSettings("NOME_MARCADOR") + " [Atualizado]");
        }

        [StepDefinition(@"preencher com java script o campo descricao do marcador atualizado")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoMarcadorAtualizado()
        {
            alterarMarcadorProjetosPage.PreencherComJavaScriptOCampoDescricaoDoMarcadorAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR") + " [Atualizado]");
        }
    }
}
