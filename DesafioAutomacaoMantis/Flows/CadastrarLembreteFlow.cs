using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Pages;

namespace DesafioAutomacaoMantis.Flows
{
    public class CadastrarLembreteFlow
    {
        TarefaPage tarefaPage;
        string idTable;
        public CadastrarLembreteFlow()
        {
            tarefaPage = new TarefaPage();
        }

        public void CadastrarLembreteComSucesso(string destinatario, string texto)
        {
            idTable = ManageDBSteps.GetIdMassaTable("mantis_bug_table");
            tarefaPage.PreencherOCampoTarefa(idTable);
            tarefaPage.ApertarATeclaEnter();
            tarefaPage.ClicarNoBotaoEnviarUmLembrete();
            tarefaPage.SelecionarODestinatario(destinatario);
            tarefaPage.PreencherOTextoDoLembrete(texto);
            tarefaPage.ClicarNoBotaoEnviarLembrete();
        }
    }
}
