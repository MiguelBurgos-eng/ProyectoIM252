namespace Domain;

public class Cliente
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
   
	
}

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