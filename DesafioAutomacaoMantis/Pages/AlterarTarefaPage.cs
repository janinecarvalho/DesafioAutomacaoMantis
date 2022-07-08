using DesafioAutomacaoMantis.Bases;
using DesafioAutomacaoMantis.DataBaseSteps;
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
        By txtPesquisarTarefa = By.Name("bug_id");
        By painelNumeroTarefa = By.XPath("//*[@class='table table-bordered table-condensed']//*[@class='bug-id']");
        By btnEnviarLembrete = By.XPath("//*[@id='main-container']//*[contains(text(),'Enviar um lembrete')]");
        By comboDestinatario = By.Id("recipient");
        By textAreaLembrete = By.Name("body");
        By btnEnviar = By.XPath("//*[@value='Enviar']");
        By btnAlterarLembrete = By.XPath("//*[@id='bugnotes']//*[contains(text(),'Alterar')]");
        By btnApagarLembrete = By.XPath("//*[@id='bugnotes']//*[contains(text(),'Apagar')]");
        By textAreaLembreteAtualizar = By.Id("bugnote_text");
        By btnAtualizarInformacaoLembrete = By.CssSelector("input[value='Atualizar Informação']");
        By btnApagarInformacaoLembrete = By.CssSelector("input[value='Apagar Anotação']");

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

        public void PreencherOCampoTarefa(string numeroTarefa)
        {
            SendKeys(txtPesquisarTarefa, numeroTarefa);
        }

        public void ApertarATeclaEnter()
        {
            EnterKeyBoardAction(txtPesquisarTarefa);
        }

        public string VisualizarONumeroDaTarefa()
        {
            return GetText(painelNumeroTarefa);
        }

        public void ClicarNoBotaoEnviarUmLembrete()
        {
            Click(btnEnviarLembrete);
        }

        public void SelecionarODestinatario(string destinatario)
        {
            ComboBoxSelectByVisibleText(comboDestinatario, destinatario);
        }

        public void PreencherOTextoDoLembrete(string textoLembrete)
        {
            SendKeys(textAreaLembrete, textoLembrete);
        }

        public void ClicarNoBotaoEnviarLembrete()
        {
            Click(btnEnviar);
        }
        public void ClicarNoBotaoAlterarLembrete()
        {
            MoveMouseToElement(btnAlterarLembrete);
            Click(btnAlterarLembrete);
        }

        public void AtualizarOTextoDoLembrete(string texto)
        {
            SendKeys(textAreaLembreteAtualizar, texto);
        }

        public void ClicarNoBotaoAtualizarInformacaoDoLembrete()
        {
            Click(btnAtualizarInformacaoLembrete);
        }

        public void ClicarNoBotaoApagarLembrete()
        {
            MoveMouseToElement(btnApagarLembrete);
            Click(btnApagarLembrete);
        }

        public void ClicarNoBotaoApagarAnotacao()
        {
            Click(btnApagarInformacaoLembrete);
        }

        public bool VisualizarAExclusaoDoLembreteNoBanco(string value)
        {
            return ManageDBSteps.ValidarExclusaoBD("mantis_bugnote_text_table", "note", value);
        }
        public bool VisualizarAInclusaoDoLembreteNoBanco(string value)
        {
            return ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_bugnote_text_table", "note", value);
        }

        public bool VisualizarAAlteracaoDoLembreteNoBanco(string value)
        {
            return ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_bugnote_text_table", "note", value);
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

        public void PreencherComJavaScriptOCampoTarefa(string numeroTarefa)
        {
            SendKeysJavaScript(txtPesquisarTarefa, numeroTarefa);
        }

        public void ClicarComJavaScriptNoBotaoApagarLembrete()
        {
            MoveMouseToElement(btnApagarLembrete);
            ClickJavaScript(btnApagarLembrete);
        }

        public void ClicarComJavaScriptNoBotaoApagarAnotacao()
        {
            ClickJavaScript(btnApagarInformacaoLembrete);
        }

        public void ClicarComJavaScriptNoBotaoEnviarUmLembrete()
        {
            ClickJavaScript(btnEnviarLembrete);
        }

        public void PreencherComJavaScriptOTextoDoLembrete(string textoLembrete)
        {
            SendKeysJavaScript(textAreaLembrete, textoLembrete);
        }

        public void ClicarComJavaScriptNoBotaoAlterarLembrete()
        {
            ClickJavaScript(btnAlterarLembrete);
        }

        public void AtualizarComJavaScriptOTextoDoLembrete(string texto)
        {
            SendKeysJavaScript(textAreaLembreteAtualizar,texto);
        }

        public void ClicarComJavaScriptNoBotaoAtualizarInformacaoDoLembrete()
        {
            ClickJavaScript(btnAtualizarInformacaoLembrete);
        }
        public void ClicarComJavaScriptNoBotaoEnviarLembrete()
        {
            ClickJavaScript(btnEnviar);
        }
        #endregion
    }
}
