using Microsoft.Data.SqlClient;
using System.Data;
using Domain;

namespace Infrastructure;

public class ClientesDbContext
{
    private readonly string _connectionString;

    public ClientesDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Cliente> List()
    {
        var data = new List<Cliente>();

        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("SELECT [Id],[Nombre],[Direccion],[Telefono],[Correo] FROM [IM252Cliente]", con);
        
        try
        {
            con.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data.Add(new Cliente
                {
                    Id = (Guid)dr["Id"],
                    Nombre = (string)dr["Nombre"],
                    Direccion = (string)dr["Direccion"],
                    Telefono = (string)dr["Telefono"],
                    Correo = (string)dr["Correo"]

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

    public Cliente Details(Guid id)
    {
        var data = new Cliente();

        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("SELECT [Id],[Nombre],[Direccion],[Telefono],[Correo] FROM [IM252Cliente] WHERE [Id] = @id", con);
        cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
        try
        {
            con.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                data.Id = (Guid)dr["Id"];
                data.Nombre = (string)dr["Nombre"];
                data.Direccion = (string)dr["Direccion"];
                data.Telefono = (string)dr["Telefono"];
                data.Correo = (string)dr["Correo"];

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

    public void Create(Cliente data)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("INSERT INTO [IM252Cliente] ([Id],[Nombre],[Direccion],[Telefono],[Correo]) VALUES (@id,@nombre,@direccion,@telefono,@correo)", con);
        cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
        cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 256).Value = data.Nombre;
        cmd.Parameters.Add("direccion", SqlDbType.NVarChar,512).Value = data.Direccion;
        cmd.Parameters.Add("telefono", SqlDbType.NVarChar,128).Value = data.Telefono;
        cmd.Parameters.Add("correo", SqlDbType.NVarChar,256).Value = data.Correo;        
        

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

    public void Edit(Cliente data)
    {
        var con = new SqlConnection(_connectionString);
        var cmd = new SqlCommand("UPDATE [IM252Cliente] SET [Nombre] = @nombre, [Direccion] = @direccion,[Telefono] = @telefono,[Correo] = @correo WHERE [Id] = @id", con);
        cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
        cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 256).Value = data.Nombre;
        cmd.Parameters.Add("direccion", SqlDbType.NVarChar,512).Value = data.Direccion;
        cmd.Parameters.Add("telefono", SqlDbType.NVarChar,128).Value = data.Telefono;
        cmd.Parameters.Add("correo", SqlDbType.NVarChar,256).Value = data.Correo;          
        // cmd.Parameters.Add("Foto", SqlDbType.NVarChar).Value = data.Foto == null ? DBNull.Value : data.Foto;
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
        var cmd = new SqlCommand("DELETE FROM [IM252Cliente] WHERE [Id] = @id", con);
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