@Retry(3)
Feature: CadastrarCamposPersonalizadosProjetos

@CadastrarCampoPersonalizado
Scenario: Cadastro de campos personalizados
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar campos personalizados
	And preencher o campo nome personalizado
	And clicar no botao novo campo personalizado
	And preencher o campo valores possiveis
	And preencher o campo valor padrao
	And preencher o campo expressao regular
	And selecionar o acesso de leitura
	And selecionar o acesso de escrita
	And preencher o campo comprimento minimo
	And preencher o campo comprimento maximo
	And marcar o checkbox criar tarefas
	And marcar o checkbox resolver tarefas
	And marcar o checkbox fechar tarefas
	And marcar o checkbox relato
	And marcar o checkbox atualizacao
	And marcar o checkbox resolucao
	And marcar o checkbox fechamento
	When clicar no botao atualizar campo personalizado
	Then visualizar a inclusao do campo personalizado no banco


Scenario: Cadastro de campos personalizados java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar com java script na aba gerenciar campos personalizados
	And preencher com java script o campo nome personalizado
	And clicar no botao novo campo personalizado
	And preencher com java script o campo valores possiveis
	And preencher com java script o campo valor padrao
	And preencher com java script o campo expressao regular
	And selecionar o acesso de leitura
	And selecionar o acesso de escrita
	And preencher com java script o campo comprimento minimo
	And preencher com java script o campo comprimento maximo
	And marcar o checkbox criar tarefas
	And marcar o checkbox resolver tarefas
	And marcar o checkbox fechar tarefas
	And marcar o checkbox relato
	And marcar o checkbox atualizacao
	And marcar o checkbox resolucao
	And marcar o checkbox fechamento
	When clicar com java script no botao atualizar campo personalizado
	Then visualizar a inclusao do campo personalizado no banco