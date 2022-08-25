using DesafioAutomacaoMantis.Bases;
using DesafioAutomacaoMantis.DataBaseSteps;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class ProjetosPage : PageBase
    {
        #region Mapeamento Cadastrar
        By abaGerenciar = By.CssSelector("a[href='/manage_overview_page.php']");
        By btnGerenciarProjetos = By.CssSelector("a[href='/manage_proj_page.php']");
        By btnCriarNovoProjeto = By.CssSelector("form[action='manage_proj_create_page.php'] > fieldset > button[type='submit']");
        By txtNomeProjeto = By.Id("project-name");
        By comboEstado = By.Id("project-status");
        By comboVisibilidade = By.Id("project-view-state");
        By areaDescricao = By.Id("project-description");
        By btnAdicionarProjeto = By.CssSelector("input[value='Adicionar projeto']");
        By msgSucesso = By.CssSelector("p");
        #endregion

        #region Mapeamento Alterar
        By projetoDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By btnAtualizarProjeto = By.CssSelector("input[value='Atualizar Projeto']");
        By abaProjetos = By.CssSelector("a[href='/manage_proj_page.php']");
        #endregion

        #region Mapeamento Excluir
        By btnApagarProjeto = By.CssSelector("input[value='Apagar Projeto']");
        #endregion

        #region Mapeamento Cadastrar Versao
        By txtVersaoProjeto = By.Name("version");
        By btnAdicionarVersaoProjeto = By.Name("add_version");
        #endregion

        #region Mapeamento Alterar Versao
        By txtVersaoProjetoAtualizado = By.Id("proj-version-new-version");
        By btnAlterarVersao = By.XPath("//*[@id='versions']//*[contains(text(),'Alterar')]");
        By areaDescricaoVersao = By.Id("proj-version-description");
        By checkLiberada = By.Id("proj-version-released");
        By btnAtualizarVersao = By.CssSelector("input[value='Atualizar Versão']");
        #endregion

        #region Mapeamento Excluir Versao
        By btnApagarVersao = By.XPath("//*[@id='versions']//*[contains(text(),'Apagar')]");
        By btnApagarVersaoFinal = By.CssSelector("input[value='Apagar Versão']");
        #endregion

        #region Action Cadastrar
        public void ClicarBotaoGerenciar()
        {
            Click(abaGerenciar);
        }

        public void NavegarAbaGerenciarProjetos()
        {
            Click(btnGerenciarProjetos);
        }

        public void ClicarBotaoNovoProjeto()
        {
            Click(btnCriarNovoProjeto);
        }

        public void PreencherNomeProjeto(string nomeProjeto)
        {
            ClearAndSendKeys(txtNomeProjeto, nomeProjeto);
        }

        public void SelecionarEstadoProjeto(string estadoProjeto)
        {
            ComboBoxSelectByVisibleText(comboEstado, estadoProjeto);
        }

        public void SelecionarVisibilidadeProjeto(string visibilidadeProjeto)
        {
            ComboBoxSelectByVisibleText(comboVisibilidade, visibilidadeProjeto);
        }

        public void PreencherAreaDescricao(string descricaoProjeto)
        {
            SendKeys(areaDescricao, descricaoProjeto);
        }

        public void ClicarBotaoAdicionarProjeto()
        {
            Click(btnAdicionarProjeto);
        }

        public void ClicarComJavaScriptNaAbaGerenciarProjetos()
        {
            ClickJavaScript(btnGerenciarProjetos);
        }

        public void ClicarComJavaScriptNoBotaoCriarNovoProjeto()
        {
            ClickJavaScript(btnCriarNovoProjeto);
        }

        public void PreencherComJavaScriptOCampoNomeDoProjeto(string nomeProjeto)
        {
            SendKeysJavaScript(txtNomeProjeto, nomeProjeto);
        }

        public void PreencherComJavaScriptOCampoDescricaoDoProjeto(string descricaoProjeto)
        {
            SendKeysJavaScript(areaDescricao, descricaoProjeto);
        }

        public void ClicarComJavaScriptNoBotaoAdicionarProjeto()
        {
            ClickJavaScript(btnAdicionarProjeto);
        }
        #endregion

        #region Action Alterar
        public void ClicarProjetoDisplayed()
        {
            Click(projetoDisplayed);
        }

        public void PreencherNomeProjetoAtualizado(string nomeProjeto)
        {
            ClearAndSendKeys(txtNomeProjeto, nomeProjeto + " [Atualizado] ");
        }

        public void PreencherAreaDescricaoAtualizado(string descricaoProjeto)
        {
            ClearAndSendKeys(areaDescricao, descricaoProjeto + " [Atualizado] ");
        }

        public void ClicarBotaoAtualizarProjeto()
        {
            Click(btnAtualizarProjeto);
        }
        public void PreencherComJavaScriptOCampoNomeDoProjetoAtualizado(string nomeProjeto)
        {
            ClearAndSendKeysJavaScript(txtNomeProjeto, nomeProjeto + " [Atualizado] ");
        }

        public void PreencherComJavaScriptOCampoDescricaoDoProjetoAtualizado(string descricaoProjeto)
        {
            ClearAndSendKeysJavaScript(areaDescricao, descricaoProjeto + " [Atualizado] ");
        }

        public void ClicarComJavaScriptNoBotaoAtualizarProjeto()
        {
            ClickJavaScript(btnAtualizarProjeto);
        }
        #endregion

        #region Action Excluir
        public void ClicarBotaoApagarProjeto()
        {
            Click(btnApagarProjeto);
        }

        public string RetornarProjetoDisplayed()
        {

            return GetText(projetoDisplayed);
        }

        public void ClicarComJavaScriptNoProjetoParaExcluir()
        {
            ClickJavaScript(projetoDisplayed);
        }

        public void ClicarComJavaScriptNoBotaoApagarProjeto()
        {
            ClickJavaScript(btnApagarProjeto);
        }
        #endregion

        #region Action Cadastrar versao
        public void PreencherONomeDaVersaoDoProjeto(string versao)
        {
            ClearAndSendKeys(txtVersaoProjeto, versao);
        }

        public void ClicarNoBotaoAdicionarVersao()
        {
            Click(btnAdicionarVersaoProjeto); ;
        }

        #endregion

        #region Action Alterar Versao Projeto
        public void ClicarNoBotaoAlterarDaVersaoDoProjeto()
        {
            Click(btnAlterarVersao);
        }
        public void PreencherONomeDaVersaoDoProjetoAtualizado(string versaoAtualizado)
        {
            ClearAndSendKeys(txtVersaoProjetoAtualizado, versaoAtualizado);
        }
        public void PreencherOCampoDescricaoVersaoDoProjeto(string descricao)
        {
            ClearAndSendKeys(areaDescricaoVersao, descricao);
        }
        public void MarcarOCheckLiberada()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkLiberada);
        }
        public void ClicarNoBotaoAtualizarVersao()
        {
            Click(btnAtualizarVersao);
        }

        #endregion

        #region Action Excluir Versao Projeto
        public void ClicarNoBotaoApagarDaVersaoDoProjeto()
        {
            Click(btnApagarVersao);
        }

        public void ClicarNoBotaoApagarVersao()
        {
            Click(btnApagarVersaoFinal);
        }

        #endregion
    }
}
