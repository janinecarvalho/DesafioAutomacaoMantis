using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class AlterarPerfisGlobaisSteps
    {
        PerfisGlobaisPage perfisGlobaisPage;
        public AlterarPerfisGlobaisSteps()
        {
            perfisGlobaisPage = new PerfisGlobaisPage();
        }
        [StepDefinition(@"clicar no radiobox editar perfil")]
        public void GivenClicarNoRadioboxEditarPerfil()
        {
            perfisGlobaisPage.ClicarNoRadioboxEditarPerfil();
        }
        
        [StepDefinition(@"selecionar o perfil")]
        public void GivenSelecionarOPerfil()
        {
            perfisGlobaisPage.SelecionarOPerfil(JsonBuilder.GetAppSettings("PERFIL_OS"));
        }
        
        [StepDefinition(@"clicar no botao enviar")]
        public void GivenClicarNoBotaoEnviar()
        {
            perfisGlobaisPage.ClicarNoBotaoEnviar();
        }
        
        [StepDefinition(@"preencher o campo plataforma atualizado")]
        public void GivenPreencherOCampoPlataformaAtualizado()
        {
            perfisGlobaisPage.PreencherOCampoPlataformaAtualizado(JsonBuilder.GetAppSettings("PLATAFORMA_UPDATE"));
        }
        
        [StepDefinition(@"preencher o campo so atualizado")]
        public void GivenPreencherOCampoSoAtualizado()
        {
            perfisGlobaisPage.PreencherOCampoSoAtualizado(JsonBuilder.GetAppSettings("OS_UPDATE"));
        }
        
        [StepDefinition(@"preencher o campo versao so atualizado")]
        public void GivenPreencherOCampoVersaoSoAtualizado()
        {
            perfisGlobaisPage.PreencherOCampoVersaoSoAtualizado(JsonBuilder.GetAppSettings("VERSAO_OS_UPDATE"));
        }
        
        [StepDefinition(@"preencher o campo descricao adicional atualizado")]
        public void GivenPreencherOCampoDescricaoAdicionalAtualizado()
        {
            perfisGlobaisPage.PreencherOCampoDescricaoAdicionalAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO") + " [Atualizado]");
        }
        
        [StepDefinition(@"clicar no botao atualizar perfil")]
        public void WhenClicarNoBotaoAtualizarPerfil()
        {
            perfisGlobaisPage.ClicarNoBotaoAtualizarPerfil();
        }

        [StepDefinition(@"visualizar a alteracao do perfil no banco")]
        public void ThenVisualizarAAlteracaoDoPerfilNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_user_profile_table", "description", "Projeto Desafio Automacao Base2 - Selenium Specflow .NetCore. [Atualizado]"));
        }

        [StepDefinition(@"clicar com java script no botao enviar")]
        public void GivenClicarComJavaScriptNoBotaoEnviar()
        {
            perfisGlobaisPage.ClicarComJavaScriptNoBotaoEnviar();
        }

        [StepDefinition(@"preencher com java script o campo plataforma atualizado")]
        public void GivenPreencherComJavaScriptOCampoPlataformaAtualizado()
        {
            perfisGlobaisPage.PreencherComJavaScriptOCampoPlataformaAtualizado(JsonBuilder.GetAppSettings("PLATAFORMA_UPDATE"));
        }

        [StepDefinition(@"preencher com java script o campo so atualizado")]
        public void GivenPreencherComJavaScriptOCampoSoAtualizado()
        {
            perfisGlobaisPage.PreencherComJavaScriptOCampoSoAtualizado(JsonBuilder.GetAppSettings("OS_UPDATE")); 
        }

        [StepDefinition(@"preencher com java script o campo versao so atualizado")]
        public void GivenPreencherComJavaScriptOCampoVersaoSoAtualizado()
        {
            perfisGlobaisPage.PreencherComJavaScriptOCampoVersaoSoAtualizado(JsonBuilder.GetAppSettings("VERSAO_OS_UPDATE"));
        }

        [StepDefinition(@"preencher com java script o campo descricao adicional atualizado")]
        public void GivenPreencherComJavaScriptOCampoDescricaoAdicionalAtualizado()
        {
            perfisGlobaisPage.PreencherComJavaScriptOCampoDescricaoAdicionalAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO") + " [Atualizado]");
        }

        [StepDefinition(@"clicar com java script no botao atualizar perfil")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarPerfil()
        {
            perfisGlobaisPage.ClicarComJavaScriptNoBotaoAtualizarPerfil();
        }
    }
}
