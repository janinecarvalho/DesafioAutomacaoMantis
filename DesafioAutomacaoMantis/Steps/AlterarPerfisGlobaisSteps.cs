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
        AlterarPerfisGlobaisPage alterarPerfisGlobaisPage;
        public AlterarPerfisGlobaisSteps()
        {
            alterarPerfisGlobaisPage = new AlterarPerfisGlobaisPage();
        }
        [StepDefinition(@"clicar no radiobox editar perfil")]
        public void GivenClicarNoRadioboxEditarPerfil()
        {
            alterarPerfisGlobaisPage.ClicarNoRadioboxEditarPerfil();
        }
        
        [StepDefinition(@"selecionar o perfil")]
        public void GivenSelecionarOPerfil()
        {
            alterarPerfisGlobaisPage.SelecionarOPerfil(JsonBuilder.GetAppSettings("PERFIL_OS"));
        }
        
        [StepDefinition(@"clicar no botao enviar")]
        public void GivenClicarNoBotaoEnviar()
        {
            alterarPerfisGlobaisPage.ClicarNoBotaoEnviar();
        }
        
        [StepDefinition(@"preencher o campo plataforma atualizado")]
        public void GivenPreencherOCampoPlataformaAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherOCampoPlataformaAtualizado(JsonBuilder.GetAppSettings("PLATAFORMA_UPDATE"));
        }
        
        [StepDefinition(@"preencher o campo so atualizado")]
        public void GivenPreencherOCampoSoAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherOCampoSoAtualizado(JsonBuilder.GetAppSettings("OS_UPDATE"));
        }
        
        [StepDefinition(@"preencher o campo versao so atualizado")]
        public void GivenPreencherOCampoVersaoSoAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherOCampoVersaoSoAtualizado(JsonBuilder.GetAppSettings("VERSAO_OS_UPDATE"));
        }
        
        [StepDefinition(@"preencher o campo descricao adicional atualizado")]
        public void GivenPreencherOCampoDescricaoAdicionalAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherOCampoDescricaoAdicionalAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO") + " [Atualizado]");
        }
        
        [StepDefinition(@"clicar no botao atualizar perfil")]
        public void WhenClicarNoBotaoAtualizarPerfil()
        {
            alterarPerfisGlobaisPage.ClicarNoBotaoAtualizarPerfil();
        }

        [StepDefinition(@"visualizar a alteracao do perfil no banco")]
        public void ThenVisualizarAAlteracaoDoPerfilNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_user_profile_table", "description", "Projeto Desafio Automacao Base2 - Selenium Specflow .NetCore. [Atualizado]"));
        }

        [StepDefinition(@"clicar com java script no botao enviar")]
        public void GivenClicarComJavaScriptNoBotaoEnviar()
        {
            alterarPerfisGlobaisPage.ClicarComJavaScriptNoBotaoEnviar();
        }

        [StepDefinition(@"preencher com java script o campo plataforma atualizado")]
        public void GivenPreencherComJavaScriptOCampoPlataformaAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherComJavaScriptOCampoPlataformaAtualizado(JsonBuilder.GetAppSettings("PLATAFORMA_UPDATE"));
        }

        [StepDefinition(@"preencher com java script o campo so atualizado")]
        public void GivenPreencherComJavaScriptOCampoSoAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherComJavaScriptOCampoSoAtualizado(JsonBuilder.GetAppSettings("OS_UPDATE")); 
        }

        [StepDefinition(@"preencher com java script o campo versao so atualizado")]
        public void GivenPreencherComJavaScriptOCampoVersaoSoAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherComJavaScriptOCampoVersaoSoAtualizado(JsonBuilder.GetAppSettings("VERSAO_OS_UPDATE"));
        }

        [StepDefinition(@"preencher com java script o campo descricao adicional atualizado")]
        public void GivenPreencherComJavaScriptOCampoDescricaoAdicionalAtualizado()
        {
            alterarPerfisGlobaisPage.PreencherComJavaScriptOCampoDescricaoAdicionalAtualizado(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO") + " [Atualizado]");
        }

        [StepDefinition(@"clicar com java script no botao atualizar perfil")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarPerfil()
        {
            alterarPerfisGlobaisPage.ClicarComJavaScriptNoBotaoAtualizarPerfil();
        }
    }
}
