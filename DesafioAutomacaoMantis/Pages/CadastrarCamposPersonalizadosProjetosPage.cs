using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class CadastrarCamposPersonalizadosProjetosPage : PageBase
    {
        #region Mapeamento
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

        #region Action
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
    }
}
