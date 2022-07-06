using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class ExcluirCategoriaProjetosPage : PageBase
    {
        #region Mapeamento
        By btnApagar = By.XPath("//*[@action='manage_proj_cat_delete.php?id=2&project_id=0']//button[contains(text(),'Apagar')]");////*[@id='categories']/div/div[2]/div/div/table/tbody/tr[1]/td[3]/div/div[2]/form/fieldset/button
        By btnApagarCategoria = By.CssSelector("input[value='Apagar Categoria']");
        #endregion

        #region Action
        
        public void ClicarBotaoApagar()
        {
            Click(btnApagar);
        }
        
        public void ClicarBotaoApagarCategoria()
        {
            Click(btnApagarCategoria);
        }
        public void ClicarComJavaScriptNoBotaoApagar()
        {
            ClickJavaScript(btnApagar);
        }
        public void ClicarComJavaScriptNoBotaoApagarCategoria()
        {
            ClickJavaScript(btnApagarCategoria);
        }
        #endregion
    }
}
