using System;
using TechTalk.SpecFlow;
using DesafioAutomacaoMantis.Pages;
using DesafioAutomacaoMantis.Helpers;
using NUnit.Framework;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginpage;

        string userLogado;

        public LoginSteps()
        {
            loginpage = new LoginPage();
        }
        
        [StepDefinition(@"que estou na tela de login")]
        public void GivenQueEstouNaTelaDeLogin()
        {
            loginpage.AcessarPaginaLogin(JsonBuilder.GetAppSettings("BASE_URL"));
        }
        
        [StepDefinition(@"preencher o usuario (.*)")]
        public void GivenPreencherOUsuario(string usuario)
        {
            userLogado = usuario;

            loginpage.PreencherCampoLogin(usuario);
        }
        
        [StepDefinition(@"clicar no botao entrar")]
        public void GivenClicarNoBotaoEntrar()
        {
            if (JsonBuilder.GetAppSettings("LOGIN_INJECTION") == "false")
            {
                loginpage.ClicarNoBotaoEntrar();
            }
            else
            {
                loginpage.ClicarNoBotaoEntrarJavaScript();
            }
        }
        
        [StepDefinition(@"preencher a senha (.*)")]
        public void GivenPreencherASenha(string senha)
        {
            loginpage.PreencherCampoSenha(senha);
        }
        
        [StepDefinition(@"clicar no botao logar")]
        public void WhenClicarNoBotaoEntrar()
        {
            loginpage.ClicarNoBotaoEntrar();
        }
        
        [StepDefinition(@"visualizo o painel do usuario")]
        public void ThenVisualizoOPainelDoUsuario()
        {
            Assert.AreEqual(userLogado, loginpage.VisualizarPainelLogado());
        }

        [StepDefinition(@"preencher com java script o usuario (.*)")]
        public void GivenPreencherComJavaScriptOUsuario(string usuario)
        {
            userLogado = usuario;

            loginpage.PreencherCampoLoginJavaScript(usuario);
        }

        [StepDefinition(@"clicar com java script no botao entrar")]
        public void GivenClicarComJavaScriptNoBotaoEntrar()
        {
            loginpage.ClicarNoBotaoEntrarJavaScript();
        }

        [StepDefinition(@"preencher com java script a senha (.*)")]
        public void GivenPreencherComJavaScriptASenha(string senha)
        {
            loginpage.PreencherCampoSenhaJavaScript(senha);
        }

        [StepDefinition(@"clicar com java script no botao logar")]
        public void WhenClicarComJavaScriptNoBotaoLogar()
        {
            loginpage.ClicarNoBotaoEntrarJavaScript();
        }

    }
}
