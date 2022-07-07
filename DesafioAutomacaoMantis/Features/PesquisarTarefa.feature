Feature: PesquisarTarefa

@pesquisarTarefa
Scenario: Pesquisar tarefa
	Given que estou na tela inicial
	And preencher o campo tarefa
	When apertar a tecla enter
	Then visualizar o numero da tarefa 