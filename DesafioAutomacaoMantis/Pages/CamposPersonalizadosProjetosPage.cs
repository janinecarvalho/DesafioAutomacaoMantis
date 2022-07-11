using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class CamposPersonalizadosProjetosPage : PageBase
    {
        #region Mapeamento Cadastrar
        By txtNome = By.Name("name");
        By btnNovoCampoPersonalizado = By.XPath("//*[@value='Novo Campo Personalizado']");
        By txtValoresPossiveis = By.Id("custom-field-possible-values");
        By txtValorPadrao = By.Id("custom-field-default-value");
        By txtExpressaoRegular = By.Id("custom-field-valid-regexp");
        By comboAcessoLeitura = By.Id("custom-field-access-level-r");
        By comboAcessoEscrita = By.Id("custom-field-access-level-rw");
        By txtCompMinimo = By.Id("custom-field-length-min");
        By txtCompMax = By.Id("custom-field-length-max");
        By checkCriarTarefas = By.Id("custom-field-display-report");
        By checkResolverTarefas = By.Id("custom-field-display-resolved");
        By checkFecharTarefas = By.Id("custom-field-display-closed");
        By checkRelato = By.Id("custom-field-require-report");
        By checkAtualizacao = By.Id("custom-field-require-update");
        By checkResolucao = By.Id("custom-field-require-resolved");
        By checkFechamento = By.Id("custom-field-require-closed");
        By btnAtualizarCampoPersonalizado = By.XPath("//*[@value='Atualizar Campo Personalizado']");
        By abaCamposPersonalizados = By.CssSelector("a[href='/manage_custom_field_page.php']");
        By msgSucesso = By.XPath("//p");
        #endregion

        #region Mapeamento Alterar
        By campoDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By comboTipo = By.Id("custom-field-type");
        #endregion

        #region Mapeamento Excluir
        By btnApagarCampoPersonalizado = By.CssSelector("input[value='Apagar Campo Personalizado']");
        By btnApagarCampo = By.CssSelector("input[value='Apagar Campo']");
        #endregion

        #region Action Cadastrar
        public void ClicarNaAbaGerenciarCamposPersonalizados()
        {
            Click(abaCamposPersonalizados);
        }
        public void PreencherOCampoNomePersonalizado(string nomeCampoPersonalizado)
        {
            ClearAndSendKeys(txtNome, nomeCampoPersonalizado);
        }
        public void ClicarNoBotaoNovoCampoPersonalizado()
        {
            Click(btnNovoCampoPersonalizado);

        }
        public void PreencherOCampoValoresPossiveis(string valorPossivel)
        {

            SendKeys(txtValoresPossiveis, valorPossivel);
        }
        public void PreencherOCampoValorPadrao(string valorPadrao)
        {
            SendKeys(txtValorPadrao, valorPadrao);
        }
        public void PreencherOCampoExpressaoRegular(string expressaoRegular)
        {
            SendKeys(txtExpressaoRegular, expressaoRegular);
        }
        public void SelecionarOAcessoDeLeitura(string opcaoLeitura)
        {
            ComboBoxSelectByVisibleText(comboAcessoLeitura, opcaoLeitura);
        }
        public void SelecionarOAcessoDeEscrita(string opcaoEscrita)
        {
            ComboBoxSelectByVisibleText(comboAcessoEscrita, opcaoEscrita);
        }
        public void PreencherOCampoComprimentoMinimo(string compMinimo)
        {
            SendKeys(txtCompMinimo, compMinimo);
        }
        public void PreencherOCampoComprimentoMaximo(string compMax)
        {
            SendKeys(txtCompMax, compMax);
        }
        public void MarcarOCheckboxCriarTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkCriarTarefas);
        }
        public void MarcarOCheckboxResolverTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkResolverTarefas);
        }
        public void MarcarOCheckboxFecharTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkFecharTarefas);
        }
        public void MarcarOCheckboxRelato()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkRelato);
        }
        public void MarcarOCheckboxAtualizacao()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkAtualizacao);
        }
        public void MarcarOCheckboxResolucao()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkResolucao);
        }
        public void MarcarOCheckboxFechamento()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkFechamento);
        }
        public void ClicarNoBotaoAtualizarCampoPersonalizado()
        {
            Click(btnAtualizarCampoPersonalizado);
        }
        public string VizualizoaMensagemDeSucesso()
        {
            return GetText(msgSucesso);
        }
        public void ClicarComJavaScriptNaAbaGerenciarCamposPersonalizados()
        {
            Click(abaCamposPersonalizados);
        }

        public void PreencherComJavaScriptOCampoNomePersonalizado(string nomeCampoPersonalizado)
        {
            SendKeysJavaScript(txtNome, nomeCampoPersonalizado);
        }

        public void PreencherComJavaScriptOCampoValoresPossiveis(string valorPossivel)
        {
            SendKeysJavaScript(txtValoresPossiveis, valorPossivel);
        }

        public void PreencherComJavaScriptOCampoValorPadrao(string valorPadrao)
        {
            SendKeysJavaScript(txtValorPadrao, valorPadrao);
        }

        public void PreencherComJavaScriptOCampoExpressaoRegular(string expressaoRegular)
        {
            SendKeysJavaScript(txtExpressaoRegular, expressaoRegular);
        }

        public void PreencherComJavaScriptOCampoComprimentoMinimo(string compMinimo)
        {
            SendKeysJavaScript(txtCompMinimo, compMinimo);
        }

        public void PreencherComJavaScriptOCampoComprimentoMaximo(string compMax)
        {
            SendKeysJavaScript(txtCompMax, compMax);
        }

        public void ClicarComJavaScriptNoBotaoAtualizarCampoPersonalizado()
        {
            ClickJavaScript(btnAtualizarCampoPersonalizado);
        }
        #endregion

        #region Action Alterar
        public void ClicarNoCampoPersonalizadoParaAlterar(string campoPersonalizado)
        {
            Click(campoDisplayed);
        }
        public void SelecionarOTipo(string tipo)
        {
            ComboBoxSelectByVisibleText(comboTipo, tipo);
        }
        public void DesmarcarOCheckboxCriarTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkCriarTarefas);
        }
        public void DesmarcarOCheckboxResolverTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkResolverTarefas);
        }
        public void DesmarcarOCheckboxFecharTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkFecharTarefas);
        }
        public void DesmarcarOCheckboxRelato()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkRelato);
        }
        public void DesmarcarOCheckboxAtualizacao()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkAtualizacao);
        }
        public void DesmarcarOCheckboxResolucao()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkResolucao);
        }
        public void DesmarcarOCheckboxFechamento()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkFechamento);
        }
        public void ClicarComJavaScriptNoCampoPersonalizadoParaAlterar()
        {
            ClickJavaScript(campoDisplayed);
        }
        #endregion

        #region Action Excluir
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
