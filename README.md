# Employee Central API REST

Employee Central es una API REST desarrollada con ASP.NET Core y Entity Framework Core, diseñada para la gestión de empleados en una empresa. Esta API permite realizar operaciones CRUD sobre empleados y calcular porcentajes mediante un servicio de cálculo.

## Características Principales

- CRUD (Crear, Leer, Actualizar, Eliminar) para empleados.
- Cálculo de porcentajes.
- Estructura de proyecto con inyección de dependencias y servicios definidos.
- Respuestas estandarizadas con `ApiResponse<T>`.

## Tecnologías Utilizadas

- ASP.NET Core
- Entity Framework Core
- AutoMapper
- SQL Server

## Requisitos Previos

Para ejecutar esta aplicación, necesitarás:

- .NET Core SDK 7
- SQL Server
- Visual Studio o cualquier otro editor de código compatible (como VSCode)

## Configuración e Instalación

1. Clona este repositorio en tu máquina local.
2. Abre la solución en Visual Studio o tu editor de código preferido.
3. Restaura los paquetes NuGet.
4. Configura la cadena de conexión a la base de datos en `appsettings.json`.
5. Ejecuta `Update-Database` para aplicar las migraciones a tu base de datos.
6. Inicia la aplicación.

## Uso de la API

La API proporciona los siguientes endpoints:

### Empleados

- `GET /api/employee`: Obtiene una lista de todos los empleados.
- `GET /api/employee/{id}`: Obtiene los detalles de un empleado específico.
- `POST /api/employee`: Crea un nuevo empleado.
- `PUT /api/employee/{id}`: Actualiza un empleado existente.
- `DELETE /api/employee/{id}`: Elimina un empleado.

### Cálculo de Porcentajes

- `GET /api/percentage?number={num}&percentage={perc}`: Calcula el porcentaje de un número.

## Contacto

- Desarrollador: José Luis Lovera
- Email: joseluiz123.jllg@gmail.com
- Enlace al proyecto: https://github.com/thechemm/EmployeeCentralApiRest
