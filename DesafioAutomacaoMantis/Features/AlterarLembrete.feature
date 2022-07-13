Feature: AlterarLembrete

@alterarLembrete
Scenario: Alterar lembrete
	Given que estou na tela inicial
	And preencher o campo tarefa
	And apertar a tecla enter
	And clicar no botao alterar lembrete
	And atualizar o texto do lembrete
	When clicar no botao atualizar informacao do lembrete
	Then visualizar a alteracao do lembrete no banco