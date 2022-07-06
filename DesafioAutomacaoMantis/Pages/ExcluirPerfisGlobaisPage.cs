using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class ExcluirPerfisGlobaisPage : PageBase
    {
        #region Mapeamento
        By radioApagarPerfil = By.Id("action-delete");

        #endregion

        #region Action
        public void ClicarNoRadioboxApagarPerfil()
        {
            ClickCheckBoxAndRadioBoxJavaScript(radioApagarPerfil);
        }

        #endregion
    }
}
