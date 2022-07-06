using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class ExcluirCamposPersonalizadosPage : PageBase
    {
        #region Mapeamento
        By campoDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By btnApagarCampoPersonalizado = By.CssSelector("input[value='Apagar Campo Personalizado']");
        By btnApagarCampo = By.CssSelector("input[value='Apagar Campo']");
        #endregion

        #region Action
        public void ClicarNoCampoPersonalizadoParaExcluir()
        {
            Click(campoDisplayed);
        }
        public void ClicarNoBotaoApagarCampoPersonalizado()
        {
            Click(btnApagarCampoPersonalizado);
        }
        public void ClicarNoBotaoApagarCampo()
        {
            Click(btnApagarCampo);
        }
        public void ClicarComJavaScriptNoCampoPersonalizadoParaExcluir()
        {
            ClickJavaScript(campoDisplayed);
        }
        public void ClicarComJavaScriptNoBotaoApagarCampoPersonalizado()
        {
            ClickJavaScript(btnApagarCampoPersonalizado);
        }
        public void ClicarComJavaScriptNoBotaoApagarCampo()
        {
            ClickJavaScript(btnApagarCampo);
        }
        #endregion
    }
}
