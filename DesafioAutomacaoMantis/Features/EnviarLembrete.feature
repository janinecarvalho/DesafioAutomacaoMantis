@Retry(3)
Feature: EnviarLembrete

@enviarLembrete
Scenario: Enviar lembrete
	Given que estou na tela inicial
	And preencher o campo tarefa
	And apertar a tecla enter
	And clicar no botao enviar um lembrete
	And selecionar o destinatario
	And preencher o texto do lembrete
	When clicar no botao enviar lembrete
	Then visualizar a inclusao do lembrete no banco