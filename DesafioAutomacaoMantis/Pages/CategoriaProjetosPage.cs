using DesafioAutomacaoMantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAutomacaoMantis.Pages
{
    public class CategoriaProjetosPage : PageBase
    {
        #region Mapeamento Cadastrar
        By txtName = By.Name("name");
        By btnAdicionarCategoria = By.CssSelector("input[value='Adicionar Categoria']");
        #endregion

        #region Mapeamento Alterar
        By btnAlterarCategoria = By.XPath("//*[@id='categories']//table/tbody/tr[1]/td[3]/div/div[1]/form/fieldset/button");
        By txtNomeCategoria = By.Id("proj-category-name");
        By comboAtribuido = By.Id("proj-category-assigned-to");
        By btnAtualizarCategoria = By.CssSelector("input[value='Atualizar Categoria']");
        #endregion

        #region Mapeamento Excluir
        By btnApagar = By.XPath("//*//*[@id='categories']//table/tbody/tr[1]/td[3]/div/div[2]/form/fieldset/button");
        By btnApagarCategoria = By.CssSelector("input[value='Apagar Categoria']");
        #endregion

        #region Action Cadastrar
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

        #region Action Alterar
        public void ClicarBotaoAlterarCategoria()
        {
            Click(btnAlterarCategoria);
        }

        public void PreencherCampoNomeCategoriaAtualizado(string nomeCategoria)
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

        public void PreencherCampoNomeCategoriaAtualizadoComJavaScript(string nomeCategoria)
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

        #region Action Excluir
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
