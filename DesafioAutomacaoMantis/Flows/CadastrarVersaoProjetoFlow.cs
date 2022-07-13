using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;

namespace DesafioAutomacaoMantis.Flows
{
    public class CadastrarVersaoProjetoFlow
    {
        ProjetosPage projetosPage;
        public CadastrarVersaoProjetoFlow()
        {
            projetosPage = new ProjetosPage();
        }

        public void CadastrarVersaoProjetoComSucesso()
        {
            projetosPage.PreencherONomeDaVersaoDoProjeto(JsonBuilder.GetAppSettings("VERSAO_PROJETO"));
            projetosPage.ClicarNoBotaoAdicionarVersao();
        }
    }
}
