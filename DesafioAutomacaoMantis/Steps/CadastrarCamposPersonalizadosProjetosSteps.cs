using DesafioAutomacaoMantis.DataBaseSteps;
using DesafioAutomacaoMantis.Helpers;
using DesafioAutomacaoMantis.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DesafioAutomacaoMantis.Steps
{
    [Binding]
    public class CadastrarCamposPersonalizadosProjetosSteps
    {
        CamposPersonalizadosProjetosPage CamposPersonalizadosProjetosPage;
        public CadastrarCamposPersonalizadosProjetosSteps()
        {
            CamposPersonalizadosProjetosPage = new CamposPersonalizadosProjetosPage();
        }

        #region Parameters of test
        string tabela = "mantis_user_profile_table";
        string coluna = "description";
        string textoEsperado = "Projeto Desafio Automacao Base2 - Selenium Specflow .NetCore.";
        #endregion

        [StepDefinition(@"clicar na aba gerenciar campos personalizados")]
        public void GivenClicarNaAbaGerenciarCamposPersonalizados()
        {
            CamposPersonalizadosProjetosPage.ClicarNaAbaGerenciarCamposPersonalizados();
        }
        
        [StepDefinition(@"preencher o campo nome personalizado")]
        public void GivenPreencherOCampoNomePersonalizado()
        {
            CamposPersonalizadosProjetosPage.PreencherOCampoNomePersonalizado("Pipeline" + JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"clicar no botao novo campo personalizado")]
        public void GivenClicarNoBotaoNovoCampoPersonalizado()
        {
            CamposPersonalizadosProjetosPage.ClicarNoBotaoNovoCampoPersonalizado();
        }
        
        [StepDefinition(@"preencher o campo valores possiveis")]
        public void GivenPreencherOCampoValoresPossiveis()
        {
            CamposPersonalizadosProjetosPage.PreencherOCampoValoresPossiveis(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"preencher o campo valor padrao")]
        public void GivenPreencherOCampoValorPadrao()
        {
            CamposPersonalizadosProjetosPage.PreencherOCampoValorPadrao(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"preencher o campo expressao regular")]
        public void GivenPreencherOCampoExpressaoRegular()
        {
            CamposPersonalizadosProjetosPage.PreencherOCampoExpressaoRegular("R");
        }
        
        [StepDefinition(@"selecionar o acesso de leitura")]
        public void GivenSelecionarOAcessoDeLeitura()
        {
            CamposPersonalizadosProjetosPage.SelecionarOAcessoDeLeitura("administrador");
        }
        
        [StepDefinition(@"selecionar o acesso de escrita")]
        public void GivenSelecionarOAcessoDeEscrita()
        {
            CamposPersonalizadosProjetosPage.SelecionarOAcessoDeEscrita("administrador");
        }
        
        [StepDefinition(@"preencher o campo comprimento minimo")]
        public void GivenPreencherOCampoComprimentoMinimo()
        {
            CamposPersonalizadosProjetosPage.PreencherOCampoComprimentoMinimo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"preencher o campo comprimento maximo")]
        public void GivenPreencherOCampoComprimentoMaximo()
        {
            CamposPersonalizadosProjetosPage.PreencherOCampoComprimentoMaximo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"marcar o checkbox criar tarefas")]
        public void GivenMarcarOCheckboxCriarTarefas()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxCriarTarefas();
        }
        
        [StepDefinition(@"marcar o checkbox resolver tarefas")]
        public void GivenMarcarOCheckboxResolverTarefas()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxResolverTarefas();
        }
        
        [StepDefinition(@"marcar o checkbox fechar tarefas")]
        public void GivenMarcarOCheckboxFecharTarefas()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxFecharTarefas();
        }
        
        [StepDefinition(@"marcar o checkbox relato")]
        public void GivenMarcarOCheckboxRelato()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxRelato();
        }
        
        [StepDefinition(@"marcar o checkbox atualizacao")]
        public void GivenMarcarOCheckboxAtualizacao()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxAtualizacao();
        }
        
        [StepDefinition(@"marcar o checkbox resolucao")]
        public void GivenMarcarOCheckboxResolucao()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxResolucao();
        }
        
        [StepDefinition(@"marcar o checkbox fechamento")]
        public void GivenMarcarOCheckboxFechamento()
        {
            CamposPersonalizadosProjetosPage.MarcarOCheckboxFechamento();
        }
        
        [StepDefinition(@"clicar no botao atualizar campo personalizado")]
        public void WhenClicarNoBotaoAtualizarCampoPersonalizado()
        {
            CamposPersonalizadosProjetosPage.ClicarNoBotaoAtualizarCampoPersonalizado();
        }

        [Then(@"visualizar a inclusao do campo personalizado no banco")]
        public void ThenVisualizarAInclusaoDoCampoPersonalizadoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD(tabela, coluna, textoEsperado));
        }

        [StepDefinition(@"clicar com java script na aba gerenciar campos personalizados")]
        public void GivenClicarComJavaScriptNaAbaGerenciarCamposPersonalizados()
        {
            CamposPersonalizadosProjetosPage.ClicarComJavaScriptNaAbaGerenciarCamposPersonalizados();
        }

        [StepDefinition(@"preencher com java script o campo nome personalizado")]
        public void GivenPreencherComJavaScriptOCampoNomePersonalizado()
        {
            CamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoNomePersonalizado("Pipeline" + JsonBuilder.GetAppSettings("USER"));
        }

        [StepDefinition(@"preencher com java script o campo valores possiveis")]
        public void GivenPreencherComJavaScriptOCampoValoresPossiveis()
        {
            CamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoValoresPossiveis(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"preencher com java script o campo valor padrao")]
        public void GivenPreencherComJavaScriptOCampoValorPadrao()
        {
            CamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoValorPadrao(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"preencher com java script o campo expressao regular")]
        public void GivenPreencherComJavaScriptOCampoExpressaoRegular()
        {
            CamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoExpressaoRegular("R");
        }

        [StepDefinition(@"preencher com java script o campo comprimento minimo")]
        public void GivenPreencherComJavaScriptOCampoComprimentoMinimo()
        {
            CamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoComprimentoMinimo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"preencher com java script o campo comprimento maximo")]
        public void GivenPreencherComJavaScriptOCampoComprimentoMaximo()
        {
            CamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoComprimentoMaximo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"clicar com java script no botao atualizar campo personalizado")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarCampoPersonalizado()
        {
            CamposPersonalizadosProjetosPage.ClicarComJavaScriptNoBotaoAtualizarCampoPersonalizado();
        }

    }
}
