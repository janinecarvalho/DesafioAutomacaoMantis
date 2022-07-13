@Retry(3)
Feature: ExcluirLembrete

@excluirLembrete
Scenario: Excluir lembrete
	Given que estou na tela inicial
	And preencher o campo tarefa
	And apertar a tecla enter
	And clicar no botao apagar lembrete
	When clicar no botao apagar anotacao
	Then visualizar a exclusao do lembrete no banco