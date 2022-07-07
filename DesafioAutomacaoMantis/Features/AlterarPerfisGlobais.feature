Feature: AlterarPerfisGlobais

@AlterarPerfisGlobais
Scenario: Alteracao de perfis globais
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar perfis globais
	And clicar no radiobox editar perfil
	And selecionar o perfil
	And clicar no botao enviar
	And preencher o campo plataforma atualizado
	And preencher o campo so atualizado
	And preencher o campo versao so atualizado
	And preencher o campo descricao adicional atualizado
	When clicar no botao atualizar perfil
	Then visualizar a alteracao do perfil no banco


Scenario: Alteracao de perfis globais java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar perfis globais
	And clicar no radiobox editar perfil
	And selecionar o perfil
	And clicar com java script no botao enviar
	And preencher com java script o campo plataforma atualizado
	And preencher com java script o campo so atualizado
	And preencher com java script o campo versao so atualizado
	And preencher com java script o campo descricao adicional atualizado
	When clicar com java script no botao atualizar perfil
	Then visualizar a alteracao do perfil no banco