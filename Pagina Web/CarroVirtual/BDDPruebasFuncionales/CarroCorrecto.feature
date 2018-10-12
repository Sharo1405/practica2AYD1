Feature: CarroCorrecto
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Búsqueda de un producto por medio de su código dentro del carro de compras
	Given el codigo "1" de un producto que está dentro del carro de compras	
	When al cargar la pantalla del carrito
	Then se encontrará dicho producto y devolverá un "true"
