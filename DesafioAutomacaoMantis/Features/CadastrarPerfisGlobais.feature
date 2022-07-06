Feature: CadastrarPerfisGlobais

@CadastrarPerfisGlobais
Scenario: Cadastro de perfis globais
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar perfis globais
	And preencher o campo plataforma
	And preencher o campo so
	And preencher o campo versao so
	And preencher o campo descricao adicional
	When clicar no botao adicionar perfil
	Then vizualizar a inclusao de perfil


Scenario: Cadastro de perfis globais java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar com java scrip na aba gerenciar perfis globais
	And preencher com java scrip o campo plataforma
	And preencher com java scrip o campo so
	And preencher com java scrip o campo versao so
	And preencher com java scrip o campo descricao adicional
	When clicar com java scrip no botao adicionar perfil
	Then vizualizar a inclusao de perfil