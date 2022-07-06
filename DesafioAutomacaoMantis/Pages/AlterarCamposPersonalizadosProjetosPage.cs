using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;


namespace DesafioAutomacaoMantis.Pages
{
    public class AlterarCamposPersonalizadosProjetosPage : PageBase
    {
        #region Mapeamento
        By campoDisplayed = By.XPath("//*[@class='table table-striped table-bordered table-condensed table-hover']/tbody/tr[1]/td[1]/a");
        By comboTipo = By.Id("custom-field-type");
        By checkCriarTarefas = By.Id("custom-field-display-report");
        By checkResolverTarefas = By.Id("custom-field-display-resolved");
        By checkFecharTarefas = By.Id("custom-field-display-closed");
        By checkRelato = By.Id("custom-field-require-report");
        By checkAtualizacao = By.Id("custom-field-require-update");
        By checkResolucao = By.Id("custom-field-require-resolved");
        By checkFechamento = By.Id("custom-field-require-closed");

        #endregion

        #region Action
        public void ClicarNoCampoPersonalizadoParaAlterar(string campoPersonalizado)
        {
            Click(campoDisplayed);
        }
        public void SelecionarOTipo(string tipo)
        {
            ComboBoxSelectByVisibleText(comboTipo, tipo);
        }
        public void DesmarcarOCheckboxCriarTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkCriarTarefas);
        }
        public void DesmarcarOCheckboxResolverTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkResolverTarefas);
        }
        public void DesmarcarOCheckboxFecharTarefas()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkFecharTarefas);
        }
        public void DesmarcarOCheckboxRelato()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkRelato);
        }
        public void DesmarcarOCheckboxAtualizacao()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkAtualizacao);
        }
        public void DesmarcarOCheckboxResolucao()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkResolucao);
        }
        public void DesmarcarOCheckboxFechamento()
        {
            ClickCheckBoxAndRadioBoxJavaScript(checkFechamento);
        }
        public void ClicarComJavaScriptNoCampoPersonalizadoParaAlterar()
        {
            ClickJavaScript(campoDisplayed);
        }
        #endregion
    }
}
