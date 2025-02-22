using Microsoft.Data.SqlClient;
using System.Data;

using Domain;
using Application;
using Domain.Entities;

namespace Infrastructure;

public class VentasDbContext
{
    private readonly string _connectionString;

    public VentasDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }
/*
CREATE TABLE [IM252Venta] (
    [Id] [uniqueidentifier] NOT NULL,
    [ClienteId] [uniqueidentifier] NOT NULL,
    [ProductoId] [uniqueidentifier] NOT NULL,
    [Fecha] [smalldatetime] NOT NULL,

    CONSTRAINT PK_IM252Venta PRIMARY KEY ([Id]),
    CONSTRAINT FK_IM252Venta_IM252Cliente FOREIGN KEY ([ClienteId]) REFERENCES [IM252Cliente] ([Id]),
    CONSTRAINT FK_IM252Venta_IM252Producto FOREIGN KEY ([ProductoId]) REFERENCES [IM252Producto] ([Id])
);
*/
/*
CREATE TABLE [IM252Cliente](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](256) NOT NULL,
	[Direccion] [nvarchar](512) NULL,
	[Telefono] [nvarchar](128) NOT NULL,
	[Correo] [nvarchar](256) NOT NULL,
    CONSTRAINT PK_IM252Cliente PRIMARY KEY ([Id])
);
*/
/*
CREATE TABLE [IM252Producto](
	[Id] [uniqueidentifier] NOT NULL,
	[Descripcion] [nvarchar](128) NULL,
	[Precio] [smallmoney] NOT NULL,
	[Cantidad] [tinyint] NOT NULL DEFAULT(0),
	[Foto] [nvarchar](max) NULL,
    CONSTRAINT PK_IM252Producto PRIMARY KEY ([Id])
);

)
*/
    public List<Venta> List()
    {
        var data = new List<Venta>();

        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand(@"
            SELECT v.[Id], v.[ClienteId], v.[ProductoId], v.[Fecha],
                c.[Id] AS ClienteId, c.[Nombre], c.[Direccion], c.[Telefono], c.[Correo],
                p.[Id] AS ProductoId, p.[Descripcion], p.[Precio], p.[Cantidad], p.[Foto]
            FROM [IM252Venta] v
            JOIN [IM252Cliente] c ON v.[ClienteId] = c.[Id]
            JOIN [IM252Producto] p ON v.[ProductoId] = p.[Id]", con);
        try
        {
            con.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var Venta = new Venta
                {
                    Id = (Guid)dr["Id"],
                    ClienteId = (Guid)dr["ClienteId"],
                    ProductoId = (Guid)dr["ProductoId"],
                    Fecha = (DateTime)dr["Fecha"],
                    
                    Cliente = new Cliente
                    {
                        Id = (Guid)dr["ClienteId"],
                        Nombre = (string)dr["Nombre"],
                        Direccion = (string)dr["Direccion"],
                        Telefono = (string)dr["Telefono"],
                        Correo = (string)dr["Correo"],
                    },
                    Producto = new Producto
                    {
                        Id = (Guid)dr["ProductoId"],
                        Descripcion = (string)dr["Descripcion"],
                        Precio = (decimal)dr["Precio"],
                        Cantidad = (byte)dr["Cantidad"],
                        Foto = (string)dr["Foto"],
                    }
                };
                data.Add(Venta);
            }
            return data;
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }

    public Venta Details(Guid id)
    {
        var data = new Venta();

        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand(@"
            SELECT v.[Id], v.[ClienteId], v.[ProductoId], v.[Fecha],
                c.[Id] AS ClienteId, c.[Nombre], c.[Direccion], c.[Telefono], c.[Correo],
                p.[Id] AS ProductoId, p.[Descripcion], p.[Precio], p.[Cantidad], p.[Foto]
            FROM [IM252Venta] v
            JOIN [IM252Cliente] c ON v.[ClienteId] = c.[Id]
            JOIN [IM252Producto] p ON v.[ProductoId] = p.[Id]
            WHERE v.[Id] = @id", con);
        cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
        try
        {
            con.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                data.Id = (Guid)dr["Id"];
                data.ClienteId = (Guid)dr["ClienteId"];
                data.ProductoId = (Guid)dr["ProductoId"];
                data.Fecha = (DateTime)dr["Fecha"];
                data.Cliente = new Cliente
                {
                    Id = (Guid)dr["ClienteId"],
                    Nombre = (string)dr["Nombre"],
                    Direccion = (string)dr["Direccion"],
                    Telefono = (string)dr["Telefono"],
                    Correo = (string)dr["Correo"],
                };
                data.Producto = new Producto
                {
                    Id = (Guid)dr["ProductoId"],
                    Descripcion = (string)dr["Descripcion"],
                    Precio = (decimal)dr["Precio"],
                    Cantidad = (byte)dr["Cantidad"],
                    Foto = (string)dr["Foto"],
                };
            }
            return data;
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }

    public void Create(Venta data)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("INSERT INTO [IM252Venta] ([Id],[ClienteId],[ProductoId],[Fecha]) VALUES (@id,@clienteId,@productoId,@fecha)", con);
        cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
        cmd.Parameters.Add("@clienteId", SqlDbType.UniqueIdentifier).Value = data.ClienteId;
        cmd.Parameters.Add("@productoId", SqlDbType.UniqueIdentifier).Value = data.ProductoId;
        cmd.Parameters.Add("@fecha", SqlDbType.SmallDateTime).Value = data.Fecha;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }

    public void Edit(Venta data)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("UPDATE [IM252Venta] SET [ClienteId] = @clienteId, [ProductoId] = @productoId, [Fecha] = @fecha WHERE [Id] = @id", con);
        cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
        cmd.Parameters.Add("clienteId", SqlDbType.UniqueIdentifier).Value = data.Cliente;
        cmd.Parameters.Add("productoId", SqlDbType.UniqueIdentifier).Value = data.Producto;
        cmd.Parameters.Add("fecha", SqlDbType.SmallDateTime).Value = data.Fecha;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }

    public void Delete(Guid id)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("DELETE FROM [IM252Venta] WHERE [Id] = @id", con);
        cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = id;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }
}