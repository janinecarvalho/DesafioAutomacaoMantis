Feature: Login com sucesso

@loginComSucesso
Scenario: Login com sucesso
	Given que estou na tela de login
	And preencher o usuario <login>
	And clicar no botao entrar
	And preencher a senha <senha>
	When clicar no botao logar
	Then visualizo o painel do usuario

	Examples: 
	| login         | senha    |
	| administrator | 123456A@ |
	| janine        | 123456A@ |


@loginComSucessoJavaScript
Scenario: Login com sucesso java script
	Given que estou na tela de login
	And preencher com java script o usuario <login>
	And clicar com java script no botao entrar 
	And preencher com java script a senha <senha>
	When clicar com java script no botao logar
	Then visualizo o painel do usuario

	Examples: 
	| login         | senha    |
	| administrator | 123456A@ |
	| janine        | 123456A@ |