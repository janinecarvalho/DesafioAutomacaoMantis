using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class RecuperarSenhaPage : PageBase
    {
        #region Mapeamento
        By btnCriarNovaConta = By.XPath("//*[@id='login-box']//*[contains(text(),'criar uma nova conta')]");
        By btnPerdeuSuaSenha = By.XPath("//*[@id='login-box']//*[contains(text(),'Perdeu a sua senha?')]");
        By txtNomeUsuario = By.Id("username");
        By txtEmail = By.Id("email-field");
        By btnEnviar = By.XPath("//*[@value='Enviar']");

        #endregion

        #region Action
        public void ClicarNoBotaoCriarNovaConta()
        {
            Click(btnCriarNovaConta);
        }

        public void ClicarNoBotaoPerdeuASuaSenha()
        {
            Click(btnPerdeuSuaSenha);
        }

        public void PreencherOCampoNomeDeUsuario(string nomeUsuario)
        {
            SendKeys(txtNomeUsuario, nomeUsuario);
        }

        public void PreencherOCampoEmail(string email)
        {
            SendKeys(txtEmail, email);
        }

        public void ClicarNoBotaoEnviarDaTelaDeRecuperacao()
        {
            Click(btnEnviar);
        }

        public string VisualizarATelaDeLogin()
        {
            return GetURL();
        }
        #endregion
    }
}
