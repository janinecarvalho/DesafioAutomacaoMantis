@Retry(3)
Feature: ExcluirVersaoProjeto

@ExcluirVersaoProjeto
Scenario: Excluir versao projeto
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no projeto
	And clicar no botao apagar da versao do projeto
	When clicar no botao apagar versao
	Then visualizar a exclusao da versao no banco