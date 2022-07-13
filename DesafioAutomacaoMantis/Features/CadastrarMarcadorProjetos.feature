@Retry(3)
Feature: CadastrarMarcadorProjetos

@CadastrarMarcador
Scenario: Cadastro de marcador
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar marcadores
	And preencher o campo nome do marcador
	And preencher o campo descricao do marcador
	When clicar no botao criar marcador
	Then visualizar a inclusao do marcador


Scenario: Cadastro de marcador java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar com java script  na aba gerenciar marcadores
	And preencher com java script o campo nome do marcador
	And preencher com java script o campo descricao do marcador
	When clicar com java script no botao criar marcador
	Then visualizar a inclusao do marcador