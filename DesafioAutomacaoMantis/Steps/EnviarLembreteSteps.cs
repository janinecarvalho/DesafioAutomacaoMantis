using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class EnviarLembreteSteps
    {
        AlterarTarefaPage alterarTarefaPage;

        public EnviarLembreteSteps()
        {
            alterarTarefaPage = new AlterarTarefaPage();
        }

        [StepDefinition(@"clicar no botao enviar um lembrete")]
        public void GivenClicarNoBotaoEnviarUmLembrete()
        {
            alterarTarefaPage.ClicarNoBotaoEnviarUmLembrete();
        }
        
        [StepDefinition(@"selecionar o destinatario")]
        public void GivenSelecionarODestinatario()
        {
            alterarTarefaPage.SelecionarODestinatario("janine");
        }
        
        [StepDefinition(@"preencher o texto do lembrete")]
        public void GivenPreencherOTextoDoLembrete()
        {
            alterarTarefaPage.PreencherOTextoDoLembrete("Teste lembrete!");
        }
        
        [StepDefinition(@"clicar no botao enviar lembrete")]
        public void WhenClicarNoBotaoEnviarLembrete()
        {
            alterarTarefaPage.ClicarNoBotaoEnviarLembrete();
        }

        [StepDefinition(@"clicar com java script no botao enviar um lembrete")]
        public void GivenClicarComJavaScriptNoBotaoEnviarUmLembrete()
        {

        }

        [StepDefinition(@"preencher com java script o texto do lembrete")]
        public void GivenPreencherComJavaScriptOTextoDoLembrete()
        {
            alterarTarefaPage.PreencherComJavaScriptOTextoDoLembrete("Teste lembrete!");
        }

        [StepDefinition(@"clicar com java script no botao enviar lembrete")]
        public void WhenClicarComJavaScriptNoBotaoEnviarLembrete()
        {
            alterarTarefaPage.ClicarComJavaScriptNoBotaoEnviarLembrete();
        }

        [StepDefinition(@"visualizar a inclusao do lembrete no banco")]
        public void ThenVisualizarAInclusaoDoLembreteNoBanco()
        {
            Assert.IsTrue(alterarTarefaPage.VisualizarAInclusaoDoLembreteNoBanco("Teste lembrete!"));
        }
    }
}
