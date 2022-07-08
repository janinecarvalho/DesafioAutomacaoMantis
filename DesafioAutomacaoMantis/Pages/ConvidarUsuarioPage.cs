using DesafioAutomacaoMantis.Bases;
using DesafioAutomacaoMantis.DataBaseSteps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class ConvidarUsuarioPage : PageBase
    {
        #region Mapeamento
        By btnConvidarUsuario = By.XPath("//*[@id='navbar-container']//*[contains(text(),' Convidar Usuários')]");
        By txtNomeUsuario = By.Id("user-username");
        By txtNomeVerdadeiro = By.Id("user-realname");
        By txtEmail = By.Id("email-field");
        By btnCriarUsuario = By.XPath("//*[@value='Criar Usuário']");

        #endregion

        #region Action
        public void ClicarNoBotaoConvidarUsuarios()
        {
            Click(btnConvidarUsuario);
        }

        public void PreencherOCampoNomeDoUsuario(string nomeUsuario)
        {
            SendKeys(txtNomeUsuario, nomeUsuario);
        }

        public void PreencherOCampoNomeVerdadeiro(string nomeVerdadeiro)
        {
            SendKeys(txtNomeVerdadeiro, nomeVerdadeiro);
        }
        public void PreencherOCampoEmailDoUsuario(string emailUsuario)
        {
            SendKeys(txtEmail,emailUsuario);
        }
        public void ClicarNoBotaoCriarUsuario()
        {
            Click(btnCriarUsuario);
        }

        public void ClicarComJavaScriptNoBotaoConvidarUsuarios()
        {
            ClickJavaScript(btnConvidarUsuario);
        }

        public void PreencherComJavaScriptOCampoNomeDoUsuario(string nomeUsuario)
        {
            SendKeysJavaScript(txtNomeUsuario, nomeUsuario);
        }

        public void PreencherComJavaScriptOCampoNomeVerdadeiro(string nomeVerdadeiro)
        {
            SendKeysJavaScript(txtNomeVerdadeiro, nomeVerdadeiro);
        }

        public void PreencherComJavaScriptOCampoEmailDoUsuario(string emailUsuario)
        {
            SendKeysJavaScript(txtEmail, emailUsuario);
        }

        public void ClicarComJavaScriptNoBotaoCriarUsuario()
        {
            ClickJavaScript(btnCriarUsuario);
        }

        public bool VizualizarAInclusaoDoUsuarioNoBanco(string usuario)
        {
            return ManageDBSteps.ValidarInclusaoUsuarioDB(usuario);
        }
        #endregion
    }
}
