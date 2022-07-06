using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class AlterarPerfisGlobaisPage : PageBase
    {
        #region Mapeamento
        By radioEditarPerfil = By.Id("action-edit");
        By comboPerfil = By.Id("select-profile");
        By txtPlataforma = By.Name("platform");
        By txtOS = By.Name("os");
        By txtVersaoOs = By.Name("os_build");
        By areaDescricaoAdicional = By.Name("description");
        By btnEnviar = By.CssSelector("input[value='Enviar']");
        By btnAtualizarPerfil = By.CssSelector("input[value='Atualizar Perfil']");

        #endregion

        #region Action
        public void ClicarNoRadioboxEditarPerfil()
        {
            ClickCheckBoxAndRadioBoxJavaScript(radioEditarPerfil);
        }
        public void SelecionarOPerfil(string perfil)
        {
            ComboBoxSelectByVisibleText(comboPerfil, perfil);
        }
        public void ClicarNoBotaoEnviar()
        {
            Click(btnEnviar);
        }
        public void PreencherOCampoPlataformaAtualizado(string plataforma)
        {
            ClearAndSendKeys(txtPlataforma, plataforma);
        }
        public void PreencherOCampoSoAtualizado(string so)
        {
            ClearAndSendKeys(txtOS, so);
        }
        public void PreencherOCampoVersaoSoAtualizado(string versaoSo)
        {
            ClearAndSendKeys(txtVersaoOs, versaoSo);
        }
        public void PreencherOCampoDescricaoAdicionalAtualizado(string descricao)
        {
            ClearAndSendKeys(areaDescricaoAdicional, descricao);
        }
        public void ClicarNoBotaoAtualizarPerfil()
        {
            Click(btnAtualizarPerfil);
        }
        public void ClicarComJavaScriptNoBotaoEnviar()
        {
            ClickJavaScript(btnEnviar);
        }

        public void PreencherComJavaScriptOCampoPlataformaAtualizado(string plataforma)
        {
            ClearAndSendKeysJavaScript(txtPlataforma, plataforma);
        }

        public void PreencherComJavaScriptOCampoSoAtualizado(string so)
        {
            ClearAndSendKeysJavaScript(txtOS, so);
        }

        public void PreencherComJavaScriptOCampoVersaoSoAtualizado(string versaoSo)
        {
            ClearAndSendKeysJavaScript(txtVersaoOs, versaoSo);
        }

        public void PreencherComJavaScriptOCampoDescricaoAdicionalAtualizado(string descricao)
        {
            ClearAndSendKeysJavaScript(areaDescricaoAdicional, descricao);
        }

        public void ClicarComJavaScriptNoBotaoAtualizarPerfil()
        {
            ClickJavaScript(btnAtualizarPerfil);
        }
        #endregion
    }
}
