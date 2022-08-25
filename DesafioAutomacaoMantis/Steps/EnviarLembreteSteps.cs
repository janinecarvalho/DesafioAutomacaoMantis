using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class EnviarLembreteSteps
    {
        TarefaPage tarefaPage;

        public EnviarLembreteSteps()
        {
            tarefaPage = new TarefaPage();
        }

        #region Parameters of test
        string tabela = "mantis_bugnote_text_table";
        string coluna = "note";
        string textoEsperado = "Teste lembrete!";
        #endregion

        [StepDefinition(@"clicar no botao enviar um lembrete")]
        public void GivenClicarNoBotaoEnviarUmLembrete()
        {
            tarefaPage.ClicarNoBotaoEnviarUmLembrete();
        }
        
        [StepDefinition(@"selecionar o destinatario")]
        public void GivenSelecionarODestinatario()
        {
            tarefaPage.SelecionarODestinatario("janine");
        }
        
        [StepDefinition(@"preencher o texto do lembrete")]
        public void GivenPreencherOTextoDoLembrete()
        {
            tarefaPage.PreencherOTextoDoLembrete("Teste lembrete!");
        }
        
        [StepDefinition(@"clicar no botao enviar lembrete")]
        public void WhenClicarNoBotaoEnviarLembrete()
        {
            tarefaPage.ClicarNoBotaoEnviarLembrete();
        }

        [StepDefinition(@"clicar com java script no botao enviar um lembrete")]
        public void GivenClicarComJavaScriptNoBotaoEnviarUmLembrete()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoEnviarLembrete();
        }

        [StepDefinition(@"preencher com java script o texto do lembrete")]
        public void GivenPreencherComJavaScriptOTextoDoLembrete()
        {
            tarefaPage.PreencherComJavaScriptOTextoDoLembrete("Teste lembrete!");
        }

        [StepDefinition(@"clicar com java script no botao enviar lembrete")]
        public void WhenClicarComJavaScriptNoBotaoEnviarLembrete()
        {
            tarefaPage.ClicarComJavaScriptNoBotaoEnviarLembrete();
        }

        [StepDefinition(@"visualizar a inclusao do lembrete no banco")]
        public void ThenVisualizarAInclusaoDoLembreteNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }
    }
}
