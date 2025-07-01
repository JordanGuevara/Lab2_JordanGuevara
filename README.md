# Laboratorio: Uso de ViewModel y Operaciones CRUD en .NET

## Descripción

Este laboratorio tiene como objetivo desarrollar una aplicación básica en .NET que permita realizar las operaciones CRUD (Crear, Leer, Actualizar y Eliminar) sobre una base de datos SQL Server utilizando Entity Framework como ORM. Se implementa el patrón MVC, usando ViewModels para mejorar la organización y presentación de datos, y Razor para construir vistas dinámicas.

## Funcionalidades

- Conexión a base de datos SQL Server mediante Entity Framework.
- Gestión completa de clientes: crear, listar, editar y eliminar registros.
- Uso de ViewModels para transportar datos específicos entre controladores y vistas.
- Formularios con validación básica y manejo de imágenes (foto de cliente).
- Interfaz sencilla y funcional con Razor.

## Tecnologías usadas

- ASP.NET MVC (.NET Framework)
- Entity Framework 6
- Razor Views
- SQL Server
- jQuery UI (datepicker)

## Cómo ejecutar

1. Abrir el proyecto en Visual Studio.
2. Configurar la cadena de conexión en `Web.config` para apuntar a tu base de datos SQL Server.
3. Ejecutar la aplicación y navegar al controlador de clientes para probar las operaciones CRUD.
