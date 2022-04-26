# Syra

ASP.NET Core MVC app showcasing EF Core and tests.

Adapted from the official EF Core tutorials for [Razor pages](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code) and [MVC](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/?view=aspnetcore-5.0).

## Development notes

### Installing dependencies

```bash
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

### Scaffolding with SQLite

Note: the model classes must have already been created.

```bash
# Web controller for students (returns HTML views)
dotnet-aspnet-codegenerator controller -name StudentsController -m Student -dc Syra.Data.SyraContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

# Web controller for resources (returns HTML views)
dotnet-aspnet-codegenerator controller -name ResourcesController -m Resource -dc Syra.Data.SyraContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

# Web controller for users (returns HTML views)
dotnet-aspnet-codegenerator controller -name UsersController -m User -dc Syra.Data.SyraContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

```

### Initial migration

Note: these commands cannot be run while executing the code.

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
