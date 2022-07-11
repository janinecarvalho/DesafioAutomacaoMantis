using DesafioAutomacaoMantis.Pages;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ClonarTarefaSteps
    {
        TarefaPage tarefaPage;

        public ClonarTarefaSteps()
        {
            tarefaPage = new TarefaPage();
        }

        [StepDefinition(@"clicar no botao criar clone")]
        public void GivenClicarNoBotaoCriarClone()
        {
            tarefaPage.ClicarNoBotaoCriarClone();
        }
    }
}
