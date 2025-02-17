using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Domain;
using Infrastructure;

namespace Presentation.WebApp.Controllers;

public class ClientesController : Controller
{
      private readonly ClientesDbContext _clientesDbContext;
      public ClientesController(IConfiguration configuration)
      {
            _clientesDbContext = new ClientesDbContext(configuration.GetConnectionString("DefaultConnection"));
      }

      public IActionResult Index()
      {
            var data = _clientesDbContext.List();
            return View(data);
      }

      public IActionResult Details(Guid id)
      {
            var data = _clientesDbContext.Details(id);
            return View(data);
      }

      public IActionResult Create()
      {
            return View();
      }
      [HttpPost]
      public IActionResult Create(Cliente data)
      {
            data.Id = Guid.NewGuid();
            _clientesDbContext.Create(data);
            return RedirectToAction("Index");
      }

      public IActionResult Edit(Guid id)
      {
            var data = _clientesDbContext.Details(id);
            return View(data);
      }
      [HttpPost]
      public IActionResult Edit(Cliente data)
      {
            _clientesDbContext.Edit(data);
            return RedirectToAction("Index");
      }

      public IActionResult Delete(Guid id)
      {
            _clientesDbContext.Delete(id);
            return RedirectToAction("Index");
      }
}