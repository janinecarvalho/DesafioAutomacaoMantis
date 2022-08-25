using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Flows;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CadastrarProjetosSteps
    {
        LoginFlow loginFlow;
        ProjetosPage projetosPage;

        public CadastrarProjetosSteps()
        {
            loginFlow = new LoginFlow();
            projetosPage = new ProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_project_table";
        string coluna = "name";
        string textoEsperado = "Automacao Desafio Base2";
        #endregion

        [StepDefinition(@"que estou na tela inicial")]
        public void GivenQueEstouNaTelaInicial()
        {
            loginFlow.RealizarLoginComSucesso(JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("PASSWORD"), JsonBuilder.GetAppSettings("BASE_URL"));
        }
        
        [StepDefinition(@"clicar no botao gerenciar")]
        public void GivenClicarNoBotaoGerenciar()
        {
            projetosPage.ClicarBotaoGerenciar();
        }
        
        [StepDefinition(@"clicar na aba gerenciar projetos")]
        public void GivenClicarNaAbaGerenciarProjetos()
        {
            projetosPage.NavegarAbaGerenciarProjetos();
        }
        
        [StepDefinition(@"clicar no botao criar novo projeto")]
        public void GivenClicarNoBotaoCriarNovoProjeto()
        {
            projetosPage.ClicarBotaoNovoProjeto();
        }
        
        [StepDefinition(@"preencher o campo nome do projeto")]
        public void GivenPreencherOCampoNomeDoProjeto()
        {
            projetosPage.PreencherNomeProjeto(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }
        
        [StepDefinition(@"selecionar o estado do projeto")]
        public void GivenSelecionarOEstadoDoProjeto()
        {
            projetosPage.SelecionarEstadoProjeto(JsonBuilder.GetAppSettings("ESTADO_PROJETO"));
        }
        
        [StepDefinition(@"selecionar a visibilidade do projeto")]
        public void GivenSelecionarAVisibilidadeDoProjeto()
        {
            projetosPage.SelecionarVisibilidadeProjeto(JsonBuilder.GetAppSettings("VISIBILIDADE_PROJETO"));
        }
        
        [StepDefinition(@"preencher o campo descricao do projeto")]
        public void GivenPreencherOCampoDescricaoDoProjeto()
        {
            projetosPage.PreencherAreaDescricao(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao adicionar projeto")]
        public void WhenClicarNoBotaoAdicionarProjeto()
        {
            projetosPage.ClicarBotaoAdicionarProjeto();
        }

        [StepDefinition(@"visualizar a inclusao do projeto no banco")]
        public void ThenVisualizarAInclusaoDoProjetoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }


        [StepDefinition(@"clicar com java script na aba gerenciar projetos")]
        public void GivenClicarComJavaScriptNaAbaGerenciarProjetos()
        {
            projetosPage.ClicarComJavaScriptNaAbaGerenciarProjetos();
        }

        [StepDefinition(@"clicar com java script no botao criar novo projeto")]
        public void GivenClicarComJavaScriptNoBotaoCriarNovoProjeto()
        {
            projetosPage.ClicarComJavaScriptNoBotaoCriarNovoProjeto();
        }

        [StepDefinition(@"preencher com java script o campo nome do projeto")]
        public void GivenPreencherComJavaScriptOCampoNomeDoProjeto()
        {
            projetosPage.PreencherComJavaScriptOCampoNomeDoProjeto(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"preencher com java script o campo descricao do projeto")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoProjeto()
        {
            projetosPage.PreencherComJavaScriptOCampoDescricaoDoProjeto(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }

        [StepDefinition(@"clicar com java script no botao adicionar projeto")]
        public void WhenClicarComJavaScriptNoBotaoAdicionarProjeto()
        {
            projetosPage.ClicarComJavaScriptNoBotaoAdicionarProjeto();
        }
    }
}
