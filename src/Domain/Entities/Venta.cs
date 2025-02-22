namespace Domain.Entities
{
public class Venta
{
    public Guid Id { get; set; }
    public Guid ClienteId { get; set; }
    public Guid ProductoId { get; set; }
    public DateTime Fecha { get; set; }

    public Cliente Cliente { get; set; }
    public Producto Producto { get; set; }
}
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