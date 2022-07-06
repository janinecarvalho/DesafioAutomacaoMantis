using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class CadastrarProjetosPage : PageBase
    {
        #region Mapeamento
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

        #region Action
        
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
            SendKeys(txtNomeProjeto, nomeProjeto);
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
    }
}
