@Retry(3)
Feature: ExcluirCadastroCategoriaProjetos

@ExcluirCategoria
Scenario: Exclusao de categoria
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no botao apagar
	When clicar no botao apagar categoria
	Then visualizar a exclusao da categoria no banco


Scenario: Exclusao de categoria java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar com java script no botao apagar
	When clicar com java script no botao apagar categoria
	Then visualizar a exclusao da categoria no banco