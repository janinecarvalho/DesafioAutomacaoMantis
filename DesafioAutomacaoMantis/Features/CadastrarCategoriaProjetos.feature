@Retry(3)
Feature: CadastrarCategoriaProjetos

@CadastrarCategoria
Scenario: Cadastro de categoria
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And preencher o campo nome da categoria
	When clicar no botao adicionar categoria
	Then visualizar a inclusao da categoria no banco

@CadastrarCategoriaComJavaScript
Scenario: Cadastro de categoria java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And preencher com java script o campo nome da categoria
	When clicar com java script no botao adicionar categoria
	Then visualizar a inclusao da categoria no banco