using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ConvidarUsuarioSteps
    {
        ConvidarUsuarioPage convidarUsuarioPage;

        public ConvidarUsuarioSteps()
        {
            convidarUsuarioPage = new ConvidarUsuarioPage();
        }

        [StepDefinition(@"clicar no botao convidar usuarios")]
        public void GivenClicarNoBotaoConvidarUsuarios()
        {
            convidarUsuarioPage.ClicarNoBotaoConvidarUsuarios();
        }
        
        [StepDefinition(@"preencher o campo nome do usuario")]
        public void GivenPreencherOCampoNomeDoUsuario()
        {
            convidarUsuarioPage.PreencherOCampoNomeDoUsuario(JsonBuilder.GetAppSettings("USER") + "Novo");
        }
        
        [StepDefinition(@"preencher o campo nome verdadeiro")]
        public void GivenPreencherOCampoNomeVerdadeiro()
        {
            convidarUsuarioPage.PreencherOCampoNomeVerdadeiro("NovoUsuario");
        }

        [StepDefinition(@"preencher o campo email do usuario")]
        public void GivenPreencherOCampoEmailDoUsuario()
        {
            convidarUsuarioPage.PreencherOCampoEmailDoUsuario("Novo" + JsonBuilder.GetAppSettings("EMAIL"));
        }

        [StepDefinition(@"clicar no botao criar usuario")]
        public void WhenClicarNoBotaoCriarUsuario()
        {
            convidarUsuarioPage.ClicarNoBotaoCriarUsuario();
        }

        [StepDefinition(@"clicar com java script no botao convidar usuarios")]
        public void GivenClicarComJavaScriptNoBotaoConvidarUsuarios()
        {
            convidarUsuarioPage.ClicarComJavaScriptNoBotaoConvidarUsuarios();
        }

        [StepDefinition(@"preencher com java script o campo nome do usuario")]
        public void GivenPreencherComJavaScriptOCampoNomeDoUsuario()
        {
            convidarUsuarioPage.PreencherComJavaScriptOCampoNomeDoUsuario(JsonBuilder.GetAppSettings("USER") + "Novo");
        }

        [StepDefinition(@"preencher com java script o campo nome verdadeiro")]
        public void GivenPreencherComJavaScriptOCampoNomeVerdadeiro()
        {
            convidarUsuarioPage.PreencherComJavaScriptOCampoNomeVerdadeiro("NovoUsuario");
        }

        [StepDefinition(@"preencher com java script o campo email do usuario")]
        public void GivenPreencherComJavaScriptOCampoEmailDoUsuario()
        {
            convidarUsuarioPage.PreencherComJavaScriptOCampoEmailDoUsuario("Novo" + JsonBuilder.GetAppSettings("EMAIL"));
        }

        [StepDefinition(@"clicar com java script no botao criar usuario")]
        public void WhenClicarComJavaScriptNoBotaoCriarUsuario()
        {
            convidarUsuarioPage.ClicarComJavaScriptNoBotaoCriarUsuario();
        }

        [StepDefinition(@"visualizar a inclusao do usuario no banco")]
        public void ThenVisualizarAInclusaoDoUsuarioNoBanco()
        {
            Assert.IsTrue(convidarUsuarioPage.VizualizarAInclusaoDoUsuarioNoBanco(JsonBuilder.GetAppSettings("USER") + "Novo"));
        }
    }
}
