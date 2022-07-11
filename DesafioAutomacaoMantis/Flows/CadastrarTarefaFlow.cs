using DesafioAutomacaoMantis.Pages;

namespace DesafioAutomacaoMantis.Flows
{
    public class CadastrarTarefaFlow
    {
        TarefaPage tarefaPage;
        public CadastrarTarefaFlow()
        {
            tarefaPage = new TarefaPage();
        }

        public void CadastrarTarefaComSucesso(string categoria, string frequencia, string gravidade, string prioridade, string perfil, string atribuir, string resumo, string descricao, string passosReproduzir, string infoAdicionais, string marcador)
        {
            tarefaPage.ClicarNoBotaoCriarTarefa();
            tarefaPage.SelecionarACategoria(categoria);
            tarefaPage.SelecionarAFrequencia(frequencia);
            tarefaPage.SelecionarAGravidade(gravidade);
            tarefaPage.SelecionarAPrioridade(prioridade);
            tarefaPage.SelecionarOCampoPerfil(perfil);
            tarefaPage.ClicarNoBotaoMais();
            tarefaPage.SelecionarOCampoAtribuir(atribuir);
            tarefaPage.PreencherOCampoResumo(resumo);
            tarefaPage.PreencherOCampoDescricao(descricao);
            tarefaPage.PreencherOCampoPassosParaReproduzir(passosReproduzir);
            tarefaPage.PreencherOCampoInformacaoAdicionais(infoAdicionais);
            tarefaPage.PreencherOCampoAplicarMarcadores(marcador);
            tarefaPage.MarcarOCheckContinuarRelatando();
            tarefaPage.ClicarNoBotaoCriarNovaTarefa();
        }
    }
}
