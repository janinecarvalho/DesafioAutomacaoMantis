Feature: ExcluirCamposPersonalizadosProjetos

@ExcluirCampoPersonalizadp
Scenario: Exclusao de campos personalizados
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar campos personalizados
	And clicar no campo personalizado para excluir
	And clicar no botao apagar campo personalizado
	When clicar no botao apagar campo
	Then visualizar a exclusao do campo personalizado no banco


Scenario: Exclusao de campos personalizados java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar campos personalizados
	And clicar com java script no campo personalizado para excluir
	And clicar com java script no botao apagar campo personalizado
	When clicar com java script no botao apagar campo
	Then visualizar a exclusao do campo personalizado no banco