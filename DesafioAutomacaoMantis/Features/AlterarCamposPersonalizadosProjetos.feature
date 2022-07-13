@Retry(3)
Feature: AlterarCamposPersonalizadosProjetos

@AlterarCampoPersonalizado
Scenario: Alteracao de campo personalizado
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar campos personalizados
	And clicar no campo personalizado para alterar
	And selecionar o tipo
	And preencher o campo valores possiveis
	And preencher o campo valor padrao
	And preencher o campo expressao regular
	And selecionar o acesso de leitura
	And selecionar o acesso de escrita
	And preencher o campo comprimento minimo
	And preencher o campo comprimento maximo
	And desmarcar o checkbox criar tarefas
	And desmarcar o checkbox resolver tarefas
	And desmarcar o checkbox fechar tarefas
	And desmarcar o checkbox relato
	And desmarcar o checkbox atualizacao
	And desmarcar o checkbox resolucao
	And desmarcar o checkbox fechamento
	When clicar no botao atualizar campo personalizado
	Then visualizar a alteracao do campo personalizado no banco


Scenario: Alteracao de campo personalizado java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar campos personalizados
	And clicar com java script no campo personalizado para alterar
	And selecionar o tipo
	And preencher o campo valores possiveis
	And preencher o campo valor padrao
	And preencher o campo expressao regular
	And selecionar o acesso de leitura
	And selecionar o acesso de escrita
	And preencher o campo comprimento minimo
	And preencher o campo comprimento maximo
	And desmarcar o checkbox criar tarefas
	And desmarcar o checkbox resolver tarefas
	And desmarcar o checkbox fechar tarefas
	And desmarcar o checkbox relato
	And desmarcar o checkbox atualizacao
	And desmarcar o checkbox resolucao
	And desmarcar o checkbox fechamento
	When clicar no botao atualizar campo personalizado
	Then visualizar a alteracao do campo personalizado no banco