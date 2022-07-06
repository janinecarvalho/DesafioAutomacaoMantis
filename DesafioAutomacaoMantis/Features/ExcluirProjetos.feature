Feature: Excluir Projetos


@ExcluirProjeto
Scenario: Exclusao de projeto
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no projeto para excluir
	And clicar no botao apagar projeto
	When clicar no botao apagar projeto
	Then validar a exclusao no banco


Scenario: Exclusao de projeto java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar com java script no projeto para excluir
	And clicar com java script no botao apagar projeto
	When clicar no botao apagar projeto
	Then validar a exclusao no banco