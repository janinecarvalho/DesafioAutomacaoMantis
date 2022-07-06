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
        CadastrarProjetosPage gerenciarProjetosPage;
        public CadastrarProjetosSteps()
        {
            loginFlow = new LoginFlow();
            gerenciarProjetosPage = new CadastrarProjetosPage();
        }
        
        [StepDefinition(@"que estou na tela inicial")]
        public void GivenQueEstouNaTelaInicial()
        {
            loginFlow.RealizarLoginComSucesso(JsonBuilder.GetAppSettings("USER"), JsonBuilder.GetAppSettings("PASSWORD"), JsonBuilder.GetAppSettings("BASE_URL"));
        }
        
        [StepDefinition(@"clicar no botao gerenciar")]
        public void GivenClicarNoBotaoGerenciar()
        {
            gerenciarProjetosPage.ClicarBotaoGerenciar();
        }
        
        [StepDefinition(@"clicar na aba gerenciar projetos")]
        public void GivenClicarNaAbaGerenciarProjetos()
        {
            gerenciarProjetosPage.NavegarAbaGerenciarProjetos();
        }
        
        [StepDefinition(@"clicar no botao criar novo projeto")]
        public void GivenClicarNoBotaoCriarNovoProjeto()
        {
            gerenciarProjetosPage.ClicarBotaoNovoProjeto();
        }
        
        [StepDefinition(@"preencher o campo nome do projeto")]
        public void GivenPreencherOCampoNomeDoProjeto()
        {
            gerenciarProjetosPage.PreencherNomeProjeto(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }
        
        [StepDefinition(@"selecionar o estado do projeto")]
        public void GivenSelecionarOEstadoDoProjeto()
        {
            gerenciarProjetosPage.SelecionarEstadoProjeto(JsonBuilder.GetAppSettings("ESTADO_PROJETO"));
        }
        
        [StepDefinition(@"selecionar a visibilidade do projeto")]
        public void GivenSelecionarAVisibilidadeDoProjeto()
        {
            gerenciarProjetosPage.SelecionarVisibilidadeProjeto(JsonBuilder.GetAppSettings("VISIBILIDADE_PROJETO"));
        }
        
        [StepDefinition(@"preencher o campo descricao do projeto")]
        public void GivenPreencherOCampoDescricaoDoProjeto()
        {
            gerenciarProjetosPage.PreencherAreaDescricao(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }
        
        [StepDefinition(@"clicar no botao adicionar projeto")]
        public void WhenClicarNoBotaoAdicionarProjeto()
        {
            gerenciarProjetosPage.ClicarBotaoAdicionarProjeto();
        }

        [StepDefinition(@"visualizar a inclusao do projeto no banco")]
        public void ThenVisualizarAInclusaoDoProjetoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_project_table", "name", "Automacao Desafio Base2"));
        }


        [StepDefinition(@"clicar com java script na aba gerenciar projetos")]
        public void GivenClicarComJavaScriptNaAbaGerenciarProjetos()
        {
            gerenciarProjetosPage.ClicarComJavaScriptNaAbaGerenciarProjetos();
        }

        [StepDefinition(@"clicar com java script no botao criar novo projeto")]
        public void GivenClicarComJavaScriptNoBotaoCriarNovoProjeto()
        {
            gerenciarProjetosPage.ClicarComJavaScriptNoBotaoCriarNovoProjeto();
        }

        [StepDefinition(@"preencher com java script o campo nome do projeto")]
        public void GivenPreencherComJavaScriptOCampoNomeDoProjeto()
        {
            gerenciarProjetosPage.PreencherComJavaScriptOCampoNomeDoProjeto(JsonBuilder.GetAppSettings("NOME_PROJETO"));
        }

        [StepDefinition(@"preencher com java script o campo descricao do projeto")]
        public void GivenPreencherComJavaScriptOCampoDescricaoDoProjeto()
        {
            gerenciarProjetosPage.PreencherComJavaScriptOCampoDescricaoDoProjeto(JsonBuilder.GetAppSettings("DESCRICAO_PROJETO"));
        }

        [StepDefinition(@"clicar com java script no botao adicionar projeto")]
        public void WhenClicarComJavaScriptNoBotaoAdicionarProjeto()
        {
            gerenciarProjetosPage.ClicarComJavaScriptNoBotaoAdicionarProjeto();
        }
    }
}
