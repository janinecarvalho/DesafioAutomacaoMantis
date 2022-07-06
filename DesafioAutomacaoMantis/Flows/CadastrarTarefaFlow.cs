using DesafioAutomacaoMantis.Pages;

namespace DesafioAutomacaoMantis.Flows
{
    public class CadastrarTarefaFlow
    {
        CriarTarefaPage criarTarefaPage;
        public CadastrarTarefaFlow()
        {
            criarTarefaPage = new CriarTarefaPage();
        }

        public void CadastrarTarefaComSucesso(string categoria, string frequencia, string gravidade, string prioridade, string perfil, string atribuir, string resumo, string descricao, string passosReproduzir, string infoAdicionais, string marcador)
        {
            criarTarefaPage.ClicarNoBotaoCriarTarefa();
            criarTarefaPage.SelecionarACategoria(categoria);
            criarTarefaPage.SelecionarAFrequencia(frequencia);
            criarTarefaPage.SelecionarAGravidade(gravidade);
            criarTarefaPage.SelecionarAPrioridade(prioridade);
            criarTarefaPage.SelecionarOCampoPerfil(perfil);
            criarTarefaPage.ClicarNoBotaoMais();
            criarTarefaPage.SelecionarOCampoAtribuir(atribuir);
            criarTarefaPage.PreencherOCampoResumo(resumo);
            criarTarefaPage.PreencherOCampoDescricao(descricao);
            criarTarefaPage.PreencherOCampoPassosParaReproduzir(passosReproduzir);
            criarTarefaPage.PreencherOCampoInformacaoAdicionais(infoAdicionais);
            criarTarefaPage.PreencherOCampoAplicarMarcadores(marcador);
            criarTarefaPage.MarcarOCheckContinuarRelatando();
            criarTarefaPage.ClicarNoBotaoCriarNovaTarefa();
        }
    }
}
