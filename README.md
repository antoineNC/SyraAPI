
# Syra
### Installing dependencies

```bash
dotnet tool install --global dotnet-ef --version 5.0.2
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.0.2
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.2
```

### Scaffolding with SQLite

Note: the model classes must have already been created.

```bash
# Web controller for students (returns HTML views)
dotnet-aspnet-codegenerator controller -name UsersController -m User -dc SyraContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

# Web controller for courses (returns HTML views)
dotnet-aspnet-codegenerator controller -name ResourcesController -m Resource -dc SyraContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

```

### Initial migration

Note: these commands cannot be run while executing the code.

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
