# Eventix - Aplicación Web ASP.NET MVC y Generación de Código

Proyecto desarrollado en el ecosistema .NET (C#) que combina una aplicación web MVC para la gestión de entradas de eventos culturales y deportivos con herramientas de desarrollo dirigido por modelos (MDD/DSL) y generación automática de código.

## Stack Tecnológico
- **Backend y Modelado:** C#, ASP.NET MVC (.NET Framework), Plantillas T4 (DSL Tools)
- **Base de Datos y ORM:** SQL Server Express, Entity Framework (Code First y Migrations)
- **Frontend:** Razor Views, HTML5, CSS3, JavaScript, Bootstrap
- **Metodología y Herramientas:** Scrum, Azure DevOps y GitFlow

## Qué incluye el proyecto
- **Plataforma Web (Eventix):** Gestión CRUD de entradas para distintos tipos de eventos (conciertos, teatro, musicales, deportes, museos y visitas guiadas) con autenticación de proveedores mediante ASP.NET Identity y sistema de valoraciones.
- **Persistencia Incremental:** Evolución del esquema de base de datos a partir del modelo de dominio con migraciones de Entity Framework.
- **Generación de Código (DSL/T4):** Transformación de modelos mediante plantillas T4 en C# para generar clases automáticamente.

## Ejecución Local
1. Clonar el repositorio y abrir la solución (`.sln`) en Visual Studio 2022.
2. Restaurar los paquetes NuGet y ejecutar `update-database` en la *Package Manager Console* para inicializar la base de datos local.
3. Ejecutar la aplicación web con IIS Express (`F5`).

---
*Proyecto académico — Grado en Ingeniería del Software (ETSISI - UPM).*
