Feature: CrearCategoriaCorrecto
	Para evitar errores en la creacion de categorias
	Como un usuario del sistema
	Quiero que al ingresar todos los campos validos esta sea creada correctamente

@mytag
Scenario: CrearCategoriaCorrecto
	Given un nombre no existente como "pruebaBDD"
	And de descripcion "Soy una prueba funcional en BDD"
	When presiono crear categoria
	Then el sistema debe crear la categoria en el sistema validado con un "true"
