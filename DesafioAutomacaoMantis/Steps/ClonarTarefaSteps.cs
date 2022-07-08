using DesafioAutomacaoMantis.Pages;
using System;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class ClonarTarefaSteps
    {
        CriarTarefaPage criarTarefaPage;

        public ClonarTarefaSteps()
        {
            criarTarefaPage = new CriarTarefaPage();
        }

        [StepDefinition(@"clicar no botao criar clone")]
        public void GivenClicarNoBotaoCriarClone()
        {
            criarTarefaPage.ClicarNoBotaoCriarClone();
        }
    }
}
