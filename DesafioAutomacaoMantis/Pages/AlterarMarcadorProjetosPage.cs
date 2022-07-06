using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class AlterarMarcadorProjetosPage : PageBase
    {
        #region Mapeamento
        By marcadorDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By btnAtualizarMarcador = By.XPath("//*[@value='Atualizar Marcador']");
        By txtNome = By.Id("tag-name");
        By comboCriador = By.Id("tag-user-id");
        By areaDescricao = By.Id("tag-description");
        By painelDetalhes = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[1]/h4");
        #endregion

        #region Action

        public void ClicarMarcadorDisplayed()
        {
            Click(marcadorDisplayed);
        }
        public void ClicarBotaoAtualizarMarcador()
        {
            Click(btnAtualizarMarcador);
        }
        public void PreencherNomeMarcador(string nomeMarcador)
        {
            ClearAndSendKeys(txtNome, nomeMarcador);
        }
        public void SelecionarCriadorMarcador(string opcaoCriador)
        {
            ComboBoxSelectByVisibleText(comboCriador, opcaoCriador);
        }
        public void PreencherDescricaoMarcador(string descricaoMarcador)
        {
            ClearAndSendKeys(areaDescricao, descricaoMarcador);
        }
        public string GetTextPainel()
        {
            return GetText(painelDetalhes);
        }
        public void ClicarComJavaScriptNoMarcador()
        {
            ClickJavaScript(marcadorDisplayed);
        }

        public void ClicarComJavaScriptNoBotaoAtualizarMarcador()
        {
            ClickJavaScript(btnAtualizarMarcador);
        }
        public void PreencherComJavaScriptOCampoNomeDoMarcadorAtualizado(string nomeMarcador)
        {
            ClearAndSendKeysJavaScript(txtNome, nomeMarcador);
        }
        public void PreencherComJavaScriptOCampoDescricaoDoMarcadorAtualizado(string descricaoMarcador)
        {
            ClearAndSendKeysJavaScript(areaDescricao, descricaoMarcador);
        }
        #endregion
    }
}
