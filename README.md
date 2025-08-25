
# Test de Estilos de Aprendizaje VAK

-----

## 📚 Descripción del Proyecto  

Este proyecto es una aplicación de consola en C\# que implementa un **test interactivo para determinar el estilo de aprendizaje dominante** de un usuario, basado en el **modelo VAK (Visual, Auditivo, Kinestésico)**. Inspirado en la Programación Neurolingüística (PNL), el test busca identificar las vías preferentes de entrada, procesamiento y salida de la información de cada individuo, facilitando una mejor comprensión de cómo aprenden.

La aplicación ofrece tres modalidades de prueba diferentes:

1.  **Selección Única:** El usuario elige una opción de respuesta (A, B, o C) para cada pregunta.
2.  **Selección Múltiple:** El usuario asigna un puntaje (1, 2 o 3) a cada opción de respuesta, indicando su nivel de preferencia.
3.  **Completar:** El usuario debe escribir la palabra o frase correcta para completar un enunciado.

Al finalizar el test, el programa calcula las puntuaciones para cada estilo de aprendizaje y presenta un resumen claro, indicando el estilo dominante o la combinación de estilos.

-----

## ✨ Características Principales

  * **Múltiples Modalidades de Test:** Elige entre selección única, selección múltiple o completar para variar la experiencia del usuario.
  * **Interfaz de Consola Interactiva:** Utiliza animaciones, limpieza de pantalla y posicionamiento del cursor para una experiencia de usuario más atractiva.
  * **Determinación del Estilo VAK:** Calcula y muestra el estilo de aprendizaje predominante del usuario (Visual, Auditivo, Kinestésico), incluyendo la identificación de estilos múltiples si hay empates.
  * **Resultados Detallados:** Presenta tablas claras con las puntuaciones obtenidas por cada pregunta y el total por estilo.
  * **Mensajes Educativos:** Incluye introducciones y conclusiones que explican la importancia del test y el modelo VAK.

-----

## 🚀 Cómo Empezar

### Requisitos

  * **.NET SDK** (preferiblemente .NET 6.0 o superior). Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download).

### Ejecutar el Proyecto

1.  **Clona el repositorio:**
    ```bash
    https://github.com/ezeJona/VAK-Learning-Styles-Test.git
    ```
2.  **Navega al directorio del proyecto:**
    ```bash
    cd VAK-Learning-Styles-Test
    ```

4.  **Ejecuta la aplicación:**
    ```bash
    dotnet run
    ```

-----

## 🛠️ Estructura del Código

El corazón del programa reside en la clase `Program.cs`, que contiene el método `Main()`. La lógica principal se divide en varias secciones:

  * **Inicialización de Datos:** Arrays `item` (preguntas) y `opciones` (respuestas).
  * **Menú Principal:** Permite al usuario seleccionar el tipo de test.
  * **Lógica de Tests (Switch Case):** Implementa las tres modalidades de prueba, incluyendo la validación de entrada y la acumulación de puntajes.
  * **Cálculo y Presentación de Resultados:** Determina el estilo dominante y muestra una tabla resumen.
  * **Manejo de Errores:** Un bloque `try-catch` general para capturar excepciones inesperadas.

### Clase `Animación` 

  * `parpadeo(string texto, int veces)`: Para efectos visuales de texto parpadeante.
  * `PresioneEnter()`: Para pausar la ejecución hasta que se presione Enter.
  * `PresioneColor()`: Para esperar una pulsación de tecla, posiblemente con un cambio de color de texto.
  * `Typing(string texto, int delay)`: Para simular el efecto de escritura en la consola.

-----

## 📞 Contacto

5745 7015


-----
