Feature: ExcluirPerfisGlobais

@ExcluirPerfisGlobais
Scenario: Exclusao de perfis globais
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar perfis globais
	And clicar no radiobox apagar perfil
	And selecionar o perfil
	When clicar no botao enviar
	Then validar a exclusao do perfil no banco