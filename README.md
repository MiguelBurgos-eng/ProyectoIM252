# Proyecto IM 25-2

**Proyecto de la materia de Implantación y Mantenimiento de Sistemas**

## 📂 Estructura del Proyecto

```tree
src/
├── Application/
├── Domain/
│   └── Entities/
├── Infrastructure/
│   └── Data/    
└── Presentation.WebApp/
    ├── Controllers/
    ├── Models/
    └── Views/
        ├── Clientes/
        ├── Productos/
        ├── ClientesVentas/
        ├── Home/
        └── Shared/
```

---

## 🗃️ Base de Datos

### 📌 Definición de Tablas

```sql
CREATE TABLE IM252Cliente (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL,
    [Direccion] NVARCHAR(255) NULL,
    [Telefono] NVARCHAR(50) NOT NULL,
    [Correo] NVARCHAR(255) NOT NULL,
    CONSTRAINT PK_IM252Cliente PRIMARY KEY ([Id])
);

CREATE TABLE IM252Producto (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR(255) NOT NULL,
    [Precio] SMALLMONEY NOT NULL,
    [Cantidad] TINYINT NOT NULL DEFAULT(0),
    [Foto] NVARCHAR(255) NULL,
    CONSTRAINT PK_IM252Producto PRIMARY KEY ([Id])
);

CREATE TABLE IM252Venta (
    [ClienteId] INT NOT NULL,
    [ProductoId] INT NOT NULL,
    CONSTRAINT FK_IM252ClientesVentas_IM252Cliente FOREIGN KEY ([ClienteId]) REFERENCES [IM252Cliente] ([Id]),
    CONSTRAINT FK_IM252ClientesVentas_IM252Producto FOREIGN KEY ([ProductoId]) REFERENCES [IM252Producto] ([Id])
);
```

---

## 💻 Comandos para Configuración del Proyecto

### 🏗️ Configuración del Dominio

```sh
dotnet new classlib -o ./src/Domain
rm ./src/Domain/Class1.cs
mkdir ./src/Domain/Entities
echo 'namespace Domain;' > ./src/Domain/Entities/Cliente.cs
echo 'namespace Domain;' > ./src/Domain/Entities/Producto.cs
echo 'namespace Domain;' > ./src/Domain/Entities/Ventas.cs
```

### 🏗️ Configuración de la Aplicación

```sh
dotnet new classlib -o ./src/Application
rm ./src/Application/Class1.cs
dotnet add ./src/Application reference ./src/Domain
```

### 🏗️ Configuración de la Infraestructura

```sh
dotnet new classlib -o ./src/Infrastructure
rm ./src/Infrastructure/Class1.cs
mkdir ./src/Infrastructure/Data
echo 'namespace Infrastructure;' > ./src/Infrastructure/Data/ClientesDbContext.cs
echo 'namespace Infrastructure;' > ./src/Infrastructure/Data/ProductosDbContext.cs
echo 'namespace Infrastructure;' > ./src/Infrastructure/Data/VentasDbContext.cs
dotnet add ./src/Infrastructure package Microsoft.Data.SqlClient
dotnet add ./src/Infrastructure reference ./src/Application
```

### 🏗️ Configuración del Proyecto Web MVC

```sh
dotnet new mvc -o ./src/Presentation.WebApp
mkdir ./src/Presentation.WebApp/Views/Clientes
echo 'namespace Presentation.WebApp.Controllers;' > ./src/Presentation.WebApp/Controllers/ClientesController.cs
echo '@{ ViewData["Title"] = "Clientes"; }' >  ./src/Presentation.WebApp/Views/Clientes/Index.cshtml
echo '@{ ViewData["Title"] = "Clientes > Crear"; }' >  ./src/Presentation.WebApp/Views/Clientes/Create.cshtml
echo '@{ ViewData["Title"] = "Clientes > Detalle"; }' >  ./src/Presentation.WebApp/Views/Clientes/Details.cshtml
echo '@{ ViewData["Title"] = "Clientes > Editar"; }' >  ./src/Presentation.WebApp/Views/Clientes/Edit.cshtml
```

### 🏗️ Configuración de las Relaciones entre Proyectos

```sh
dotnet add ./src/Presentation.WebApp reference ./src/Application
dotnet add ./src/Presentation.WebApp reference ./src/Infrastructure
```

---

## 📝 Notas

- Este proyecto sigue la arquitectura en **capas**: _Domain_, _Application_, _Infrastructure_, y _Presentation_.
- Se utiliza **Entity Framework** para el manejo de base de datos.
- **ASP.NET MVC** para la estructura de la aplicación web.
- La base de datos se maneja en **SQL Server**.

---

## 📜 Licencia

Este proyecto es de uso académico para la materia de **Implantación y Mantenimiento de Sistemas**.

