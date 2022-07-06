using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;

namespace DesafioAutomacaoMantis.Pages
{
    public class LoginPage:PageBase
    {
        #region Mapeamento
        By txtLogin = By.Id("username");
        By txtSenha = By.Id("password");
        By btnEntrar = By.CssSelector("input[type='submit']");
        By painelUsuario = By.CssSelector(".user-info");
        #endregion

        #region Actions
        
        public void AcessarPaginaLogin(string url)
        {
            NavegarAteURL(url);
        }
        
        public void PreencherCampoLogin(string usuario)
        {
            SendKeys(txtLogin, usuario);
        }
        
        public void PreencherCampoLoginJavaScript(string usuario)
        {
            SendKeysJavaScript(txtLogin, usuario);
        }
        
        public void PreencherCampoSenha(string senha)
        {
            SendKeys(txtSenha, senha);
        }
        
        public void PreencherCampoSenhaJavaScript(string senha)
        {
            SendKeysJavaScript(txtSenha, senha);
        }
        
        public void ClicarNoBotaoEntrar()
        {
            Click(btnEntrar);
        }
        
        public void ClicarNoBotaoEntrarJavaScript()
        {
            ClickJavaScript(btnEntrar);
        }
        
        public string VisualizarPainelLogado()
        {
            return GetText(painelUsuario);
        }
        #endregion
    }
}
