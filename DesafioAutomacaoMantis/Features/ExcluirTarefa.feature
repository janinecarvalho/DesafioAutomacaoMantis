Feature: ExcluirTarefa

@ExcluirTarefa
Scenario: Exclusao de tarefa
	Given que estou na tela inicial
	And clicar no botao ver tarefas
	And clicar no checkbox da tarefa a excluir
	And selecionar o selecionar tudo
	And clicar no botao ok
	When clicar no botao apagar tarefas
	Then validar a exclusao da tarefa no banco


@ExcluirTarefaComJavaScript
Scenario: Exclusao de tarefa java script
	Given que estou na tela inicial
	And clicar no botao ver tarefas
	And clicar no checkbox da tarefa a excluir
	And selecionar o selecionar tudo
	And clicar com java script no botao ok
	When clicar com java script no botao apagar tarefas
	Then validar a exclusao da tarefa no banco