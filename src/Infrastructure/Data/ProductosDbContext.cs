using Microsoft.Data.SqlClient;
using System.Data;
using Domain;
using Application;

namespace Infrastructure;

public class ProductosDbContext
{
    private readonly string _connectionString;

    public ProductosDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Producto> List()
    {
        var data = new List<Producto>();

        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("SELECT [Id],[Descripcion],[Precio],[Cantidad],[Foto] FROM [IM252Producto]", con);
        
        try
        {
            con.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data.Add(new Producto
                {
                Id = (Guid)dr["Id"],
                Descripcion = (string)dr["Descripcion"],
                Precio = (decimal)dr["Precio"],
                Cantidad = (byte)dr["Cantidad"],
                Foto = dr["Foto"] as string ?? FileConverterService.PlaceHolder,

                });
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

    public Producto Details(Guid id)
    {
        var data = new Producto();

        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("SELECT [Id],[Descripcion],[Precio],[Cantidad],[Foto] FROM [IM252Producto] WHERE [Id] = @id", con);
        cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
        try
        {
            con.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                data.Id = (Guid)dr["Id"];
                data.Descripcion = (string)dr["Descripcion"];
                data.Precio = (decimal)dr["Precio"];
                data.Cantidad = (byte)dr["Cantidad"];
                data.Foto = dr["Foto"] as string ?? FileConverterService.PlaceHolder;

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

    public void Create(Producto data)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("INSERT INTO [IM252Producto] ([Id],[Descripcion],[Precio],[Cantidad],[Foto]) VALUES (@id,@descripcion,@precio,@cantidad,@foto)", con);
        cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
        cmd.Parameters.Add("descripcion", SqlDbType.NVarChar, 256).Value = data.Descripcion;
        cmd.Parameters.Add("precio", SqlDbType.SmallMoney).Value = data.Precio;
        cmd.Parameters.Add("cantidad", SqlDbType.TinyInt).Value = data.Cantidad;
        cmd.Parameters.Add("foto", SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;

        /*
        CREATE TABLE [IM252Producto](
        [Id] [uniqueidentifier] NOT NULL,
        [Descripcion] [nvarchar](128) NULL,
        [Precio] [smallmoney] NOT NULL,
        [Cantidad] [tinyint] NOT NULL DEFAULT(0),
        [Foto] [nvarchar](max) NULL,
        CONSTRAINT PK_IM252Producto PRIMARY KEY ([Id])
        );
        */
        

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

    public void Edit(Producto data)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("UPDATE [IM252Producto] SET [Descripcion] = @descripcion,[Precio] = @precio,[Cantidad] = @cantidad,[Foto]=@foto WHERE [Id] = @id", con);
        cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
        cmd.Parameters.Add("descripcion", SqlDbType.NVarChar, 256).Value = data.Descripcion;
        cmd.Parameters.Add("precio", SqlDbType.SmallMoney).Value = data.Precio;
        cmd.Parameters.Add("cantidad", SqlDbType.TinyInt).Value = data.Cantidad;
        cmd.Parameters.Add("Foto", SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;
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
        var cmd = new SqlCommand("DELETE FROM [IM252Producto] WHERE [Id] = @id", con);
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
