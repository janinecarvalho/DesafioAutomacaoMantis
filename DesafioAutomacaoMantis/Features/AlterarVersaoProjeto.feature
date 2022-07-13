@Retry(3)
Feature: AlterarVersaoProjeto

@AlterarVersaoProjeto
Scenario: Alterar versao projeto
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no projeto
	And clicar no botao alterar da versao do projeto
	And preencher o nome da versao do projeto atualizado
	And preencher o campo descricao versao do projeto
	And marcar o check liberada
	When clicar no botao atualizar versao
	Then visualizar a alteracao do versao no banco