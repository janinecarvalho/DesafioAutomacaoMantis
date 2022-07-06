using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class AlterarProjetosPage : PageBase
    {
        #region Mapeamento
        By projetoDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By btnAtualizarProjeto = By.CssSelector("input[value='Atualizar Projeto']");
        By txtNomeProjeto = By.Id("project-name");
        By comboEstado = By.Id("project-status");
        By comboVisibilidade = By.Id("project-view-state");
        By areaDescricao = By.Id("project-description");
        By abaProjetos = By.CssSelector("a[href='/manage_proj_page.php']");
        #endregion

        #region Action
        
        public void ClicarProjetoDisplayed()
        {
            Click(projetoDisplayed);
        }
        
        public void PreencherNomeProjeto(string nomeProjeto)
        {
            ClearAndSendKeys(txtNomeProjeto, nomeProjeto + " [Atualizado] ");
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
    }
}
