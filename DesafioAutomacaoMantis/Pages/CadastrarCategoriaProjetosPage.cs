using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class CadastrarCategoriaProjetosPage : PageBase
    {
        #region Mapeamento
        By txtName = By.Name("name");
        By btnAdicionarCategoria = By.CssSelector("input[value='Adicionar Categoria']");

        #endregion

        #region Action
        
        public void PreencherCampoNomeCategoria(string nomeCategoria)
        {
            SendKeys(txtName, nomeCategoria);
        }        
        public void PreencherCampoNomeCategoriaComJavaScript(string nomeCategoria)
        {
            SendKeysJavaScript(txtName, nomeCategoria);
        }
        
        public void ClicarBotaoAdicionarProjeto()
        {
            Click(btnAdicionarCategoria);
        }
        public void ClicarBotaoAdicionarProjetoComJavaScript()
        {
            ClickJavaScript(btnAdicionarCategoria);
        }
        #endregion
    }
}
