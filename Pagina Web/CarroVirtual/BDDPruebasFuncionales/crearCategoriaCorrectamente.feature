Feature: crearCategoriaCorrectamente
	Para evitar errores al crear una categoria
	Como un usuario del sistema
	Quiero que al llenar todos los campos de forma correcta se cree la nueva categoria

@mytag
Scenario: crear Categoria Correctamente
	Given el nombre de la categoria "Alcazar"
	And la descripcion "somos el grupo de analisis 1"
	When cuando presiones el boton de crea la nueva categoria 
	Then se debe crear la categoria con su nombre y descripcion esto validado con un "si"
