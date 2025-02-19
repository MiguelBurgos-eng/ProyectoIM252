# Proyecto IM 25-2
Proyecto de la materia de Implantación y Mantenimiento de Sistemas

## Data
```sql
CREATE TABLE IM252Cliente NOT NULL,
    [Direccion] nvarchar NULL,
    [Telefono] nvarchar NOT NULL,
    [Correo] nvarchar NOT NULL,
    CONSTRAINT PK_IM252Cliente PRIMARY KEY ([Id])
);

CREATE TABLE IM252Producto NULL,
    [Precio] [smallmoney] NOT NULL,
    [Cantidad] [tinyint] NOT NULL DEFAULT(0),
    [Foto] nvarchar NULL,
    CONSTRAINT PK_IM252Producto PRIMARY KEY ([Id])
);

CREATE TABLE IM252ClientesVentas,
    CONSTRAINT FK_IM252ClientesVentas_IM252Cliente FOREIGN KEY ([ClienteId]) REFERENCES [IM252Cliente] ([Id]),
    CONSTRAINT FK_IM252ClientesVentas_IM252Producto FOREIGN KEY ([ProductoId]) REFERENCES [IM252Producto] ([Id])
);


## Structure

└───src
    ├───Application
    ├───Domain
    │   └───Entities
    ├───Infrastructure
    │   └───Data    
    └───Presentation.WebApp
        ├───Controllers
        ├───Models
        └───Views
            ├───Empleados
            ├───Home
            └───Shared

## Comandos

dotnet new classlib -o .\src\Domain
rm .\src\Domain\Class1.cs
mkdir .\src\Domain\Entities
echo 'namespace Domain;' > .\src\Domain\Entities\Cliente.cs
echo 'namespace Domain;' > .\src\Domain\Entities\Producto.cs
echo 'namespace Domain;' > .\src\Domain\Entities\ClientesVentas.cs


dotnet new classlib -o .\src\Application
rm .\src\Application\Class1.cs
dotnet add .\src\Application reference .\src\Domain

dotnet new classlib -o .\src\Infrastructure
rm .\src\Infrastructure\Class1.cs
mkdir .\src\Infrastructure\Data
echo 'namespace Infrastructure;' > .\src\Infrastructure\Data\ClientesDbContext.cs
echo 'namespace Infrastructure;' > .\src\Infrastructure\Data\ProductosDbContext.cs
echo 'namespace Infrastructure;' > .\src\Infrastructure\Data\ClientesVentasDbContext.cs
dotnet add .\src\Infrastructure package Microsoft.Data.SqlClient
dotnet add .\src\Infrastructure reference .\src\Application

dotnet new mvc -o .\src\Presentation.WebApp
mkdir .\src\Presentation.WebApp\Views\Clientes
echo 'namespace Presentation.WebApp.Controllers;' > .\src\Presentation.WebApp\Controllers\ClientesController.cs
echo '@{ ViewData["Title"] = "Clientes"; }' >  .\src\Presentation.WebApp\Views\Clientes\Index.cshtml
echo '@{ ViewData["Title"] = "Clientes > Crear"; }' >  .\src\Presentation.WebApp\Views\Clientes\Create.cshtml
echo '@{ ViewData["Title"] = "Clientes > Detalle"; }' >  .\src\Presentation.WebApp\Views\Clientes\Details.cshtml
echo '@{ ViewData["Title"] = "Clientes > Editar"; }' >  .\src\Presentation.WebApp\Views\Clientes\Edit.cshtml

mkdir .\src\Presentation.WebApp\Views\Productos
echo 'namespace Presentation.WebApp.Controllers;' > .\src\Presentation.WebApp\Controllers\ProductosController.cs
echo '@{ ViewData["Title"] = "Productos"; }' >  .\src\Presentation.WebApp\Views\Productos\Index.cshtml
echo '@{ ViewData["Title"] = "Productos > Crear"; }' >  .\src\Presentation.WebApp\Views\Productos\Create.cshtml
echo '@{ ViewData["Title"] = "Productos > Detalle"; }' >  .\src\Presentation.WebApp\Views\Productos\Details.cshtml
echo '@{ ViewData["Title"] = "Productos > Editar"; }' >  .\src\Presentation.WebApp\Views\Productos\Edit.cshtml

mkdir .\src\Presentation.WebApp\Views\ClientesVentas
echo 'namespace Presentation.WebApp.Controllers;' > .\src\Presentation.WebApp\Controllers\ClientesVentasController.cs
echo '@{ ViewData["Title"] = "ClientesVentas"; }' >  .\src\Presentation.WebApp\Views\ClientesVentas\Index.cshtml
echo '@{ ViewData["Title"] = "ClientesVentas > Crear"; }' >  .\src\Presentation.WebApp\Views\ClientesVentas\Create.cshtml
echo '@{ ViewData["Title"] = "ClientesVentas > Detalle"; }' >  .\src\Presentation.WebApp\Views\ClientesVentas\Details.cshtml
echo '@{ ViewData["Title"] = "ClientesVentas > Editar"; }' >  .\src\Presentation.WebApp\Views\ClientesVentas\Edit.cshtml

dotnet add .\src\Presentation.WebApp reference .\src\Application
dotnet add .\src\Presentation.WebApp reference .\src\Infrastructure



