@Retry(3)
Feature: ClonarTarefa

@clonarTarefa
Scenario: Clonar tarefa
	Given que estou na tela inicial
	And preencher o campo tarefa
	And apertar a tecla enter
	And clicar no botao criar clone
	And selecionar a categoria
	And selecionar a frequencia
	And selecionar a gravidade
	And selecionar a prioridade
	And selecionar o campo perfil
	And selecionar o campo atribuir
	And preencher o campo resumo
	And preencher o campo descricao
	And preencher o campo passos para reproduzir
	And preencher o campo informacao adicionais
	And preencher o campo aplicar marcadores
	And marcar o check continuar relatando
	When clicar no botao criar nova tarefa
	Then visualizar a inclusao da tarefa no banco