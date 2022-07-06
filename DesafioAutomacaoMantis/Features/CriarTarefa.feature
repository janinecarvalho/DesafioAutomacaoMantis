Feature: CriarTarefa

@CriarTarefa
Scenario: Criar tarefa
	Given que estou na tela inicial
	And clicar no botao criar tarefa
	And selecionar a categoria
	And selecionar a frequencia
	And selecionar a gravidade
	And selecionar a prioridade
	And selecionar o campo perfil
	And selecionar o campo atribuir
	And preencher o campo resumo
	And preencher o campo descricao
	And preencher o campo passos para reproduzir
	And preencher o campo informacao adicionais
	And preencher o campo aplicar marcadores
	And marcar o check continuar relatando
	When clicar no botao criar nova tarefa
	Then vizualizar a inclusao da tarefa no banco


Scenario: Criar tarefa java script
	Given que estou na tela inicial
	And clicar com java script no botao criar tarefa
	And selecionar a categoria
	And selecionar a frequencia
	And selecionar a gravidade
	And selecionar a prioridade
	And selecionar o campo perfil
	And selecionar o campo atribuir
	And preencher com java script o campo resumo
	And preencher com java script o campo descricao
	And preencher com java script o campo passos para reproduzir
	And preencher com java script o campo informacao adicionais
	And preencher com java script o campo aplicar marcadores
	And marcar o check continuar relatando
	When clicar com java script no botao criar nova tarefa
	Then vizualizar a inclusao da tarefa no banco