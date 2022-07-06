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

        CadastrarPerfisGlobaisPage cadastrarPerfisGlobaisPage;
        public CadastrarPerfisGlobaisSteps()
        {
            cadastrarPerfisGlobaisPage = new CadastrarPerfisGlobaisPage();
        }
        [StepDefinition(@"clicar na aba gerenciar perfis globais")]
        public void GivenClicarNaAbaGerenciarPerfisGlobais()
        {
            cadastrarPerfisGlobaisPage.ClicarNaAbaGerenciarPerfisGlobais();
        }
        
        [StepDefinition(@"preencher o campo plataforma")]
        public void GivenPreencherOCampoPlataforma()
        {
            cadastrarPerfisGlobaisPage.PreencherOCampoPlataforma(JsonBuilder.GetAppSettings("PLATAFORMA"));
        }
        
        [StepDefinition(@"preencher o campo so")]
        public void GivenPreencherOCampoSo()
        {
            cadastrarPerfisGlobaisPage.PreencherOCampoSo(JsonBuilder.GetAppSettings("OS"));
        }
        
        [StepDefinition(@"preencher o campo versao so")]
        public void GivenPreencherOCampoVersaoSo()
        {
            cadastrarPerfisGlobaisPage.PreencherOCampoVersaoSo(JsonBuilder.GetAppSettings("VERSAO_OS"));
        }
        
        [StepDefinition(@"preencher o campo descricao adicional")]
        public void GivenPreencherOCampoDescricaoAdicional()
        {
            cadastrarPerfisGlobaisPage.PreencherOCampoDescricaoAdicional(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao adicionar perfil")]
        public void WhenClicarNoBotaoAdicionarPerfil()
        {
            cadastrarPerfisGlobaisPage.ClicarNoBotaoAdicionarPerfil();
        }

        [StepDefinition(@"vizualizar a inclusao de perfil")]
        public void ThenVizualizarAInclusaoDePerfil()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_user_profile_table", "platform", "Web"));
        }

        [StepDefinition(@"clicar com java scrip na aba gerenciar perfis globais")]
        public void GivenClicarComJavaScripNaAbaGerenciarPerfisGlobais()
        {
            cadastrarPerfisGlobaisPage.ClicarComJavaScripNaAbaGerenciarPerfisGlobais();
        }

        [StepDefinition(@"preencher com java scrip o campo plataforma")]
        public void GivenPreencherComJavaScripOCampoPlataforma()
        {
            cadastrarPerfisGlobaisPage.PreencherComJavaScripOCampoPlataforma(JsonBuilder.GetAppSettings("PLATAFORMA"));
        }

        [StepDefinition(@"preencher com java scrip o campo so")]
        public void GivenPreencherComJavaScripOCampoSo()
        {
            cadastrarPerfisGlobaisPage.PreencherComJavaScripOCampoSo(JsonBuilder.GetAppSettings("OS"));
        }

        [StepDefinition(@"preencher com java scrip o campo versao so")]
        public void GivenPreencherComJavaScripOCampoVersaoSo()
        {
            cadastrarPerfisGlobaisPage.PreencherComJavaScripOCampoVersaoSo(JsonBuilder.GetAppSettings("VERSAO_OS"));
        }

        [StepDefinition(@"preencher com java scrip o campo descricao adicional")]
        public void GivenPreencherComJavaScripOCampoDescricaoAdicional()
        {
            cadastrarPerfisGlobaisPage.PreencherComJavaScripOCampoDescricaoAdicional(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }

        [StepDefinition(@"clicar com java scrip no botao adicionar perfil")]
        public void WhenClicarComJavaScripNoBotaoAdicionarPerfil()
        {
            cadastrarPerfisGlobaisPage.ClicarComJavaScripNoBotaoAdicionarPerfil();
        }
    }
}
