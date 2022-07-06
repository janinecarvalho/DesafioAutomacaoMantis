Feature: Cadastro Projetos

@CadastroDeProjeto
Scenario: Cadastro de projeto
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no botao criar novo projeto
	And preencher o campo nome do projeto
	And selecionar o estado do projeto
	And selecionar a visibilidade do projeto
	And preencher o campo descricao do projeto
	When clicar no botao adicionar projeto
	Then visualizar a inclusao do projeto no banco


Scenario: Cadastro de projeto java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar com java script na aba gerenciar projetos
	And clicar com java script no botao criar novo projeto
	And preencher com java script o campo nome do projeto
	And selecionar o estado do projeto
	And selecionar a visibilidade do projeto
	And preencher com java script o campo descricao do projeto
	When clicar com java script no botao adicionar projeto
	Then visualizar a inclusao do projeto no banco