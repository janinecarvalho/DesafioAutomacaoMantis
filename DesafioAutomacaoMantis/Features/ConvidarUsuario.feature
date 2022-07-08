Feature: ConvidarUsuario

@convidarUsuario
Scenario: Convidar usuario
	Given que estou na tela inicial
	And clicar no botao convidar usuarios
	And preencher o campo nome do usuario
	And preencher o campo nome verdadeiro
	And preencher o campo email do usuario
	When clicar no botao criar usuario
	Then visualizar a inclusao do usuario no banco

Scenario: Convidar usuario java script
	Given que estou na tela inicial
	And clicar com java script no botao convidar usuarios
	And preencher com java script o campo nome do usuario
	And preencher com java script o campo nome verdadeiro
	And preencher com java script o campo email do usuario
	When clicar com java script no botao criar usuario
	Then visualizar a inclusao do usuario no banco