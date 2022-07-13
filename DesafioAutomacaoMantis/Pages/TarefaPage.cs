using DesafioAutomacaoMantis.Bases;
using DesafioAutomacaoMantis.DataBaseSteps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class TarefaPage : PageBase
    {
        #region Mapeamento
        By abaCriartarefa = By.CssSelector("a[href='/bug_report_page.php']");
        By comboCategoria = By.Id("category_id");
        By comboFrequencia = By.Id("reproducibility");
        By comboGravidade = By.Id("severity");
        By comboPrioridade = By.Id("priority");
        By comboPerfil = By.Id("profile_id");
        By btnPlus = By.Id("profile_closed_link");
        By comboAtribuir = By.Id("handler_id");
        By txtResumo = By.Id("summary");
        By areaDescricao = By.Id("description");
        By areaPassosReproduzir = By.Id("steps_to_reproduce");
        By areaAdicionais = By.Id("additional_info");
        By txtAplicarMarcadores = By.Id("tag_string");
        By checkContinuarRelatando = By.Id("report_stay");
        By btnCriarNovaTarefa = By.CssSelector("input[value='Criar Nova Tarefa']");
        By btnCriarClone = By.CssSelector("input[value='Criar Clone']");
        #endregion

        #region Mapeamento Alterar
        By btnVerTarefas = By.CssSelector("a[href='/view_all_bug_page.php']");
        By btnEditar = By.XPath("//*[contains(@title,'Atualizar')]");
        By comboVisibilidade = By.Id("view_state");
        By comboAtribuido = By.Id("handler_id");
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

        #region Mapeamento Excluir
        By checkTarefaDisplayed = By.Name("bug_arr[]");
        By comboSelecionarAcao = By.Name("action");
        By btnOK = By.CssSelector("input[value='OK']");
        By btnApagarTarefas = By.CssSelector("input[value='Apagar Tarefas']");
        By painelTarefa = By.XPath("//*[contains(text(),'Recente')]");
        #endregion

        #region Action GetMaxIdTable
        public string GetMaxIdTable()
        {
            return ManageDBSteps.GetIdMassaTable("mantis_bug_table");
        }
        #endregion

        #region Action Cadastrar
        public void ClicarNoBotaoCriarTarefa()
        {
            Click(abaCriartarefa);
        }
        public void SelecionarACategoria(string categoria)
        {
            ComboBoxSelectByVisibleText(comboCategoria, categoria);
        }
        public void SelecionarAFrequencia(string frequencia)
        {
            ComboBoxSelectByVisibleText(comboFrequencia, frequencia);
        }
        public void SelecionarAGravidade(string gravidade)
        {
            ComboBoxSelectByVisibleText(comboGravidade, gravidade);
        }
        public void SelecionarAPrioridade(string prioridade)
        {
            ComboBoxSelectByVisibleText(comboPrioridade, prioridade);
        }
        public void SelecionarOCampoPerfil(string perfil)
        {
            ComboBoxSelectByVisibleText(comboPerfil, perfil);
        }
        public void ClicarNoBotaoMais()
        {
            ClickCheckBoxAndRadioBoxJavaScript(btnPlus);
        }
        public void SelecionarOCampoAtribuir(string atribuir)
        {
            ComboBoxSelectByVisibleText(comboAtribuir, atribuir);
        }
        public void PreencherOCampoResumo(string resumo)
        {
            ClearAndSendKeys(txtResumo, resumo);
        }
        public void PreencherOCampoDescricao(string descricao)
        {
            ClearAndSendKeys(areaDescricao, descricao);
        }
        public void PreencherOCampoPassosParaReproduzir(string passosReproduzir)
        {
            ClearAndSendKeys(areaPassosReproduzir, passosReproduzir);
        }
        public void PreencherOCampoInformacaoAdicionais(string infoAdicionais)
        {
            ClearAndSendKeys(areaAdicionais, infoAdicionais);
        }
        public void PreencherOCampoAplicarMarcadores(string marcador)
        {
            ClearAndSendKeys(txtAplicarMarcadores, marcador);
        }
        public void MarcarOCheckContinuarRelatando()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkContinuarRelatando);
        }
        public void ClicarNoBotaoCriarClone()
        {
            Click(btnCriarClone);
        }
        public void ClicarNoBotaoCriarNovaTarefa()
        {
            Click(btnCriarNovaTarefa);
        }
        public bool VizualizoOPainelDetalhesDaTarefa()
        {
            return ReturnIfElementIsDisplayed(btnCriarNovaTarefa);
        }
        public void GivenClicarComJavaScriptNoBotaoCriarTarefa()
        {
            Click(abaCriartarefa);
        }
        public void PreencherComJavaScriptOCampoResumo(string resumo)
        {
            SendKeysJavaScript(txtResumo, resumo);
        }

        public void PreencherComJavaScriptOCampoDescricao(string descricao)
        {
            SendKeysJavaScript(areaDescricao, descricao);
        }

        public void PreencherComJavaScriptOCampoPassosParaReproduzir(string passosReproduzir)
        {
            SendKeysJavaScript(areaPassosReproduzir, passosReproduzir);
        }

        public void PreencherComJavaScriptOCampoInformacaoAdicionais(string infoAdicionais)
        {
            SendKeysJavaScript(areaAdicionais, infoAdicionais);
        }

        public void PreencherComJavaScriptOCampoAplicarMarcadores(string marcador)
        {
            SendKeysJavaScript(txtAplicarMarcadores, marcador);
        }

        public void ClicarComJavaScriptNoBotaoCriarNovaTarefa()
        {
            ClickJavaScript(btnCriarNovaTarefa);
        }
        #endregion

        #region Action Alterar
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
            MoveMouseToElement(btnAlterarLembrete);
            ClickJavaScript(btnAlterarLembrete);
        }

        public void AtualizarComJavaScriptOTextoDoLembrete(string texto)
        {
            SendKeysJavaScript(textAreaLembreteAtualizar, texto);
        }

        public void ClicarComJavaScriptNoBotaoAtualizarInformacaoDoLembrete()
        {
            ClickJavaScript(btnAtualizarInformacaoLembrete);
        }
        public void ClicarComJavaScriptNoBotaoEnviarLembrete()
        {
            ClickJavaScript(btnEnviarLembrete);
        }
        #endregion

        #region Action Excluir
        public void ClicarNoCheckboxDaTarefaAExcluir()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkTarefaDisplayed);
        }
        public void SelecionarOSelecionarTudo(string acao)
        {
            ComboBoxSelectByVisibleText(comboSelecionarAcao, acao);
        }
        public void ClicarNoBotaoOk()
        {
            Click(btnOK);
        }
        public void ClicarNoBotaoApagarTarefas()
        {
            Click(btnApagarTarefas);
        }
        public void ClicarNoBotaoApagarTarefasJavaScript()
        {
            ClickJavaScript(btnApagarTarefas);
        }
        public bool VizualizoOPainelDeTarefas()
        {
            return ReturnIfElementIsDisplayed(painelTarefa);
        }
        public void GivenClicarComJavaScriptNoBotaoOk()
        {
            ClickJavaScript(btnOK);
        }
        public void WhenClicarComJavaScriptNoBotaoApagarTarefas()
        {
            ClickJavaScript(btnApagarTarefas);
        }
        #endregion
    }
}
