using DesafioAutomacaoMantis.Pages;

namespace DesafioAutomacaoMantis.Flows
{
    public class CadastrarProjetosFlow
    {
        ProjetosPage projetosPage;
        public CadastrarProjetosFlow()
        {
            projetosPage = new ProjetosPage();
        }
        public void CadastrarProjetoComSucesso(string nomeProjeto, string estadoProjeto,string visibilidadeProjeto, string descricaoProjeto)
        {
            projetosPage.ClicarBotaoGerenciar();
            projetosPage.NavegarAbaGerenciarProjetos();
            projetosPage.ClicarBotaoNovoProjeto();
            projetosPage.PreencherNomeProjeto(nomeProjeto);
            projetosPage.SelecionarEstadoProjeto(estadoProjeto);
            projetosPage.SelecionarVisibilidadeProjeto(visibilidadeProjeto);
            projetosPage.PreencherAreaDescricao(descricaoProjeto);
            projetosPage.ClicarBotaoAdicionarProjeto();
        }
    }
}
