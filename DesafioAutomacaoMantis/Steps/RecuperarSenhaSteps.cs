using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class RecuperarSenhaSteps
    {
        RecuperarSenhaPage recuperarSenhaPage;

        public RecuperarSenhaSteps()
        {
            recuperarSenhaPage = new RecuperarSenhaPage();
        }

        #region Parameters of test
        string textoEsperado = "http://127.0.0.1:8989/login_page.php?return=lost_pwd.php";
        #endregion


        [StepDefinition(@"clicar no botao criar nova conta")]
        public void GivenClicarNoBotaoCriarNovaConta()
        {
            recuperarSenhaPage.ClicarNoBotaoCriarNovaConta();
        }
        
        [StepDefinition(@"clicar no botao perdeu a sua senha")]
        public void GivenClicarNoBotaoPerdeuASuaSenha()
        {
            recuperarSenhaPage.ClicarNoBotaoPerdeuASuaSenha();
        }
        
        [StepDefinition(@"preencher o campo nome de usuario")]
        public void GivenPreencherOCampoNomeDeUsuario()
        {
            recuperarSenhaPage.PreencherOCampoNomeDeUsuario(JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"preencher o campo email")]
        public void GivenPreencherOCampoEmail()
        {
            recuperarSenhaPage.PreencherOCampoEmail(JsonBuilder.GetAppSettings("EMAIL"));
        }
        
        [StepDefinition(@"clicar no botao enviar da tela de recuperacao")]
        public void WhenClicarNoBotaoEnviarDaTelaDeRecuperacao()
        {
            recuperarSenhaPage.ClicarNoBotaoEnviarDaTelaDeRecuperacao();
        }
        
        [StepDefinition(@"visualizar a tela de login")]
        public void ThenVisualizarATelaDeLogin()
        {
            Assert.AreEqual(textoEsperado, recuperarSenhaPage.VisualizarATelaDeLogin());
        }
    }
}
