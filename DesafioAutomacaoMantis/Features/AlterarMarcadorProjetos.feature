Feature: AlterarMarcadorProjetos

@AlterarMarcador
Scenario: Alteracao de marcador 
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar marcadores
	And clicar no marcador
	And clicar no botao atualizar marcador
	And preencher o campo nome do marcador atualizado
	And selecionar o criador atualizado
	And preencher o campo descricao do marcador atualizado
	When clicar no botao atualizar marcador
	Then visualizar a alteracao do marcador no banco


Scenario: Alteracao de marcador java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar marcadores
	And clicar com java script no marcador
	And clicar com java script no botao atualizar marcador
	And preencher com java script o campo nome do marcador atualizado
	And selecionar o criador atualizado
	And preencher com java script o campo descricao do marcador atualizado
	When clicar no botao atualizar marcador
	Then visualizar a alteracao do marcador no banco