@Retry(3)
Feature: AlterarProjetos

@AlterarProjeto
Scenario: Alteracao de projeto
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no projeto para alterar
	And preencher o campo nome do projeto atualizado
	And selecionar o estado do projeto atualizado
	And selecionar a visibilidade do projeto atualizado
	And preencher o campo descricao do projeto atualizado
	When clicar no botao atualizar projeto
	Then visualizar a alteracao do projeto no banco


Scenario: Alteracao de projeto java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no projeto para alterar
	And preencher com java script o campo nome do projeto atualizado
	And selecionar o estado do projeto atualizado
	And selecionar a visibilidade do projeto atualizado
	And preencher com java script o campo descricao do projeto atualizado
	When clicar com java script no botao atualizar projeto
	Then visualizar a alteracao do projeto no banco