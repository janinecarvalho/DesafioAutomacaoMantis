Feature: RecuperarSenha

@recuperarSenha
Scenario: Recuperar senha
	Given que estou na tela de login
	And clicar no botao criar nova conta
	And clicar no botao perdeu a sua senha
	And preencher o campo nome de usuario
	And preencher o campo email
	When clicar no botao enviar da tela de recuperacao
	Then visualizar a tela de login

Scenario: Recuperar senha java script
	Given que estou na tela de login
	And clicar no botao criar nova conta
	And clicar no botao perdeu a sua senha
	And preencher o campo nome de usuario
	And preencher o campo email
	When clicar no botao enviar da tela de recuperacao
	Then visualizar a tela de login