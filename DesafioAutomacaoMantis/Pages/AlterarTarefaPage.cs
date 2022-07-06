using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class AlterarTarefaPage : PageBase
    {
        #region Mapeamento
        By btnVerTarefas = By.CssSelector("a[href='/view_all_bug_page.php']");
        By btnEditar = By.XPath("//*[contains(@title,'Atualizar')]");
        By comboCategoria = By.Id("category_id");
        By comboVisibilidade = By.Id("view_state");
        By comboAtribuido = By.Id("handler_id");
        By comboPrioridade = By.Id("priority");
        By comboGravidade = By.Id("severity");
        By comboEstado = By.Id("status");
        By comboResolucao = By.Id("resolution");
        By btnAtualizarInformacao = By.CssSelector("input[value='Atualizar Informação']");
        By btnHistorico = By.CssSelector("a[href='#history']");

        #endregion

        #region Action
        public void ClicarNoBotaoVerTarefas()
        {
            Click(btnVerTarefas);
        }
        public void ClicarNoBotaoAtualizar()
        {
            Click(btnEditar);
        }
        public void SelecionarACategoriaAtualizado(string categoria)
        {
            ComboBoxSelectByVisibleText(comboCategoria, categoria);
        }
        public void SelecionarAvisibilidadeAtualizado(string visibilidade)
        {
            ComboBoxSelectByVisibleText(comboVisibilidade, visibilidade);
        }
        public void SelecionarAGravidadeAtualizado(string gravidade)
        {
            ComboBoxSelectByVisibleText(comboGravidade, gravidade);
        }
        public void SelecionarAPrioridadeAtualizado(string prioridade)
        {
            ComboBoxSelectByVisibleText(comboPrioridade, prioridade);
        }
        public void SelecionarOCampoAtribuirAtualizado(string atribuido)
        {
            ComboBoxSelectByVisibleText(comboAtribuido, atribuido);
        }
        public void SelecionarOCampoEstado(string estado)
        {
            ComboBoxSelectByVisibleText(comboEstado, estado);
        }
        public void SelecionarOCampoResolucao(string resolucao)
        {
            ComboBoxSelectByVisibleText(comboResolucao, resolucao);
        }
        public void ClicarNoBotaoAtualizarInformacao()
        {
            Click(btnAtualizarInformacao);
        }
        public bool VizualizoOBotaoIrParaHistorico()
        {
            return ReturnIfElementIsDisplayed(btnHistorico);
        }
        public void ClicarComJavaScriptNoBotaoVerTarefas()
        {
            ClickJavaScript(btnVerTarefas);
        }
        public void ClicarComJavaScriptNoBotaoAtualizar()
        {
            ClickJavaScript(btnEditar);
        }
        public void ClicarComJavaScriptNoBotaoAtualizarInformacao()
        {
            ClickJavaScript(btnAtualizarInformacao);
        }
        #endregion
    }
}
