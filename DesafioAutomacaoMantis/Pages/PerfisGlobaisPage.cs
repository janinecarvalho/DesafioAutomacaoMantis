using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class PerfisGlobaisPage : PageBase
    {
        #region Mapeamento
        By abaPerfisGlobais = By.CssSelector("a[href='/manage_prof_menu_page.php']");
        By txtPlataforma = By.Id("platform");
        By txtOS = By.Id("os");
        By txtVersaoOs = By.Id("os-version");
        By areaDescricaoAdicional = By.Id("description");
        By btnAdicionarPerfil = By.CssSelector("input[value='Adicionar Perfil']");
        #endregion

        #region Mapeamento Alterar
        By radioEditarPerfil = By.Id("action-edit");
        By comboPerfil = By.Id("select-profile");
        By txtPlataformaAtualizado = By.Name("platform");
        By txtOSAtualizado = By.Name("os");
        By txtVersaoOsAtualizado = By.Name("os_build");
        By areaDescricaoAdicionalAtualizado = By.Name("description");
        By btnEnviar = By.CssSelector("input[value='Enviar']");
        By btnAtualizarPerfil = By.CssSelector("input[value='Atualizar Perfil']");
        #endregion

        #region Mapeamento Excluir
        By radioApagarPerfil = By.Id("action-delete");
        #endregion

        #region Action Cadastrar
        public void ClicarNaAbaGerenciarPerfisGlobais()
        {
            Click(abaPerfisGlobais);
        }
        public void PreencherOCampoPlataforma(string plataforma)
        {
            SendKeys(txtPlataforma, plataforma);
        }
        public void PreencherOCampoSo(string so)
        {
            SendKeys(txtOS, so);
        }
        public void PreencherOCampoVersaoSo(string versoSo)
        {
            SendKeys(txtVersaoOs, versoSo);
        }
        public void PreencherOCampoDescricaoAdicional(string descricao)
        {
            SendKeys(areaDescricaoAdicional, descricao);
        }
        public void ClicarNoBotaoAdicionarPerfil()
        {
            Click(btnAdicionarPerfil);
        }
        public bool VizualizoOPainelGerenciarPerfisGlobais()
        {
            return ReturnIfElementIsDisplayed(abaPerfisGlobais);
        }
        public void ClicarComJavaScripNaAbaGerenciarPerfisGlobais()
        {
            Click(abaPerfisGlobais);
        }

        public void PreencherComJavaScripOCampoPlataforma(string plataforma)
        {
            SendKeysJavaScript(txtPlataforma, plataforma);
        }

        public void PreencherComJavaScripOCampoSo(string so)
        {
            SendKeysJavaScript(txtOS, so);
        }

        public void PreencherComJavaScripOCampoVersaoSo(string versoSo)
        {
            SendKeysJavaScript(txtVersaoOs, versoSo);
        }

        public void PreencherComJavaScripOCampoDescricaoAdicional(string descricao)
        {
            SendKeysJavaScript(areaDescricaoAdicional, descricao);
        }

        public void ClicarComJavaScripNoBotaoAdicionarPerfil()
        {
            ClickJavaScript(btnAdicionarPerfil);
        }
        #endregion

        #region Action Alterar
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
            ClearAndSendKeys(txtPlataformaAtualizado, plataforma);
        }
        public void PreencherOCampoSoAtualizado(string so)
        {
            ClearAndSendKeys(txtOSAtualizado, so);
        }
        public void PreencherOCampoVersaoSoAtualizado(string versaoSo)
        {
            ClearAndSendKeys(txtVersaoOsAtualizado, versaoSo);
        }
        public void PreencherOCampoDescricaoAdicionalAtualizado(string descricao)
        {
            ClearAndSendKeys(areaDescricaoAdicionalAtualizado, descricao);
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
            ClearAndSendKeysJavaScript(txtPlataformaAtualizado, plataforma);
        }

        public void PreencherComJavaScriptOCampoSoAtualizado(string so)
        {
            ClearAndSendKeysJavaScript(txtOSAtualizado, so);
        }

        public void PreencherComJavaScriptOCampoVersaoSoAtualizado(string versaoSo)
        {
            ClearAndSendKeysJavaScript(txtVersaoOsAtualizado, versaoSo);
        }

        public void PreencherComJavaScriptOCampoDescricaoAdicionalAtualizado(string descricao)
        {
            ClearAndSendKeysJavaScript(areaDescricaoAdicionalAtualizado, descricao);
        }

        public void ClicarComJavaScriptNoBotaoAtualizarPerfil()
        {
            ClickJavaScript(btnAtualizarPerfil);
        }
        #endregion

        #region Action Excluir
        public void ClicarNoRadioboxApagarPerfil()
        {
            ClickCheckBoxAndRadioBoxJavaScript(radioApagarPerfil);
        }
        #endregion
    }
}
