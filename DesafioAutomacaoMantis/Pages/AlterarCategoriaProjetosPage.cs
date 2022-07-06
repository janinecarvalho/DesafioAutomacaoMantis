using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class AlterarCategoriaProjetosPage : PageBase
    {
        #region Mapeamento
        By btnAlterarCategoria = By.XPath("//*[@id='categories']/div/div[2]/div/div/table/tbody/tr[1]/td[3]/div/div[1]/form/fieldset/button");
        By txtNomeCategoria = By.Id("proj-category-name");
        By comboAtribuido = By.Id("proj-category-assigned-to");//janine
        By btnAtualizarCategoria = By.CssSelector("input[value='Atualizar Categoria']");
        #endregion

        #region Action
        
        public void ClicarBotaoAlterarCategoria()
        {
            Click(btnAlterarCategoria);
        }
        
        public void PreencherCampoNomeCategoria(string nomeCategoria)
        {
            ClearAndSendKeys(txtNomeCategoria, nomeCategoria + " [Atualizado] ");
        }
        
        public void SelecionarAtribuicaoCategoria(string atribuicao)
        {
            ComboBoxSelectByVisibleText(comboAtribuido, atribuicao);
        }
        
        public void ClicarBotaoAtualizarCategoria()
        {
            Click(btnAtualizarCategoria);
        }

        public void ClicarBotaoAlterarCategoriaComJavaScript()
        {
            Click(btnAlterarCategoria);
        }

        public void PreencherCampoNomeCategoriaComJavaScript(string nomeCategoria)
        {
            ClearAndSendKeysJavaScript(txtNomeCategoria, nomeCategoria + " [Atualizado] ");
        }

        public void SelecionarAtribuicaoCategoriaComJavaScript(string atribuicao)
        {
            ComboBoxSelectByVisibleTextJavaScript(comboAtribuido, atribuicao);
        }

        public void ClicarBotaoAtualizarCategoriaComJavaScript()
        {
            ClickJavaScript(btnAtualizarCategoria);
        }

        #endregion
    }
}
