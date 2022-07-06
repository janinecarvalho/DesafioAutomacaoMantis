using DesafioAutomacaoMantis.Pages;
using System;

namespace DesafioAutomacaoMantis.Flows
{
    public class LoginFlow
    {
        LoginPage loginPage;
        public LoginFlow()
        {
            loginPage = new LoginPage();
        }
        
        public void RealizarLoginComSucesso(string user, string password, string url)
        {
            loginPage.AcessarPaginaLogin(url);
            loginPage.PreencherCampoLogin(user);
            loginPage.ClicarNoBotaoEntrar();
            loginPage.PreencherCampoSenha(password);
            loginPage.ClicarNoBotaoEntrar();
        }
    }
}
