using DesafioAutomacaoMantis.Pages;

namespace DesafioAutomacaoMantis.Flows
{
    public class CadastrarProjetosFlow
    {
        CadastrarProjetosPage cadastrarProjetosPage;
        public CadastrarProjetosFlow()
        {
            cadastrarProjetosPage = new CadastrarProjetosPage();
        }
        public void CadastrarProjetoComSucesso(string nomeProjeto, string estadoProjeto,string visibilidadeProjeto, string descricaoProjeto)
        {
            cadastrarProjetosPage.ClicarBotaoGerenciar();
            cadastrarProjetosPage.NavegarAbaGerenciarProjetos();
            cadastrarProjetosPage.ClicarBotaoNovoProjeto();
            cadastrarProjetosPage.PreencherNomeProjeto(nomeProjeto);
            cadastrarProjetosPage.SelecionarEstadoProjeto(estadoProjeto);
            cadastrarProjetosPage.SelecionarVisibilidadeProjeto(visibilidadeProjeto);
            cadastrarProjetosPage.PreencherAreaDescricao(descricaoProjeto);
            cadastrarProjetosPage.ClicarBotaoAdicionarProjeto();
        }
    }
}
