@Retry(3)
Feature: ExcluirMarcadorProjetos

@ExcluirMarcador
Scenario: Exclusao de marcador
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar marcadores
	And clicar no marcador
	And clicar no botao apagar marcador
	When clicar no botao apagar marcador
	Then visualizar a exclusao do marcador no banco

	Scenario: Exclusao de marcador java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar marcadores
	And clicar no marcador
	And clicar com java script no botao apagar marcador
	When clicar no botao apagar marcador
	Then visualizar a exclusao do marcador no banco