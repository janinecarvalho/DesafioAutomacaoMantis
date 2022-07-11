using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class MarcadorProjetosPage : PageBase
    {
        #region Mapeamento Cadastrar
        By abaMarcadores = By.CssSelector("a[href='/manage_tags_page.php']");
        By txtNome = By.Id("tag-name");
        By areaDescricao = By.Id("tag-description");
        By btnCriarMarcador = By.Name("config_set");
        #endregion

        #region Mapeamento Alterar
        By marcadorDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By btnAtualizarMarcador = By.XPath("//*[@value='Atualizar Marcador']");
        By comboCriador = By.Id("tag-user-id");
        By painelDetalhes = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[1]/h4");
        #endregion

        #region Mapeamento Excluir
        By btnApagarMarcador = By.XPath("//*[@value='Apagar Marcador']");
        #endregion

        #region Action Cadastrar
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

        #region Action Alterar
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

        #region Action Excluir
        public void ClicarBotaoApagarMarcador()
        {
            Click(btnApagarMarcador);
        }
        public void GivenClicarComJavaScriptNoBotaoApagarMarcador()
        {
            ClickJavaScript(btnApagarMarcador);
        }
        #endregion
    }
}
