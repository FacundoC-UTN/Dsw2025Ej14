# Ejercicio N° 14
## Desarrollo de Software
### API Web

## Tareas
Bifurcar (fork) el repositorio.

Desarrollar una API Web basada en controladores en .NET, con las siguientes características:

1. Nombre de la solución: __Dsw2025Ej14__
2. Nombre del proyecto: __Dsw2025Ej14.Api__
3. Capa de dominio (__Domain__) en carpeta dentro del proyecto Api
4. Capa de persistencia de datos (__Data__) en carpeta dentro del proyecto Api
5. El dominio solo tiene la entidad Product, con las siguientes propiedades:
	* Sku (string)
	* Name (string)
	* CurrentUnitPrice (decimal)
	* IsActive (bool)
6. La capa de persistencia cuenta con la clase __PersistenciaEnMemoria__ (registrar como Singleton) que tiene, entre otros necesarios, el método __LoadProducts()__ 
   que obtiene los productos de un JSON (proporcionado) y los guarda en una lista.
7. Agregar el controlador ProductsController con dos endpoints:
	- __Primer endpoint__:
		* Método: `GET`
		* Ruta: `api/products`
		* Descripción: obtener todos los productos activos existentes
		* Respuesta exitosa: 200 OK con la colección de productos
		* Respuesta de error: 204 No Content
	- __Segundo endpoint__:
		* Método: `GET`
		* Ruta: `api/products/{sku}`
		* Descripción: obtener un producto a partir de su SKU
		* Respuesta exitosa: 200 OK con el producto solicitado
		* Respuesta de error: 404 Not Found si no se encuentra el producto
8. Agregar sondeo de estado básico en la ruta `/health-check`

__Aplicar principios y patrones estudiados.__

__Agregar al README lista de estudiantes que participaron y la comisión. Al finalizar la clase se deben subir los cambios al repositorio bifurcado. No se pueden realizar commits una vez subido.__

__Código de ejemplo para importar los productos__ \
`var json = await File.ReadAllTextAsync("products.json");` \
`var products = JsonSerializer.Deserialize<List<Product>>(json);`


## INTEGRANTES
1. CASTRO FACUNDO LEONEL 53159
2. GUZMAN MAURO EMIR 53832
