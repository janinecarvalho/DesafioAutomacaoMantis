using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
   public class ExcluirMarcadorProjetosPage : PageBase
    {
        #region Mapeamento
        By btnApagarMarcador = By.XPath("//*[@value='Apagar Marcador']");
        By abaMarcadores = By.CssSelector("a[href='/manage_tags_page.php']");
        #endregion

        #region Action
        public void ClicarBotaoApagarMarcador()
        {
            Click(btnApagarMarcador);
        }
        public void GivenClicarComJavaScriptNoBotaoApagarMarcador()
        {
            ClickJavaScript(btnApagarMarcador);
        }
        public bool VisualizarAbaMarcadores()
        {
            return ReturnIfElementIsDisplayed(abaMarcadores);
        }
        #endregion
    }
}
