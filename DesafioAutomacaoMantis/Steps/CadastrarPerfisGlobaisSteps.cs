using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CadastrarPerfisGlobaisSteps
    {

        PerfisGlobaisPage perfisGlobaisPage;
        public CadastrarPerfisGlobaisSteps()
        {
            perfisGlobaisPage = new PerfisGlobaisPage();
        }

        #region Parameters of test
        string tabela = "mantis_user_profile_table";
        string coluna = "platform";
        string textoEsperado = "Web";
        #endregion

        [StepDefinition(@"clicar na aba gerenciar perfis globais")]
        public void GivenClicarNaAbaGerenciarPerfisGlobais()
        {
            perfisGlobaisPage.ClicarNaAbaGerenciarPerfisGlobais();
        }
        
        [StepDefinition(@"preencher o campo plataforma")]
        public void GivenPreencherOCampoPlataforma()
        {
            perfisGlobaisPage.PreencherOCampoPlataforma(JsonBuilder.GetAppSettings("PLATAFORMA"));
        }
        
        [StepDefinition(@"preencher o campo so")]
        public void GivenPreencherOCampoSo()
        {
            perfisGlobaisPage.PreencherOCampoSo(JsonBuilder.GetAppSettings("OS"));
        }
        
        [StepDefinition(@"preencher o campo versao so")]
        public void GivenPreencherOCampoVersaoSo()
        {
            perfisGlobaisPage.PreencherOCampoVersaoSo(JsonBuilder.GetAppSettings("VERSAO_OS"));
        }
        
        [StepDefinition(@"preencher o campo descricao adicional")]
        public void GivenPreencherOCampoDescricaoAdicional()
        {
            perfisGlobaisPage.PreencherOCampoDescricaoAdicional(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao adicionar perfil")]
        public void WhenClicarNoBotaoAdicionarPerfil()
        {
            perfisGlobaisPage.ClicarNoBotaoAdicionarPerfil();
        }

        [StepDefinition(@"visualizar a inclusao de perfil")]
        public void ThenVisualizarAInclusaoDePerfil()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"clicar com java scrip na aba gerenciar perfis globais")]
        public void GivenClicarComJavaScripNaAbaGerenciarPerfisGlobais()
        {
            perfisGlobaisPage.ClicarComJavaScripNaAbaGerenciarPerfisGlobais();
        }

        [StepDefinition(@"preencher com java scrip o campo plataforma")]
        public void GivenPreencherComJavaScripOCampoPlataforma()
        {
            perfisGlobaisPage.PreencherComJavaScripOCampoPlataforma(JsonBuilder.GetAppSettings("PLATAFORMA"));
        }

        [StepDefinition(@"preencher com java scrip o campo so")]
        public void GivenPreencherComJavaScripOCampoSo()
        {
            perfisGlobaisPage.PreencherComJavaScripOCampoSo(JsonBuilder.GetAppSettings("OS"));
        }

        [StepDefinition(@"preencher com java scrip o campo versao so")]
        public void GivenPreencherComJavaScripOCampoVersaoSo()
        {
            perfisGlobaisPage.PreencherComJavaScripOCampoVersaoSo(JsonBuilder.GetAppSettings("VERSAO_OS"));
        }

        [StepDefinition(@"preencher com java scrip o campo descricao adicional")]
        public void GivenPreencherComJavaScripOCampoDescricaoAdicional()
        {
            perfisGlobaisPage.PreencherComJavaScripOCampoDescricaoAdicional(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }

        [StepDefinition(@"clicar com java scrip no botao adicionar perfil")]
        public void WhenClicarComJavaScripNoBotaoAdicionarPerfil()
        {
            perfisGlobaisPage.ClicarComJavaScripNoBotaoAdicionarPerfil();
        }
    }
}
