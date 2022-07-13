@Retry(3)
Feature: AlterarCategoriaProjetos

@AlterarCategoria
Scenario: Alteracao de categoria
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar no botao alterar
	And preencher o campo nome da categoria atualizado
	And selecionar a atribuicao da categoria
	When clicar no botao atualizar categoria
	Then visualizar a alteracao da categoria no banco


@AlterarCategoriaComJavaScript
Scenario: Alteracao de categoria java script
	Given que estou na tela inicial
	And clicar no botao gerenciar
	And clicar na aba gerenciar projetos
	And clicar com java script no botao alterar
	And preencher com java script o campo nome da categoria atualizado
	And selecionar com java script a atribuicao da categoria
	When clicar com java script no botao atualizar categoria
	Then visualizar a alteracao da categoria no banco