namespace Domain;

public class Producto
{
    public Guid Id { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public byte Cantidad { get; set; }
    public string Foto { get; set; }
	
}

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