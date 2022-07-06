Feature: AlterarTarefa

@AlterarTarefa
Scenario: Alteracao de tarefa
	Given que estou na tela inicial
	And clicar no botao ver tarefas
	And clicar no botao atualizar
	And selecionar a categoria atualizado
	And selecionar a visibilidade atualizado
	And selecionar o campo atribuir atualizado
	And selecionar a prioridade atualizado
	And selecionar a gravidade atualizado
	And selecionar o campo estado
	And selecionar o campo resolucao
	When clicar no botao atualizar informacao
	Then vizualizar a alteracao da tarefa no banco


Scenario: Alteracao de tarefa java script
	Given que estou na tela inicial
	And clicar com java script no botao ver tarefas
	And clicar com java script no botao atualizar
	And selecionar a categoria atualizado
	And selecionar a visibilidade atualizado
	And selecionar o campo atribuir atualizado
	And selecionar a prioridade atualizado
	And selecionar a gravidade atualizado
	And selecionar o campo estado
	And selecionar o campo resolucao
	When clicar com java script no botao atualizar informacao
	Then vizualizar a alteracao da tarefa no banco