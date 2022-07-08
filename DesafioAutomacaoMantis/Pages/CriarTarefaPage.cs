using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class CriarTarefaPage : PageBase
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

        #region Action
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
            SendKeys(txtResumo,resumo);
        }
        public void PreencherOCampoDescricao(string descricao)
        {
            SendKeys(areaDescricao, descricao);
        }
        public void PreencherOCampoPassosParaReproduzir(string passosReproduzir)
        {
            SendKeys(areaPassosReproduzir, passosReproduzir);
        }
        public void PreencherOCampoInformacaoAdicionais(string infoAdicionais)
        {
            SendKeys(areaAdicionais, infoAdicionais);
        }
        public void PreencherOCampoAplicarMarcadores(string marcador)
        {
            SendKeys(txtAplicarMarcadores, marcador);
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
            ClickJavaScript(abaCriartarefa);
        }
        #endregion
    }
}
