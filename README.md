# calculator
# Cómo Ejecutar
1. Clona este repositorio en tu máquina local:

   ```shell
   git clone https://github.com/tu-usuario/tu-repositorio.git

Navega hasta el directorio del proyecto:
   cd tu-repositorio
Ejecuta la aplicación utilizando el siguiente comando:
  dotnet run

Esto compilará y ejecutará la aplicación. Verás una URL en la consola donde se está ejecutando la API.

Abre un navegador web y navega a la URL de la API (por ejemplo, http://localhost:5000).

Uso
La API proporciona un endpoint para generar una expresión aritmética que cumple con ciertas condiciones. A continuación se detalla cómo utilizar este endpoint:

Generar expresión aritmética
URL: POST /cals
Descripción: Este endpoint recibe una lista de números enteros y genera una expresión aritmética que cumple con ciertas condiciones.
Parámetros:
numbers (array de enteros): Lista de números enteros para generar la expresión.
Respuesta exitosa:
Código de estado: 200 (OK)
Cuerpo de respuesta: Cadena que representa la expresión generada.
Respuesta de error:
Código de estado: 400 (Bad Request)
Cuerpo de respuesta: Descripción del error.

De manera que usando Swagger como interfaz de la  api podemos obtener el siguiente resueltado:
![image](https://github.com/edsantiago27/calculator/assets/74544113/1ca04ce8-7ea5-4eba-af10-eb9f55d23d24)
