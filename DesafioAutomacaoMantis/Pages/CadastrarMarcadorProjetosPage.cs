using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class CadastrarMarcadorProjetosPage : PageBase
    {
        #region Mapeamento
        By abaMarcadores = By.CssSelector("a[href='/manage_tags_page.php']");
        By txtNome = By.Id("tag-name");
        By areaDescricao = By.Id("tag-description");
        By btnCriarMarcador = By.Name("config_set");
        #endregion

        #region Action
        public void ClicarAbaMarcadores()
        {
            Click(abaMarcadores);
        }
        public void PreencherCampoNomeMarcador(string nomeMarcador)
        {
            SendKeys(txtNome, nomeMarcador);
        }
        public void PreencherCampoDescricaoMarcador(string descricaoMarcador)
        {
            SendKeys(areaDescricao, descricaoMarcador);
        }
        public void ClicarBotaoCriarMarcador()
        {
            Click(btnCriarMarcador);
        }
        public bool VisualizarAbaMarcadores()
        {
            return ReturnIfElementIsDisplayed(abaMarcadores);
        }
        public void ClicarComJavaScriptNaAbaGerenciarMarcadores()
        {
            ClickJavaScript(abaMarcadores);
        }

        public void PreencherComJavaScriptOCampoNomeDoMarcador(string nomeMarcador)
        {
            SendKeysJavaScript(txtNome, nomeMarcador);
        }

        public void PreencherComJavaScriptOCampoDescricaoDoMarcador(string descricaoMarcador)
        {
            SendKeysJavaScript(areaDescricao, descricaoMarcador);
        }

        public void ClicarComJavaScriptNoBotaoCriarMarcador()
        {
            ClickJavaScript(btnCriarMarcador);
        }
        #endregion
    }
}
