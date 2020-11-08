Feature: Pedido de seguro para Carro
	Como usuário 
	desejo uma página com fomulário 
	para que eu possa solicitar seguro para meu carro.

	Scenario: Fazer solicitação de seguro com sucesso
		Given o usuário esteja na página inicial de solicitação do seguro
		And o usuário preenche informações referentes em cada aba
		When o usuário pressionar o botão de enviar
		Then o usuário receberá uma mensagem de sucesso


	