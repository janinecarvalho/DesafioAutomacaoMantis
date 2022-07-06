using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class CadastrarPerfisGlobaisPage : PageBase
    {
        #region Mapeamento
        By abaPerfisGlobais = By.CssSelector("a[href='/manage_prof_menu_page.php']");
        By txtPlataforma = By.Id("platform");
        By txtOS = By.Id("os");
        By txtVersaoOs = By.Id("os-version");
        By areaDescricaoAdicional = By.Id("description");
        By btnAdicionarPerfil = By.CssSelector("input[value='Adicionar Perfil']");

        #endregion

        #region Action
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
    }
}
