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
        MarcadorProjetosPage marcadorProjetosPage;
        public AlterarMarcadorProjetosSteps()
        {
            marcadorProjetosPage = new MarcadorProjetosPage();
        }
        [StepDefinition(@"clicar no marcador")]
        public void GivenClicarNoMarcador()
        {
            marcadorProjetosPage.ClicarMarcadorDisplayed();
        }
        
        [StepDefinition(@"clicar no botao atualizar marcador")]
        public void GivenClicarNoBotaoAtualizarMarcador()
        {
            marcadorProjetosPage.ClicarBotaoAtualizarMarcador();
        }
        
        [StepDefinition(@"preencher o campo nome do marcador atualizado")]
        public void GivenPreencherOCampoNomeDoMarcadorAtualizado()
        {
            marcadorProjetosPage.PreencherNomeMarcador(JsonBuilder.GetAppSettings("NOME_MARCADOR") + " [Atualizado]");
        }
        
        [StepDefinition(@"selecionar o criador atualizado")]
        public void GivenSelecionarOCriadorAtualizado()
        {
            marcadorProjetosPage.SelecionarCriadorMarcador(JsonBuilder.GetAppSettings("CRIADOR_MARCADOR"));
        }
        
        [StepDefinition(@"preencher o campo descricao do marcador atualizado")]
        public void GivenPreencherOCampoDescricaoDoMarcadorAtualizado()
        {
            marcadorProjetosPage.PreencherDescricaoMarcador(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR") + " [Atualizado]");
        }

        [StepDefinition(@"visualizar a alteracao do marcador no banco")]
        public void ThenVisualizarAAlteracaoDoMarcadorNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_tag_table", "name", "DesafioB2 [Atualizado]"));
        }

        [StepDefinition(@"clicar com java script no marcador")]
        public void GivenClicarComJavaScriptNoMarcador()
        {
            marcadorProjetosPage.ClicarComJavaScriptNoMarcador();
        }

        [StepDefinition(@"clicar com java script no botao atualizar marcador")]
        public void GivenClicarComJavaScriptNoBotaoAtualizarMarcador()
        {
            marcadorProjetosPage.ClicarComJavaScriptNoBotaoAtualizarMarcador();
        }

        [StepDefinition(@"preencher com java script o campo nome do marcador atualizado")]
        public void GivenPreencherComJavaScriptOCampoNomeDoMarcadorAtualizado()
        {
            marcadorProjetosPage.PreencherComJavaScriptOCampoNomeDoMarcadorAtualizado(JsonBuilder.GetAppSettings("NOME_MARCADOR") + " [Atualizado]");
        }

        [StepDefinition(@"preencher com java script o campo descricao do marcador atualizado")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoMarcadorAtualizado()
        {
            marcadorProjetosPage.PreencherComJavaScriptOCampoDescricaoDoMarcadorAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_MARCADOR") + " [Atualizado]");
        }
    }
}
