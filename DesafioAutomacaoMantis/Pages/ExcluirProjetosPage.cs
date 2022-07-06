using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class ExcluirProjetosPage : PageBase 
    {
        #region Mapeamento
        By projetoDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By btnApagarProjeto = By.CssSelector("input[value='Apagar Projeto']");
        #endregion

        #region Action
        
        public void ClicarProjetoDisplayed()
        {
            Click(projetoDisplayed);
        }
        
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
    }
}
