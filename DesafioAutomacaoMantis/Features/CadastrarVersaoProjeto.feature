@Retry(3)
Feature: CadastrarVersaoProjeto

@CadastrarVersaoProjeto
Scenario: Cadastrar versao de projeto
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no projeto
	And preencher o nome da versao do projeto
	When clicar no botao adicionar versao
	Then visualizar a inclusao do versao no banco