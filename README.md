# UserApi-ASP.NET-Core

**UserApi-ASP.NET-Core** es una API RESTful desarrollada en ASP.NET Core para la gestión de usuarios. Esta aplicación demuestra una implementación moderna de servicios web usando ASP.NET Core, con un enfoque en buenas prácticas de codificación y patrones de diseño efectivos. La API permite realizar operaciones CRUD sobre usuarios, interactuando con una base de datos MySQL.

## Descripción del Repositorio

Este proyecto es ideal para aprender cómo construir una API RESTful usando ASP.NET Core, aplicar patrones de diseño como el patrón de repositorio y la inyección de dependencias, y realizar pruebas unitarias efectivas. También es una base sólida para desarrollar aplicaciones más complejas o integrarse en soluciones empresariales.

## Características Principales

- **CRUD de Usuarios**: Operaciones completas para crear, leer, actualizar y eliminar usuarios.
- **Inyección de Dependencias**: Utiliza el patrón de diseño de inyección de dependencias para una arquitectura flexible y desacoplada.
- **Repositorio y Controladores RESTful**: Implementa el patrón de repositorio para manejar el acceso a datos y controladores RESTful para gestionar las solicitudes HTTP.
- **Manejo de Excepciones**: Incluye una clase centralizada para gestionar errores y respuestas HTTP consistentes.
- **Pruebas Unitarias**: Integración de pruebas unitarias con xUnit y Moq para garantizar la calidad del código y el comportamiento esperado de la API.
- **Documentación con Swagger**: Genera documentación interactiva para explorar y probar los endpoints de la API.

## Requisitos

- **.NET SDK**: 8.0 o superior
- **MySQL**: 8.0 o superior
- **Herramientas de Desarrollo**: Visual Studio, Visual Studio Code o un IDE compatible

## Instrucciones

1. **Configura la Cadena de Conexión**:
    - Abre el archivo `appsettings.json`.
    - Configura la cadena de conexión para la base de datos MySQL:
    ```json
    "ConnectionStrings": {
        "DbConnection": "server=bdu7q4eoemgqsx2zsppe-mysql.services.clever-cloud.com;database=bdu7q4eoemgqsx2zsppe;port=3306;uid=uj6zmgxtbavzomsm;password=LmIY8usSjrxkcHlNd6s0;"
    }
    ```

2. **Instala las Dependencias**:
    - Ejecuta el siguiente comando para restaurar los paquetes NuGet:
    ```bash
    dotnet restore
    ```

3. **Compila el Proyecto**:
    - Ejecuta el siguiente comando para construir la solución:
    ```bash
    dotnet build
    ```

4. **Ejecuta el Proyecto**:
    - Inicia la aplicación con el siguiente comando:
    ```bash
    dotnet run
    ```

5. **Accede a la Documentación de la API**:
    - La documentación interactiva generada con Swagger estará disponible en [http://localhost:5000/swagger](http://localhost:5000/swagger).

6. **Realiza Pruebas Unitarias**:
    - Para ejecutar las pruebas unitarias, asegúrate de tener el proyecto de pruebas configurado y ejecuta:
    ```bash
    dotnet test
    ```

## Dependencias y NuGet Packages

- **ASP.NET Core**: 8.0
- **Pomelo.EntityFrameworkCore.MySql**: 8.0.23
- **Moq**: 4.20.0
- **xUnit**: 2.4.2

## By @KevinDazaR

