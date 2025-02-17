using Microsoft.AspNetCore.Mvc;
using Domain;
using Infrastructure;
using System.Reflection;
using System.Drawing;
using Application;


namespace Presentation.WebApp.Controllers;

public class ProductosController : Controller
{
      private readonly ProductosDbContext _productosDbContext;
      public ProductosController(IConfiguration configuration)
      {
            _productosDbContext = new ProductosDbContext(configuration.GetConnectionString("DefaultConnection"));
      }

      public IActionResult Index()
      {
            var data = _productosDbContext.List();
            return View(data);
      }

      public IActionResult Details(Guid id)
      {
            var data = _productosDbContext.Details(id);
            return View(data);
      }

      public IActionResult Create()
      {
            return View();
      }
      [HttpPost]
      public IActionResult Create(Producto data, IFormFile file)
      {
            data.Id = Guid.NewGuid();
            if (file !=null){
                  data.Foto = FileConverterService.ConvertToBase64(file.OpenReadStream());
            }
            _productosDbContext.Create(data);
            return RedirectToAction("Index");
      }

      public IActionResult Edit(Guid id)
      {
            var data = _productosDbContext.Details(id);
            return View(data);
      }
      [HttpPost]
      public IActionResult Edit(Producto data, IFormFile file)
      {
            if(file != null){
                  data.Foto = FileConverterService.ConvertToBase64(file.OpenReadStream());
            }
            _productosDbContext.Edit(data);
            return RedirectToAction("Index");
      }

      public IActionResult Delete(Guid id)
      {
            _productosDbContext.Delete(id);
            return RedirectToAction("Index");
      }

}