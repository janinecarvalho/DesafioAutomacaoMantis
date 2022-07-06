using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;

namespace DesafioAutomacaoMantis.Pages
{
    public class ExcluirTarefaPage : PageBase
    {
        #region Mapeamento
        By checkTarefaDisplayed = By.Name("bug_arr[]");
        By comboSelecionarAcao = By.Name("action");
        By btnOK = By.CssSelector("input[value='OK']");
        By btnApagarTarefas = By.CssSelector("input[value='Apagar Tarefas']");
        By painelTarefa = By.XPath("//*[contains(text(),'Recente')]");

        #endregion

        #region Action
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
