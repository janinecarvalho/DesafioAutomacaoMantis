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
        CadastrarCamposPersonalizadosProjetosPage CadastrarCamposPersonalizadosProjetosPage;
        public CadastrarCamposPersonalizadosProjetosSteps()
        {
            CadastrarCamposPersonalizadosProjetosPage = new CadastrarCamposPersonalizadosProjetosPage();
        }
        [StepDefinition(@"clicar na aba gerenciar campos personalizados")]
        public void GivenClicarNaAbaGerenciarCamposPersonalizados()
        {
            CadastrarCamposPersonalizadosProjetosPage.ClicarNaAbaGerenciarCamposPersonalizados();
        }
        
        [StepDefinition(@"preencher o campo nome personalizado")]
        public void GivenPreencherOCampoNomePersonalizado()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherOCampoNomePersonalizado("Pipeline" + JsonBuilder.GetAppSettings("USER"));
        }
        
        [StepDefinition(@"clicar no botao novo campo personalizado")]
        public void GivenClicarNoBotaoNovoCampoPersonalizado()
        {
            CadastrarCamposPersonalizadosProjetosPage.ClicarNoBotaoNovoCampoPersonalizado();
        }
        
        [StepDefinition(@"preencher o campo valores possiveis")]
        public void GivenPreencherOCampoValoresPossiveis()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherOCampoValoresPossiveis(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"preencher o campo valor padrao")]
        public void GivenPreencherOCampoValorPadrao()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherOCampoValorPadrao(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"preencher o campo expressao regular")]
        public void GivenPreencherOCampoExpressaoRegular()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherOCampoExpressaoRegular("R");
        }
        
        [StepDefinition(@"selecionar o acesso de leitura")]
        public void GivenSelecionarOAcessoDeLeitura()
        {
            CadastrarCamposPersonalizadosProjetosPage.SelecionarOAcessoDeLeitura("administrador");
        }
        
        [StepDefinition(@"selecionar o acesso de escrita")]
        public void GivenSelecionarOAcessoDeEscrita()
        {
            CadastrarCamposPersonalizadosProjetosPage.SelecionarOAcessoDeEscrita("administrador");
        }
        
        [StepDefinition(@"preencher o campo comprimento minimo")]
        public void GivenPreencherOCampoComprimentoMinimo()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherOCampoComprimentoMinimo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"preencher o campo comprimento maximo")]
        public void GivenPreencherOCampoComprimentoMaximo()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherOCampoComprimentoMaximo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }
        
        [StepDefinition(@"marcar o checkbox criar tarefas")]
        public void GivenMarcarOCheckboxCriarTarefas()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxCriarTarefas();
        }
        
        [StepDefinition(@"marcar o checkbox resolver tarefas")]
        public void GivenMarcarOCheckboxResolverTarefas()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxResolverTarefas();
        }
        
        [StepDefinition(@"marcar o checkbox fechar tarefas")]
        public void GivenMarcarOCheckboxFecharTarefas()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxFecharTarefas();
        }
        
        [StepDefinition(@"marcar o checkbox relato")]
        public void GivenMarcarOCheckboxRelato()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxRelato();
        }
        
        [StepDefinition(@"marcar o checkbox atualizacao")]
        public void GivenMarcarOCheckboxAtualizacao()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxAtualizacao();
        }
        
        [StepDefinition(@"marcar o checkbox resolucao")]
        public void GivenMarcarOCheckboxResolucao()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxResolucao();
        }
        
        [StepDefinition(@"marcar o checkbox fechamento")]
        public void GivenMarcarOCheckboxFechamento()
        {
            CadastrarCamposPersonalizadosProjetosPage.MarcarOCheckboxFechamento();
        }
        
        [StepDefinition(@"clicar no botao atualizar campo personalizado")]
        public void WhenClicarNoBotaoAtualizarCampoPersonalizado()
        {
            CadastrarCamposPersonalizadosProjetosPage.ClicarNoBotaoAtualizarCampoPersonalizado();
        }

        [Then(@"vizualizar a inclusao do campo personalizado no banco")]
        public void ThenVizualizarAInclusaoDoCampoPersonalizadoNoBanco()
        {
            Assert.IsTrue(ManageDBSteps.ValidarInclusaoAlteracaoBD("mantis_user_profile_table", "description", "Projeto Desafio Automacao Base2 - Selenium Specflow .NetCore."));
        }

        [StepDefinition(@"clicar com java script na aba gerenciar campos personalizados")]
        public void GivenClicarComJavaScriptNaAbaGerenciarCamposPersonalizados()
        {
            CadastrarCamposPersonalizadosProjetosPage.ClicarComJavaScriptNaAbaGerenciarCamposPersonalizados();
        }

        [StepDefinition(@"preencher com java script o campo nome personalizado")]
        public void GivenPreencherComJavaScriptOCampoNomePersonalizado()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoNomePersonalizado("Pipeline" + JsonBuilder.GetAppSettings("USER"));
        }

        [StepDefinition(@"preencher com java script o campo valores possiveis")]
        public void GivenPreencherComJavaScriptOCampoValoresPossiveis()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoValoresPossiveis(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"preencher com java script o campo valor padrao")]
        public void GivenPreencherComJavaScriptOCampoValorPadrao()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoValorPadrao(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"preencher com java script o campo expressao regular")]
        public void GivenPreencherComJavaScriptOCampoExpressaoRegular()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoExpressaoRegular("R");
        }

        [StepDefinition(@"preencher com java script o campo comprimento minimo")]
        public void GivenPreencherComJavaScriptOCampoComprimentoMinimo()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoComprimentoMinimo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"preencher com java script o campo comprimento maximo")]
        public void GivenPreencherComJavaScriptOCampoComprimentoMaximo()
        {
            CadastrarCamposPersonalizadosProjetosPage.PreencherComJavaScriptOCampoComprimentoMaximo(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"));
        }

        [StepDefinition(@"clicar com java script no botao atualizar campo personalizado")]
        public void WhenClicarComJavaScriptNoBotaoAtualizarCampoPersonalizado()
        {
            CadastrarCamposPersonalizadosProjetosPage.ClicarComJavaScriptNoBotaoAtualizarCampoPersonalizado();
        }

    }
}
