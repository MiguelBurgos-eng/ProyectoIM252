using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Domain;
using Application;
using Infrastructure;
using Domain.Entities;

namespace Presentation.WebApp.Controllers;
public class VentasController : Controller
{
    private readonly VentasDbContext _ventasDbContext;
    private readonly ClientesDbContext _clientesDbContext;
    private readonly ProductosDbContext _productosDbContext;

    public VentasController(IConfiguration configuration)
    {
        _ventasDbContext = new VentasDbContext(configuration.GetConnectionString("DefaultConnection"));
        _clientesDbContext = new ClientesDbContext(configuration.GetConnectionString("DefaultConnection"));
        _productosDbContext = new ProductosDbContext(configuration.GetConnectionString("DefaultConnection"));
    }

    public IActionResult Index()
    {
        var data = _ventasDbContext.List();
        return View(data);
    }

    public IActionResult Details(Guid id)
    {
        var data = _ventasDbContext.Details(id);
        return View(data);
    }

    public IActionResult Create()
    {
        PopulateSelectLists();
        return View();
    }

    [HttpPost]
    public IActionResult Create(Venta data)
    {
        _ventasDbContext.Create(data);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(Guid id)
    {
        var data = _ventasDbContext.Details(id);
        PopulateSelectLists(data);
        return View(data);
    }

    [HttpPost]
    public IActionResult Edit(Venta data)
    {
        _ventasDbContext.Edit(data);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(Guid id)
    {
        _ventasDbContext.Delete(id);
        return RedirectToAction("Index");
    }

    private void PopulateSelectLists(Venta venta = null)
    {
        var clientes = _clientesDbContext.List();
        var productos = _productosDbContext.List();

        ViewBag.ClienteId = new SelectList(clientes, "Id", "Nombre", venta?.Cliente);
        ViewBag.ProductoId = new SelectList(productos, "Id", "Descripcion", venta?.Producto);
    }
}
