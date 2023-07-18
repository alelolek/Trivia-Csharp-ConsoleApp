# Aplicación de Trivia en Consola

![Diagrama de Arquitectura](https://github.com/alelolek/Trivia-Csharp-ConsoleApp/blob/main/DiagramaDeArquitectura.png)

## Descripción general
La Aplicación de Trivia en Consola es un proyecto en C# .NET 6 diseñado para proporcionar una experiencia de juego de trivia en un entorno de consola. Sigue los principios de la Programación Orientada a Objetos (POO) y está construido con una arquitectura en capas, que consiste en múltiples capas para separar las responsabilidades y mejorar la mantenibilidad.

El proyecto está organizado en las siguientes capas:

1. **Capa de Presentación**
   - La capa de presentación es responsable de la interfaz de usuario y la interacción. Contiene el archivo principal del programa y la clase `TriviaView`, que incluye el método `Start` para iniciar el programa.

2. **Capa de Datos**
   - La capa de datos se encarga del almacenamiento y la recuperación de datos. Incluye los siguientes componentes:
     - **Question.Json**: Un archivo JSON donde se almacenan todos los datos de la trivia.
     - **JsonManager**: Una clase que proporciona funcionalidad para leer y escribir datos JSON.
     - **QuestionRepository**: Una clase que interactúa con el archivo JSON y proporciona métodos para acceder a las preguntas de la trivia.
     - **Interfaces**: Definiciones de interfaces para las clases `JsonManager` y `QuestionRepository`.

3. **Capa de Funcionalidades Compartidas**
   - La capa de funcionalidades compartidas contiene clases de utilidad y funcionalidades compartidas utilizadas en múltiples capas. Incluye los siguientes componentes:
     - **Dto**: Objetos de Transferencia de Datos (DTO) que representan la estructura de los datos intercambiados entre capas.
     - **Enums**: Una clase de enumeración que define varios tipos o categorías utilizadas en la aplicación.

4. **Capa de Negocio**
   - La capa de negocio contiene la lógica principal y los servicios del juego de trivia. Incluye clases responsables de gestionar el flujo del juego, procesar la entrada del usuario y evaluar respuestas.

## Instalación
Para ejecutar la Aplicación de Trivia en Consola, sigue estos pasos:

1. Clona el repositorio: `git clone https://github.com/alelolek/Trivia-Csharp-ConsoleApp`
2. Abre el proyecto en Visual Studio o tu IDE preferido.
3. Asegúrate de que .NET 6 esté instalado.
4. Compila el proyecto para restaurar los paquetes de NuGet y compilar el código.
5. Ejecuta la aplicación y ¡disfruta jugando a la trivia!

## Demostración Proyecto Scheduly

[Aplicación de Consola C# - Trivia de Programación](https://youtu.be/vefDOPhwoHM)

## Licencia
Este proyecto está bajo la [Licencia MIT](https://github.com/alelolek/Trivia-Csharp-ConsoleApp/blob/main/LICENSE.txt).

## Contribuciones
¡Se aceptan contribuciones a la Aplicación de Trivia en Consola! Si encuentras algún problema o tienes sugerencias para mejoras, por favor abre un issue o envía una pull request.

¡Diviértete jugando trivia!
